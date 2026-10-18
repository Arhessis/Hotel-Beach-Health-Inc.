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
    public partial class frmMenuPrep : Form
    {
        public string NoUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }

        public frmMenuPrep()
        {
            InitializeComponent();
        }

        private void MenuPrep_Load(object sender, EventArgs e)
        {
            lblBienvenue.Text = "Bienvenue, " + NomUtilisateur;
        }

        private void btnClientsInvites_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmClientEtInvite frm = new frmClientEtInvite())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnPlanification_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (PlannificationSoin frm = new PlannificationSoin())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ReservationChambre frm = new ReservationChambre())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }
    }
}
