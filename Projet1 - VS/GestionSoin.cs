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
    public partial class GestionSoin : Form
    {
        public GestionSoin()
        {
            InitializeComponent();
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

        }

        private void GestionSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.AssistantSoin' table. You can move, or remove it, as needed.
            this.assistantSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.AssistantSoin);
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.TypeSoin' table. You can move, or remove it, as needed.
            this.typeSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeSoin);
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.Soin' table. You can move, or remove it, as needed.
            this.soinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Soin);

        }
    }
}
