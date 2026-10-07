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
    public partial class PlannificationSoin : Form
    {
        public PlannificationSoin()
        {
            InitializeComponent();
        }

        private void planifSoinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planifSoinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

        }

        private void PlannificationSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.PlanifSoin' table. You can move, or remove it, as needed.
            this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);

        }
    }
}
