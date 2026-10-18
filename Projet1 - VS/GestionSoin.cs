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
        private bool enModeAjout = false;

        public GestionSoin()
        {
            InitializeComponent();
        }

        private void GestionSoin_Load(object sender, EventArgs e)
        {
            this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);
            try
            {
                this.typeSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeSoin);

                this.soinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Soin);

                this.assistantSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.AssistantSoin);
                this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);

                GererEtatControles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GererEtatControles(bool enEdition)
        {
            btnAjouter.Enabled = !enEdition;
            btnModifier.Enabled = !enEdition && soinBindingSource.Count > 0;
            btnSupprimer.Enabled = !enEdition && soinBindingSource.Count > 0;

            btnEnregistrer.Enabled = enEdition;
            btnAnnuler.Enabled = enEdition;

            noSoinTextBox.ReadOnly = true;

            dureeTextBox.ReadOnly = true;

            descriptionTextBox.ReadOnly = !enEdition;
            prixTextBox.ReadOnly = !enEdition;
            noTypeSoinComboBox.Enabled = enEdition;
        }
    }
}
