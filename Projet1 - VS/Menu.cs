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
    public partial class Menu : Form
    {

        GestionAssistantEtSoin gestionAssistantEtSoin = new GestionAssistantEtSoin();
        GestionChambreEtType gestionChambreEtType = new GestionChambreEtType();
        GestionClientEtInvite gestionClientEtInvite = new GestionClientEtInvite();
        GestionSoin gestionSoin = new GestionSoin();
        GestionUtilisateurs gestionUtilisateurs = new GestionUtilisateurs();
        PlannificationSoin plannificationSoin = new PlannificationSoin();

        public Menu()
        {
            InitializeComponent();
        }

        private void gestionAssistantEtSoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionAssistantEtSoin.ShowDialog();
            this.Show();
        }

        private void gestionChambreEtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionChambreEtType.ShowDialog();
            this.Show();
        }

        private void gestionClientEtInvitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionClientEtInvite.ShowDialog();
            this.Show();
        }

        private void gestionSoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionSoin.ShowDialog();
            this.Show();
        }

        private void gestionUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionUtilisateurs.ShowDialog();
            this.Show();
        }

        private void planificationDesSoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            plannificationSoin.ShowDialog();
            this.Show();
        }
    }
}
