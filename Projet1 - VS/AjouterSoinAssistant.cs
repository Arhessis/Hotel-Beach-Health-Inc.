using System;
using System.Data;
using System.Windows.Forms;

namespace Projet1___VS
{
    public partial class AjouterSoinAssistant : Form
    {
        private readonly DataTable soins;
        public DataRowView SoinChoisi { get; private set; }

        public AjouterSoinAssistant(DataTable soinsDisponibles)
        {
            InitializeComponent();
            soins = soinsDisponibles;
        }

        private void AjouterSoinAssistant_Load(object sender, EventArgs e)
        {
            cbSoin.DataSource = soins;
            cbSoin.DisplayMember = "Description";
            cbSoin.ValueMember = "NoSoin";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbSoin.SelectedItem is DataRowView choix)
            {
                SoinChoisi = choix;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Aucun soin sélectionné.");
            }
        }
    }
}