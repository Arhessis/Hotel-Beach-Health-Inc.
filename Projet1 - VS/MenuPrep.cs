using System;
using System.Windows.Forms;

namespace Projet1___VS
{
    public partial class MenuPrep : Form
    {
        public string NoUtilisateur { get; set; }

        public MenuPrep()
        {
            InitializeComponent();
        }

        private void gestionClientEtInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (GestionClientEtInvite frm = new GestionClientEtInvite())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void planificationsDesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (PlannificationSoin frm = new PlannificationSoin())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void reservationDeChambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ReservationChambre frm = new ReservationChambre())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SauvegarderXML();
            Application.Exit();
        }

        private void SauvegarderXML()
        {
            try
            {
                // PDF Requirement: Export all 10 tables to XML before quitting
                BDB56Projet1BKGDataSet ds = new BDB56Projet1BKGDataSet();
                new BDB56Projet1BKGDataSetTableAdapters.UtilisateurTableAdapter().Fill(ds.Utilisateur);
                new BDB56Projet1BKGDataSetTableAdapters.ClientTableAdapter().Fill(ds.Client);
                new BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter().Fill(ds.Invite);
                new BDB56Projet1BKGDataSetTableAdapters.AssistantTableAdapter().Fill(ds.Assistant);
                new BDB56Projet1BKGDataSetTableAdapters.AssistantSoinTableAdapter().Fill(ds.AssistantSoin);
                new BDB56Projet1BKGDataSetTableAdapters.SoinTableAdapter().Fill(ds.Soin);
                new BDB56Projet1BKGDataSetTableAdapters.PlanifSoinTableAdapter().Fill(ds.PlanifSoin);
                new BDB56Projet1BKGDataSetTableAdapters.ChambreTableAdapter().Fill(ds.Chambre);
                new BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter().Fill(ds.TypeChambre);
                new BDB56Projet1BKGDataSetTableAdapters.ReservationChambreTableAdapter().Fill(ds.ReservationChambre);

                ds.Utilisateur.WriteXml("utilisateur.xml");
                ds.Client.WriteXml("client.xml");
                ds.Invite.WriteXml("invite.xml");
                ds.Assistant.WriteXml("assistant.xml");
                ds.AssistantSoin.WriteXml("assistantSoin.xml");
                ds.Soin.WriteXml("soin.xml");
                ds.PlanifSoin.WriteXml("planificationSoin.xml");
                ds.Chambre.WriteXml("chambre.xml");
                ds.TypeChambre.WriteXml("TypeChambre.xml");
                ds.ReservationChambre.WriteXml("reservationChambre.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde XML : " + ex.Message);
            }
        }
    }
}