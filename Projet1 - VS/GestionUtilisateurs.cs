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
                this.typeUtilisateurTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeUtilisateur);
                this.utilisateurTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Utilisateur);

                GererEtatControles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (utilisateurBindingSource.Current != null)
                {
                    DataRowView currentRow = (DataRowView)utilisateurBindingSource.Current;
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

            DataRowView nouvelleLigne = (DataRowView)utilisateurBindingSource.AddNew();
            nouvelleLigne["NoUtilisateur"] = prochainNo;

            if (bDB56Projet1BKGDataSet.TypeUtilisateur.Count > 0)
            {
                nouvelleLigne["NoType"] = bDB56Projet1BKGDataSet.TypeUtilisateur[0].NoType;
            }

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

            DialogResult confirmation = MessageBox.Show(
                $"Voulez-vous vraiment supprimer l'utilisateur '{nomCible}' (No {noCible}) ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                utilisateurBindingSource.RemoveCurrent();
                SauvegarderDonnees();
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nomSaisi = txtNom.Text.Trim();
            string mdpSaisi = txtMotDePasse.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomSaisi) ||
                string.IsNullOrWhiteSpace(mdpSaisi) ||
                cboTypeUtilisateur.SelectedValue == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enModeAjout)
            {
                bool nomExisteDeja = bDB56Projet1BKGDataSet.Utilisateur.Any(u =>
                    u.RowState != DataRowState.Deleted &&
                    !u.IsNomNull() &&
                    u.Nom.Trim().Equals(nomSaisi, StringComparison.OrdinalIgnoreCase));

                if (nomExisteDeja)
                {
                    MessageBox.Show("Ce nom d'utilisateur existe déjà. Veuillez en choisir un autre.",
                        "Nom non unique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }
            }

            txtNom.Text = nomSaisi;
            txtMotDePasse.Text = mdpSaisi;

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
            GererEtatControles(false);
        }

        private bool SauvegarderDonnees()
        {
            try
            {
                this.Validate();
                this.utilisateurBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

                MessageBox.Show("Données sauvegardées avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Conflit d'accès détecté : cet enregistrement a été modifié par un autre utilisateur. Les données vont être rechargées.",
                    "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.utilisateurTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Utilisateur);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult rep = MessageBox.Show(
                    "Une opération est en cours. Voulez-vous annuler les modifications et fermer ?",
                    "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rep == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                utilisateurBindingSource.CancelEdit();
                bDB56Projet1BKGDataSet.Utilisateur.RejectChanges();
            }
        }
    }
}