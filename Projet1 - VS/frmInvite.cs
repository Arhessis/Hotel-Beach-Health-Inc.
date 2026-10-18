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
    public partial class frmInvite : Form
    {
        public frmInvite()
        {
            InitializeComponent();
        }

        public BDB56Projet1BKGDataSet.InviteRow unInvite;

        private void frmInvite_Load(object sender, EventArgs e)
        {
            if (unInvite.RowState == DataRowState.Detached)
            {
                this.Text = "Ajouter un invité";
                lblTitre.Text = "Ajouter un invité";
                lblSousTitre.Text = "Invité du client " + unInvite.NoClient + " (maximum 9 invités par client)";
            }
            else
            {
                this.Text = "Modifier un invité";
                lblTitre.Text = "Modifier un invité";
                lblSousTitre.Text = "Seul le nom est modifiable";
            }

            txtNoInvite.Text = unInvite.NoInvite.ToString();
            txtNomPrenom.Text = unInvite.IsNomPrenomNull() ? string.Empty : unInvite.NomPrenom;
            txtNoClient.Text = unInvite.NoClient.ToString();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (txtNomPrenom.Text.Trim() == string.Empty)
                errMessage.SetError(txtNomPrenom, "Le nom de l'invité ne peut pas être vide");
            else
            {
                errMessage.SetError(txtNomPrenom, string.Empty);
                unInvite.NomPrenom = txtNomPrenom.Text.Trim();
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
