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
    public partial class GestionChambre : Form
    {
        public GestionChambre()
        {
            InitializeComponent();
        }

        private void GestionChambre_Load(object sender, EventArgs e)
        {
            this.typeChambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeChambre);
            this.chambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Chambre);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

        }
    }
}
