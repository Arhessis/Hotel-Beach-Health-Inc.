using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1___VS
{

    public partial class GestionSoin : Form
    {
        private bool enModeAjout = false;

        public GestionSoin()
        {
            InitializeComponent();
        }

        private void GestionSoin_Load(object sender, EventArgs e)
        {
            this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);
            try
            {
                this.typeSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeSoin);

                this.soinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Soin);

                this.assistantSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.AssistantSoin);
                this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);

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

            soinBindingSource.AddNew();

            decimal prochainNo = 1;
            if (bDB56Projet1BKGDataSet.Soin.Count > 0)
            {
                prochainNo = bDB56Projet1BKGDataSet.Soin.Max(s => s.NoSoin) + 1;
            }
            noSoinTextBox.Text = prochainNo.ToString();

            dureeTextBox.Text = "60";

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

            GererEtatControles(true);
            descriptionTextBox.Focus();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text.Trim();
            string prixTexte = prixTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("La description du soin est obligatoire.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                descriptionTextBox.Focus();
                return;
            }

            if (noTypeSoinComboBox.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de soin.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                noTypeSoinComboBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(prixTexte))
            {
                MessageBox.Show("Le prix du soin est obligatoire.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prixTextBox.Focus();
                return;
            }

            if (!decimal.TryParse(prixTexte, out decimal prix) || prix <= 0 || prix >= 10000)
            {
                MessageBox.Show("Le prix doit être un nombre positif valide inférieur à 10 000.00 $ (format NUMERIC(6,2)).",
                    "Validation du prix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prixTextBox.Focus();
                return;
            }

            DataRowView currentRow = (DataRowView)soinBindingSource.Current;
            currentRow["Description"] = description;
            currentRow["Duree"] = 60; 
            currentRow["NoTypeSoin"] = noTypeSoinComboBox.SelectedValue;
            currentRow["Prix"] = Math.Round(prix, 2);

            if (SauvegarderDonnees())
            {
                enModeAjout = false;
                GererEtatControles(false);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            soinBindingSource.CancelEdit();
            bDB56Projet1BKGDataSet.Soin.RejectChanges();

            enModeAjout = false;
            GererEtatControles(false);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool SauvegarderDonnees()
        {
            try
            {
                this.Validate();
                this.soinBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

                MessageBox.Show("Soin enregistré avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Conflit d'accès détecté : ce soin a été modifié ou supprimé par un autre utilisateur. Les données vont être rechargées.",
                    "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.soinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Soin);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void GestionSoin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnEnregistrer.Enabled)
            {
                DialogResult reponse = MessageBox.Show(
                    "Une opération est en cours. Voulez-vous annuler les modifications et fermer ?",
                    "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reponse == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                soinBindingSource.CancelEdit();
                bDB56Projet1BKGDataSet.Soin.RejectChanges();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (soinBindingSource.Current == null) return;

            DataRowView currentRow = (DataRowView)soinBindingSource.Current;
            decimal noSoin = Convert.ToDecimal(currentRow["NoSoin"]);
            string description = currentRow["Description"].ToString();

            bool estOffertParAssistant = bDB56Projet1BKGDataSet.AssistantSoin.Any(a =>
                a.RowState != DataRowState.Deleted &&
                a.NoSoin == noSoin);

            if (estOffertParAssistant)
            {
                MessageBox.Show(
                    $"Impossible de supprimer le soin '{description}' car il est actuellement offert par un ou plusieurs assistants.",
                    "Suppression refusée",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool estPlanifie = bDB56Projet1BKGDataSet.PlanifSoin.Any(p =>
                p.RowState != DataRowState.Deleted &&
                p.NoSoin == noSoin);

            if (estPlanifie)
            {
                MessageBox.Show(
                    $"Impossible de supprimer le soin '{description}' car des rendez-vous de soins sont déjà planifiés.",
                    "Suppression refusée",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le soin '{description}' (No {noSoin}) ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                soinBindingSource.RemoveCurrent();

                SauvegarderDonnees();
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
