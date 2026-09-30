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
    public partial class MenuPrep : Form
    {

        GestionClientEtInvite gestionClientEtInvite = new GestionClientEtInvite();
        PlannificationSoin plannificationSoin = new PlannificationSoin();
        ReservationChambre reservationChambre = new ReservationChambre();


        public MenuPrep()
        {
            InitializeComponent();
        }

        private void geToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionClientEtInvite.ShowDialog();
            this.Show();
        }

        private void planificationDesSoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            plannificationSoin.ShowDialog();
            this.Show();
        }

        private void réservationDeChambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservationChambre.ShowDialog();
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
