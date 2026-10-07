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
    public partial class GestionChambreEtType : Form
    {
        public GestionChambreEtType()
        {
            InitializeComponent();
        }

        private void chambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

        }

        private void GestionChambreEtType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.TypeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeChambre);
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.Chambre' table. You can move, or remove it, as needed.
            this.chambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Chambre);

        }

        private void btnGestionChambres_Click(object sender, EventArgs e)
        {

        }

        private void btnTypesChambres_Click(object sender, EventArgs e)
        {

        }

        private void btnChambrePrecedent_Click(object sender, EventArgs e)
        {

        }

        private void btnChambreSuivant_Click(object sender, EventArgs e)
        {

        }

        private void btnTypePrecedent_Click(object sender, EventArgs e)
        {

        }

        private void btnTypeSuivant_Click(object sender, EventArgs e)
        {

        }
    }
}
