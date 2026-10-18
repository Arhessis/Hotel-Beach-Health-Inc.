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
    public partial class frmChambre : Form
    {
        public frmChambre()
        {
            InitializeComponent();
        }

        public BDB56Projet1BKGDataSet.ChambreRow uneChambre;

        private void GestionChambre_Load(object sender, EventArgs e)
        {
            try
            {
                this.typeChambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeChambre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (uneChambre.RowState == DataRowState.Detached)
            {
                this.Text = "Ajouter une chambre";
                lblTitre.Text = "Ajouter une chambre";
                lblSousTitre.Text = "Tous les champs sont obligatoires";
            }
            else
            {
                this.Text = "Modifier une chambre";
                lblTitre.Text = "Modifier une chambre";
                lblSousTitre.Text = "Le numéro de la chambre n'est pas modifiable";
            }

            txtNoChambre.Text = uneChambre.NoChambre.ToString();
            txtEmplacement.Text = uneChambre.IsEmplacementNull() ? string.Empty : uneChambre.Emplacement;
            txtDecorations.Text = uneChambre.IsDecorationsNull() ? string.Empty : uneChambre.Decorations;
            cboTypeChambre.SelectedValue = uneChambre.NoTypeChambre;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool valide = true;

            if (txtEmplacement.Text.Trim() == string.Empty)
            {
                errMessage.SetError(txtEmplacement, "L'emplacement ne peut pas être vide");
                valide = false;
            }
            else
                errMessage.SetError(txtEmplacement, string.Empty);

            if (txtDecorations.Text.Trim() == string.Empty)
            {
                errMessage.SetError(txtDecorations, "Les décorations ne peuvent pas être vides");
                valide = false;
            }
            else
                errMessage.SetError(txtDecorations, string.Empty);

            if (cboTypeChambre.SelectedValue == null)
            {
                errMessage.SetError(cboTypeChambre, "Veuillez choisir un type de chambre");
                valide = false;
            }
            else
                errMessage.SetError(cboTypeChambre, string.Empty);

            if (valide)
            {
                uneChambre.Emplacement = txtEmplacement.Text.Trim();
                uneChambre.Decorations = txtDecorations.Text.Trim();
                uneChambre.NoTypeChambre = Convert.ToDecimal(cboTypeChambre.SelectedValue.ToString());
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
