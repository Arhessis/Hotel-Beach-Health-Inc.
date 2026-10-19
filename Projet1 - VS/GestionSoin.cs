using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet1___VS
{
    public partial class GestionSoin : Form
    {
        private bool enModeAjout = false;
        private bool enModeModification = false;

        public GestionSoin()
        {
            InitializeComponent();
        }

        private void GestionSoin_Load(object sender, EventArgs e)
        {
            try
            {
                soinDataGridView.AllowUserToAddRows = false;
                noSoinTextBox.DataBindings.Clear();
                descriptionTextBox.DataBindings.Clear();
                dureeTextBox.DataBindings.Clear();
                prixTextBox.DataBindings.Clear();
                noTypeSoinComboBox.DataBindings.Clear();

                noTypeSoinComboBox.DataSource = typeSoinBindingSource;
                noTypeSoinComboBox.DisplayMember = "Description";
                noTypeSoinComboBox.ValueMember = "NoTypeSoin";

                this.typeSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeSoin);
                this.soinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Soin);
                this.assistantSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.AssistantSoin);
                this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);

                this.soinBindingSource.CurrentChanged += soinBindingSource_CurrentChanged;
                soinBindingSource_CurrentChanged(null, null);

                GererEtatControles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void soinBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (enModeAjout) return;

            if (soinBindingSource.Current is DataRowView drv)
            {
                noSoinTextBox.Text = drv["NoSoin"].ToString();
                descriptionTextBox.Text = drv["Description"].ToString();
                dureeTextBox.Text = drv["Duree"].ToString();
                noTypeSoinComboBox.SelectedValue = drv["NoTypeSoin"];
                prixTextBox.Text = drv["Prix"].ToString();
            }
            else
            {
                noSoinTextBox.Clear();
                descriptionTextBox.Clear();
                dureeTextBox.Clear();
                noTypeSoinComboBox.SelectedIndex = -1;
                prixTextBox.Clear();
            }
        }

        private void GererEtatControles(bool enEdition)
        {
            soinDataGridView.Enabled = !enEdition;

            btnAjouter.Enabled = !enEdition;
            btnModifier.Enabled = !enEdition && soinBindingSource.Count > 0;
            btnSupprimer.Enabled = !enEdition && soinBindingSource.Count > 0;

            btnEnregistrer.Enabled = enEdition;
            btnAnnuler.Enabled = enEdition;

            noSoinTextBox.ReadOnly = true;
            dureeTextBox.ReadOnly = true;

            descriptionTextBox.ReadOnly = !enEdition;
            prixTextBox.ReadOnly = !enEdition;
            noTypeSoinComboBox.Enabled = enEdition;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            enModeAjout = true;
            enModeModification = false;

            decimal prochainNo = 1;
            if (bDB56Projet1BKGDataSet.Soin.Count > 0)
            {
                prochainNo = bDB56Projet1BKGDataSet.Soin.Max(s => s.NoSoin) + 1;
            }

            noSoinTextBox.Text = prochainNo.ToString();
            descriptionTextBox.Clear();
            dureeTextBox.Text = "60";
            prixTextBox.Clear();

            if (bDB56Projet1BKGDataSet.TypeSoin.Count > 0)
            {
                noTypeSoinComboBox.SelectedValue = bDB56Projet1BKGDataSet.TypeSoin.First().NoTypeSoin;
            }

            GererEtatControles(true);
            descriptionTextBox.Focus();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (soinBindingSource.Current == null) return;

            enModeAjout = false;
            enModeModification = true;

            GererEtatControles(true);
            descriptionTextBox.Focus();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text.Trim();
            string prixTexte = prixTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(prixTexte) || noTypeSoinComboBox.SelectedValue == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(prixTexte, out decimal prix) || prix <= 0 || prix >= 10000)
            {
                MessageBox.Show("Le prix doit être un nombre positif valide inférieur à 10 000.00 $ (format NUMERIC(6,2)).",
                    "Validation du prix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prixTextBox.Focus();
                return;
            }

            if (enModeAjout)
            {
                var nouvelleLigne = bDB56Projet1BKGDataSet.Soin.NewSoinRow();
                nouvelleLigne.NoSoin = Convert.ToDecimal(noSoinTextBox.Text);
                nouvelleLigne.Description = description;
                nouvelleLigne.Duree = 60;
                nouvelleLigne.NoTypeSoin = Convert.ToDecimal(noTypeSoinComboBox.SelectedValue);
                nouvelleLigne.Prix = Math.Round(prix, 2);

                bDB56Projet1BKGDataSet.Soin.AddSoinRow(nouvelleLigne);
                soinBindingSource.MoveLast();
            }
            else if (enModeModification)
            {
                if (soinBindingSource.Current is DataRowView currentRow)
                {
                    currentRow["Description"] = description;
                    currentRow["NoTypeSoin"] = noTypeSoinComboBox.SelectedValue;
                    currentRow["Prix"] = Math.Round(prix, 2);
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
            soinBindingSource.CancelEdit();
            bDB56Projet1BKGDataSet.Soin.RejectChanges();

            enModeAjout = false;
            enModeModification = false;

            soinBindingSource_CurrentChanged(null, null);
            GererEtatControles(false);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (soinBindingSource.Current == null) return;

            DataRowView currentRow = (DataRowView)soinBindingSource.Current;
            decimal noSoin = Convert.ToDecimal(currentRow["NoSoin"]);
            string description = currentRow["Description"].ToString();

            bool estOffertParAssistant = bDB56Projet1BKGDataSet.AssistantSoin.Any(a =>
                a.RowState != DataRowState.Deleted && a.NoSoin == noSoin);

            if (estOffertParAssistant)
            {
                MessageBox.Show($"Impossible de supprimer le soin '{description}' car il est actuellement offert par un ou plusieurs assistants.",
                    "Suppression refusée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool estPlanifie = bDB56Projet1BKGDataSet.PlanifSoin.Any(p =>
                p.RowState != DataRowState.Deleted && p.NoSoin == noSoin);

            if (estPlanifie)
            {
                MessageBox.Show($"Impossible de supprimer le soin '{description}' car des rendez-vous de soins sont déjà planifiés.",
                    "Suppression refusée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le soin '{description}' (No {noSoin}) ?",
                "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                soinBindingSource.RemoveCurrent();
                SauvegarderDonnees();
            }
        }

        private bool SauvegarderDonnees()
        {
            try
            {
                this.Validate();
                this.soinBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

                MessageBox.Show("Soin enregistré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Conflit d'accès détecté : ce soin a été modifié ou supprimé par un autre utilisateur.",
                    "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.soinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Soin);
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

        private void GestionSoin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enModeAjout || enModeModification)
            {
                DialogResult reponse = MessageBox.Show(
                    "Une opération est en cours. Voulez-vous annuler les modifications et fermer ?",
                    "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reponse == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                bDB56Projet1BKGDataSet.Soin.RejectChanges();
            }
        }

        private void btnTypePrecedent_Click(object sender, EventArgs e)
        {
            soinBindingSource.MovePrevious();
        }

        private void btnTypeSuivant_Click(object sender, EventArgs e)
        {
            soinBindingSource.MoveNext();
        }
    }
}