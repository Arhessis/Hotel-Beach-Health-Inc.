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
    public partial class frmMenuAdmin : Form
    {
        public string NoUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }

        frmClientEtInvite gestionClientEtInvite = new frmClientEtInvite();
        GestionAssistantEtSoin gestionAssistantEtSoin = new GestionAssistantEtSoin();
        GestionSoin gestionSoin = new GestionSoin();
        PlannificationSoin plannificationSoin = new PlannificationSoin();
        frmChambreEtType gestionChambreEtType = new frmChambreEtType();
        ReservationChambre reservationChambre = new ReservationChambre();
        frmVisualisation visualiserRapport = new frmVisualisation();

        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            lblBienvenue.Text = "Bienvenue, " + NomUtilisateur;
        }

        private void btnUtilisateurs_Click(object sender, EventArgs e)
        {
            this.Hide();
            decimal loggedInId = decimal.TryParse(this.NoUtilisateur, out decimal id) ? id : 1;
            GestionUtilisateurs frm = new GestionUtilisateurs(loggedInId);
            frm.ShowDialog();
            this.Show();
        }

        private void btnClientsInvites_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionClientEtInvite.ShowDialog();
            this.Show();
        }

        private void btnAssistants_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionAssistantEtSoin.ShowDialog();
            this.Show();
        }

        private void btnSoins_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionSoin.ShowDialog();
            this.Show();
        }

        private void btnPlanification_Click(object sender, EventArgs e)
        {
            this.Hide();
            plannificationSoin.ShowDialog();
            this.Show();
        }

        private void btnChambres_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionChambreEtType.ShowDialog();
            this.Show();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservationChambre.ShowDialog();
            this.Show();
        }

        private void btnRapports_Click(object sender, EventArgs e)
        {
            this.Hide();
            visualiserRapport.ShowDialog();
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
