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
    public partial class GestionTypeChambre : Form
    {
        public GestionTypeChambre()
        {
            InitializeComponent();
        }

        private void GestionTypeChambre_Load(object sender, EventArgs e)
        {
            this.typeChambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeChambre);
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
