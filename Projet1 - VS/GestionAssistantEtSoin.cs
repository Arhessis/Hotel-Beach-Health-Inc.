using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1___VS
{

    public partial class GestionAssistantEtSoin : Form
    {

        private string chaineConnexion = "Data Source=424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet1BKG;Persist Security Info=True;User ID=B56Projet1BKG;Password=Password-BKG;TrustServerCertificate=True";

        public GestionAssistantEtSoin()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

        }


        private void GestionAssistantEtSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.Assistant' table. You can move, or remove it, as needed.
            this.assistantTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Assistant);

        }

        private void assistantDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAssistant.CurrentRow == null ||
                dgAssistant.CurrentRow.Cells["NoAssistant"].Value == null)
                return;

            int noAssistant = Convert.ToInt32(
                dgAssistant.CurrentRow.Cells["NoAssistant"].Value
            );

            ChargerSoins(noAssistant);
        }

        private void ChargerSoins(int noAssistant)
        {
            using (SqlConnection con = new SqlConnection(chaineConnexion))
            using (SqlCommand cmd = new SqlCommand(@"
        SELECT S.*
        FROM Soin S
        INNER JOIN AssistantSoin ASO ON S.NoSoin = ASO.NoSoin
        WHERE ASO.NoAssistant = @NoAssistant", con))
            {
                cmd.Parameters.AddWithValue("@NoAssistant", noAssistant);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dgSoin.DataSource = dt;
            }
        }
    }
}
