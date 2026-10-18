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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        public BDB56Projet1BKGDataSet.ClientRow unClient;

        private void frmClient_Load(object sender, EventArgs e)
        {
            if (unClient.RowState == DataRowState.Detached)
            {
                this.Text = "Ajouter un client";
                lblTitre.Text = "Ajouter un client";
                lblSousTitre.Text = "Tous les champs sont obligatoires";
            }
            else
            {
                this.Text = "Modifier un client";
                lblTitre.Text = "Modifier un client";
                lblSousTitre.Text = "Le numéro et la date d'inscription ne sont pas modifiables";
            }

            txtNoClient.Text = unClient.NoClient.ToString();
            txtNom.Text = unClient.IsNomNull() ? string.Empty : unClient.Nom;
            txtPrenom.Text = unClient.IsPrenomNull() ? string.Empty : unClient.Prenom;
            txtVille.Text = unClient.IsVilleNull() ? string.Empty : unClient.Ville;
            txtPays.Text = unClient.IsPaysNull() ? string.Empty : unClient.Pays;
            txtAdresse.Text = unClient.IsAdresseNull() ? string.Empty : unClient.Adresse;
            txtCodePostal.Text = unClient.IsCodePostalNull() ? string.Empty : unClient.CodePostal;
            dtpDateInscription.Value = unClient.IsDateInscriptionNull() ? DateTime.Now.Date : unClient.DateInscription;
        }

        private bool ChampObligatoire(TextBox txt, string messageErreur)
        {
            if (txt.Text.Trim() == string.Empty)
            {
                errMessage.SetError(txt, messageErreur);
                return false;
            }
            errMessage.SetError(txt, string.Empty);
            return true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool valide = ChampObligatoire(txtNom, "Le nom ne peut pas être vide")
                        & ChampObligatoire(txtPrenom, "Le prénom ne peut pas être vide")
                        & ChampObligatoire(txtVille, "La ville ne peut pas être vide")
                        & ChampObligatoire(txtPays, "Le pays ne peut pas être vide")
                        & ChampObligatoire(txtAdresse, "L'adresse ne peut pas être vide")
                        & ChampObligatoire(txtCodePostal, "Le code postal ne peut pas être vide");

            if (valide)
            {
                unClient.Nom = txtNom.Text.Trim();
                unClient.Prenom = txtPrenom.Text.Trim();
                unClient.Ville = txtVille.Text.Trim();
                unClient.Pays = txtPays.Text.Trim();
                unClient.Adresse = txtAdresse.Text.Trim();
                unClient.CodePostal = txtCodePostal.Text.Trim();
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
