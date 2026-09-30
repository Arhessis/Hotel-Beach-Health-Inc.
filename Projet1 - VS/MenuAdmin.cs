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
    public partial class MenuAdmin : Form
    {

        GestionUtilisateurs gestionUtilisateurs = new GestionUtilisateurs();
        GestionClientEtInvite gestionClientEtInvite = new GestionClientEtInvite();
        GestionAssistantEtSoin gestionAssistantEtSoin = new GestionAssistantEtSoin();
        GestionSoin gestionSoin = new GestionSoin();
        PlannificationSoin plannificationSoin = new PlannificationSoin();
        GestionChambreEtType gestionChambreEtType = new GestionChambreEtType();
        ReservationChambre reservationChambre = new ReservationChambre();
        Visualisation visualiserRapport = new Visualisation();

        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void gestionUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionUtilisateurs.ShowDialog();
            this.Show();
        }

        private void gestionClientEtInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionClientEtInvite.ShowDialog();
            this.Show();
        }

        private void gestionAssistantEtSoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionAssistantEtSoin.ShowDialog();
            this.Show();
        }

        private void gestionSoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionSoin.ShowDialog();
            this.Show();
        }

        private void planificationsDesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            plannificationSoin.ShowDialog();
            this.Show();
        }

        private void gestionChambreEtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionChambreEtType.ShowDialog();
            this.Show();
        }

        private void reservationDeChambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservationChambre.ShowDialog();
            this.Show();
        }

        private void visualisationDesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            visualiserRapport.ShowDialog();
            this.Show();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
