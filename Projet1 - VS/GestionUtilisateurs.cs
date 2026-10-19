using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet1___VS
{
    public partial class GestionUtilisateurs : Form
    {
        private decimal noUtilisateurConnecte;
        private bool enModeAjout = false;
        private bool enModeModification = false;

        public GestionUtilisateurs() : this(1)
        {
        }

        public GestionUtilisateurs(decimal currentUserId)
        {
            InitializeComponent();
            this.noUtilisateurConnecte = currentUserId;
        }

        private void GestionUtilisateurs_Load(object sender, EventArgs e)
        {
            try
            {
                utilisateurDataGridView.AllowUserToAddRows = false;
                txtNoUtilisateur.DataBindings.Clear();
                txtNom.DataBindings.Clear();
                txtMotDePasse.DataBindings.Clear();
                cboTypeUtilisateur.DataBindings.Clear();

                cboTypeUtilisateur.DataSource = typeUtilisateurBindingSource;
                cboTypeUtilisateur.DisplayMember = "identification";
                cboTypeUtilisateur.ValueMember = "NoType";

                this.typeUtilisateurTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeUtilisateur);
                this.utilisateurTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Utilisateur);

                this.utilisateurBindingSource.CurrentChanged += utilisateurBindingSource_CurrentChanged;
                utilisateurBindingSource_CurrentChanged(null, null);

                GererEtatControles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void utilisateurBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (enModeAjout) return;

            if (utilisateurBindingSource.Current is DataRowView drv)
            {
                txtNoUtilisateur.Text = drv["NoUtilisateur"].ToString();
                txtNom.Text = drv["Nom"].ToString();
                txtMotDePasse.Text = drv["MotDePasse"].ToString();
                cboTypeUtilisateur.SelectedValue = drv["NoType"];
            }
            else
            {
                txtNoUtilisateur.Clear();
                txtNom.Clear();
                txtMotDePasse.Clear();
                cboTypeUtilisateur.SelectedIndex = -1;
            }
        }

        private void GererEtatControles(bool enEdition)
        {
            utilisateurDataGridView.Enabled = !enEdition;

            btnAjouter.Enabled = !enEdition;
            btnModifier.Enabled = !enEdition && utilisateurBindingSource.Count > 0;
            btnSupprimer.Enabled = !enEdition && utilisateurBindingSource.Count > 0;

            btnEnregistrer.Enabled = enEdition;
            btnAnnuler.Enabled = enEdition;

            txtNoUtilisateur.ReadOnly = true;
            txtNom.ReadOnly = !enModeAjout;
            txtMotDePasse.ReadOnly = !enEdition;

            if (enModeAjout)
            {
                cboTypeUtilisateur.Enabled = true;
            }
            else if (enModeModification)
            {
                if (utilisateurBindingSource.Current is DataRowView currentRow)
                {
                    decimal selectedUserId = Convert.ToDecimal(currentRow["NoUtilisateur"]);
                    cboTypeUtilisateur.Enabled = (selectedUserId != noUtilisateurConnecte);
                }
            }
            else
            {
                cboTypeUtilisateur.Enabled = false;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            enModeAjout = true;
            enModeModification = false;

            decimal prochainNo = 1;
            if (bDB56Projet1BKGDataSet.Utilisateur.Count > 0)
            {
                prochainNo = bDB56Projet1BKGDataSet.Utilisateur.Max(u => u.NoUtilisateur) + 1;
            }

            txtNoUtilisateur.Text = prochainNo.ToString();
            txtNom.Clear();
            txtMotDePasse.Clear();

            if (bDB56Projet1BKGDataSet.TypeUtilisateur.Count > 0)
                cboTypeUtilisateur.SelectedValue = bDB56Projet1BKGDataSet.TypeUtilisateur[0].NoType;

            GererEtatControles(true);
            txtNom.Focus();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (utilisateurBindingSource.Current == null) return;

            enModeAjout = false;
            enModeModification = true;
            GererEtatControles(true);
            txtMotDePasse.Focus();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (utilisateurBindingSource.Current == null) return;

            DataRowView ligneCourante = (DataRowView)utilisateurBindingSource.Current;
            decimal noCible = Convert.ToDecimal(ligneCourante["NoUtilisateur"]);
            string nomCible = ligneCourante["Nom"].ToString();

            if (noCible == 1)
            {
                MessageBox.Show("Impossible de supprimer l'administrateur initial (no 1).",
                    "Opération interdite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (noCible == noUtilisateurConnecte)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer votre propre compte.",
                    "Opération interdite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Voulez-vous vraiment supprimer l'utilisateur '{nomCible}' (No {noCible}) ?",
                "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                utilisateurBindingSource.RemoveCurrent();
                SauvegarderDonnees();
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nomSaisi = txtNom.Text.Trim();
            string mdpSaisi = txtMotDePasse.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomSaisi) || string.IsNullOrWhiteSpace(mdpSaisi) || cboTypeUtilisateur.SelectedValue == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enModeAjout)
            {
                bool nomExisteDeja = bDB56Projet1BKGDataSet.Utilisateur.Any(u =>
                    u.RowState != DataRowState.Deleted && u.Nom.Trim().Equals(nomSaisi, StringComparison.OrdinalIgnoreCase));

                if (nomExisteDeja)
                {
                    MessageBox.Show("Ce nom d'utilisateur existe déjà. Veuillez en choisir un autre.", "Nom non unique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }

                var nouvelleLigne = bDB56Projet1BKGDataSet.Utilisateur.NewUtilisateurRow();
                nouvelleLigne.NoUtilisateur = Convert.ToDecimal(txtNoUtilisateur.Text);
                nouvelleLigne.Nom = nomSaisi;
                nouvelleLigne.MotDePasse = mdpSaisi;
                nouvelleLigne.NoType = Convert.ToDecimal(cboTypeUtilisateur.SelectedValue);

                bDB56Projet1BKGDataSet.Utilisateur.AddUtilisateurRow(nouvelleLigne);
                utilisateurBindingSource.MoveLast();
            }
            else if (enModeModification)
            {
                if (utilisateurBindingSource.Current is DataRowView currentRow)
                {
                    currentRow["Nom"] = nomSaisi;
                    currentRow["MotDePasse"] = mdpSaisi;
                    currentRow["NoType"] = cboTypeUtilisateur.SelectedValue;
                    currentRow.EndEdit();
                }
            }

            if (SauvegarderDonnees())
            {
                enModeAjout = false;
                enModeModification = false;
                GererEtatControles(false);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.CancelEdit();
            bDB56Projet1BKGDataSet.Utilisateur.RejectChanges();

            enModeAjout = false;
            enModeModification = false;

            utilisateurBindingSource_CurrentChanged(null, null);
            GererEtatControles(false);
        }

        private bool SauvegarderDonnees()
        {
            try
            {
                this.Validate();
                this.utilisateurBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

                MessageBox.Show("Données sauvegardées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Conflit d'accès détecté : cet enregistrement a été modifié par un autre utilisateur.",
                    "Conflit", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.utilisateurTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Utilisateur);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionUtilisateurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enModeAjout || enModeModification)
            {
                if (MessageBox.Show("Une opération est en cours. Voulez-vous annuler et fermer ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                bDB56Projet1BKGDataSet.Utilisateur.RejectChanges();
            }
        }

        private void btnTypePrecedent_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.MovePrevious();
        }

        private void btnTypeSuivant_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.MoveNext();
        }
    }
}