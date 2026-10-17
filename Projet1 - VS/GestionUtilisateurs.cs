using Projet1___VS.BDB56Projet1BKGDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projet1___VS.BDB56Projet1BKGDataSet;

namespace Projet1___VS
{
    public partial class GestionUtilisateurs : Form
    {

        private BDB56Projet1BKGDataSet dataset;
        private UtilisateurTableAdapter utilisateurAdapter;
        private TypeUtilisateurTableAdapter typeAdapter;
        private int idUtilisateurConnecte;

        public GestionUtilisateurs()
        {
            InitializeComponent();
            idUtilisateurConnecte = 1001;

            dataset = new BDB56Projet1BKGDataSet();
            utilisateurAdapter = new UtilisateurTableAdapter();
            typeAdapter = new TypeUtilisateurTableAdapter();
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

        }

        private void GestionUtilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.TypeUtilisateur' table. You can move, or remove it, as needed.
            this.typeUtilisateurTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeUtilisateur);
            typeAdapter.Fill(dataset.TypeUtilisateur);
            utilisateurAdapter.Fill(dataset.Utilisateur);

            cboTypeUtilisateur.DataSource = dataset.TypeUtilisateur;
            cboTypeUtilisateur.DisplayMember = "identification";
            cboTypeUtilisateur.ValueMember = "NoType";

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtMotDePasse.Text) ||
                cboTypeUtilisateur.SelectedValue == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires.");
                return;
            }

            var nomExiste = dataset.Utilisateur.Any(u => u.Nom.Equals(txtNom.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (nomExiste)
            {
                MessageBox.Show("Ce nom d'utilisateur existe déjà.");
                return;
            }

            decimal nouvelId = 1; // Valeur par défaut
            if (dataset.Utilisateur.Count > 0)
            {
                nouvelId = dataset.Utilisateur.Max(u => u.NoUtilisateur) + 1;
            }

            dataset.Utilisateur.AddUtilisateurRow(
                nouvelId,
                txtNom.Text.Trim(),
                txtMotDePasse.Text,
                dataset.TypeUtilisateur.FindByNoType((decimal)cboTypeUtilisateur.SelectedValue)
            );

            SauvegarderDonnees();
        }

        private void dgvUtilisateurs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUtilisateurs.CurrentRow == null) return;

            decimal idSelectionne = Convert.ToDecimal(dgvUtilisateurs.CurrentRow.Cells["NoUtilisateur"].Value);

            txtNom.Enabled = false;

            if (idSelectionne == idUtilisateurConnecte)
            {
                cboTypeUtilisateur.Enabled = false;
            }
            else
            {
                cboTypeUtilisateur.Enabled = true; 
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            decimal idSelectionne = Convert.ToDecimal(dgvUtilisateurs.CurrentRow.Cells["NoUtilisateur"].Value);
            UtilisateurRow rowToUpdate = dataset.Utilisateur.FindByNoUtilisateur(idSelectionne);

            if (rowToUpdate != null)
            {
                rowToUpdate.MotDePasse = txtMotDePasse.Text;

                if (idSelectionne != idUtilisateurConnecte)
                {
                    rowToUpdate.NoType = (decimal)cboTypeUtilisateur.SelectedValue;
                }

                SauvegarderDonnees();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            decimal idSelectionne = Convert.ToDecimal(dgvUtilisateurs.CurrentRow.Cells["NoUtilisateur"].Value);

            if (idSelectionne == idUtilisateurConnecte)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer votre propre compte.");
                return;
            }

            if (idSelectionne == 1)
            {
                MessageBox.Show("Il est impossible de supprimer l'administrateur principal (No 1).");
                return;
            }

            DialogResult confirmation = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                UtilisateurRow rowToDelete = dataset.Utilisateur.FindByNoUtilisateur(idSelectionne);
                if (rowToDelete != null)
                {
                    rowToDelete.Delete();
                    SauvegarderDonnees();
                }
            }
        }

        private void SauvegarderDonnees()
        {
            try
            {
                utilisateurAdapter.Update(dataset.Utilisateur);
                MessageBox.Show("Opération réussie. Données sauvegardées.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'enregistrement : " + ex.Message);
            }
        }

        private void dgvUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
