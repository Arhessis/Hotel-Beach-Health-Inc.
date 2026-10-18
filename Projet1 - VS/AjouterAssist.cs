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
    public partial class AjouterAssist : Form
    {
        public BDB56Projet1BKGDataSet.AssistantRow unAssistant;
        public AjouterAssist()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AjouterAssist_Load(object sender, EventArgs e)
        {
            txtNoAssistant.Text = unAssistant.NoAssistant.ToString();
            txtNoAssistant.ReadOnly = true;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string remarques;

            if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Veuillez saisir le prénom.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Veuillez saisir le nom.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialites.Text))
            {
                MessageBox.Show("Veuillez saisir les specialites.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRemarques.Text))
            {
                remarques = "";
            }
            else
            {
                remarques = txtRemarques.Text.Trim();
            }

            //affecté valeur a l'assistant
            unAssistant.Prenom = txtPrenom.Text.Trim();
            unAssistant.Nom = txtNom.Text.Trim();
            unAssistant.Specialites = txtSpecialites.Text.Trim();
            unAssistant.Remarques = remarques;
            //unAssistant.NoAssistant = Convert.ToDecimal(txtNoAssistant.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
