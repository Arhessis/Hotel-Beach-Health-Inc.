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
    public partial class frmVisualisation : Form
    {
        private bool chargement = false;

        public frmVisualisation()
        {
            InitializeComponent();
        }

        private void Visualisation_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now.Date;
        }

        private void Visualisation_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                Charger();
        }

        private void Charger()
        {
            try
            {
                this.clientTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Client);
                this.inviteTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Invite);
                this.assistantTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Assistant);
                this.soinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Soin);
                this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);
                this.chambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Chambre);
                this.reservationChambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.ReservationChambre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chargement = true;
            ChargerListePersonnes();
            ChargerListeChambres();
            ChargerListeAssistants();
            chargement = false;

            AfficherSoinsPersonne();
            AfficherReservations();
            AfficherSoinsJour();
        }

        private string NomClient(BDB56Projet1BKGDataSet.ClientRow unClient)
        {
            return (unClient["Prenom"].ToString() + " " + unClient["Nom"].ToString()).Trim();
        }

        private string NomAssistant(BDB56Projet1BKGDataSet.AssistantRow unAssistant)
        {
            return (unAssistant["Prenom"].ToString() + " " + unAssistant["Nom"].ToString()).Trim();
        }

        private string NomPersonne(decimal noPersonne)
        {
            if (noPersonne % 10 == 0)
            {
                BDB56Projet1BKGDataSet.ClientRow unClient = bDB56Projet1BKGDataSet.Client.FindByNoClient(noPersonne);
                return unClient == null ? noPersonne.ToString() : NomClient(unClient) + " (client " + noPersonne + ")";
            }

            BDB56Projet1BKGDataSet.InviteRow unInvite = bDB56Projet1BKGDataSet.Invite.FindByNoInvite(noPersonne);
            return unInvite == null ? noPersonne.ToString() : unInvite["NomPrenom"].ToString() + " (invité " + noPersonne + ")";
        }

        private void ChargerListePersonnes()
        {
            DataTable personnes = new DataTable();
            personnes.Columns.Add("NoPersonne", typeof(decimal));
            personnes.Columns.Add("Nom complet", typeof(string));

            foreach (BDB56Projet1BKGDataSet.ClientRow unClient in bDB56Projet1BKGDataSet.Client.Rows)
                personnes.Rows.Add(unClient.NoClient, unClient.NoClient + " - " + NomClient(unClient) + " (client)");

            foreach (BDB56Projet1BKGDataSet.InviteRow unInvite in bDB56Projet1BKGDataSet.Invite.Rows)
                personnes.Rows.Add(unInvite.NoInvite, unInvite.NoInvite + " - " + unInvite["NomPrenom"] +
                    " (invité du client " + unInvite.NoClient + ")");

            personnes.DefaultView.Sort = "NoPersonne";
            cboPersonnes.DisplayMember = "Nom complet";
            cboPersonnes.ValueMember = "NoPersonne";
            cboPersonnes.DataSource = personnes;
        }

        private void ChargerListeChambres()
        {
            DataTable chambres = new DataTable();
            chambres.Columns.Add("NoChambre", typeof(decimal));
            chambres.Columns.Add("NoEtEmplacement", typeof(string));

            foreach (BDB56Projet1BKGDataSet.ChambreRow uneChambre in bDB56Projet1BKGDataSet.Chambre.Rows)
                chambres.Rows.Add(uneChambre.NoChambre, uneChambre.NoChambre + " - " + uneChambre["Emplacement"]);

            chambres.DefaultView.Sort = "NoChambre";
            cboChambres.DisplayMember = "NoEtEmplacement";
            cboChambres.ValueMember = "NoChambre";
            cboChambres.DataSource = chambres;
        }

        private void ChargerListeAssistants()
        {
            DataTable assistants = new DataTable();
            assistants.Columns.Add("NoAssistant", typeof(decimal));
            assistants.Columns.Add("Nom complet", typeof(string));

            foreach (BDB56Projet1BKGDataSet.AssistantRow unAssistant in bDB56Projet1BKGDataSet.Assistant.Rows)
                assistants.Rows.Add(unAssistant.NoAssistant, unAssistant.NoAssistant + " - " + NomAssistant(unAssistant));

            assistants.DefaultView.Sort = "NoAssistant";
            cboAssistants.DisplayMember = "Nom complet";
            cboAssistants.ValueMember = "NoAssistant";
            cboAssistants.DataSource = assistants;
        }

        private void AfficherSoinsPersonne()
        {
            if (chargement || cboPersonnes.SelectedValue == null)
                return;

            decimal noPersonne = Convert.ToDecimal(cboPersonnes.SelectedValue.ToString());

            DataTable soins = new DataTable();
            soins.Columns.Add("Description", typeof(string));
            soins.Columns.Add("DateHeure", typeof(DateTime));
            soins.Columns.Add("Prix", typeof(decimal));
            soins.Columns.Add("Assistant", typeof(string));

            decimal total = 0;
            foreach (BDB56Projet1BKGDataSet.PlanifSoinRow unePlanif in bDB56Projet1BKGDataSet.PlanifSoin.Rows)
            {
                if (unePlanif.NoPersonne == noPersonne)
                {
                    BDB56Projet1BKGDataSet.SoinRow unSoin = bDB56Projet1BKGDataSet.Soin.FindByNoSoin(unePlanif.NoSoin);
                    BDB56Projet1BKGDataSet.AssistantRow unAssistant = bDB56Projet1BKGDataSet.Assistant.FindByNoAssistant(unePlanif.NoAssistant);

                    decimal prix = (unSoin == null || unSoin.IsPrixNull()) ? 0 : unSoin.Prix;
                    total += prix;

                    soins.Rows.Add(unSoin == null ? string.Empty : unSoin["Description"].ToString(),
                                   unePlanif.DateHeure,
                                   prix,
                                   unAssistant == null ? string.Empty : NomAssistant(unAssistant));
                }
            }

            soins.DefaultView.Sort = "DateHeure";
            dgSoinsPersonne.DataSource = soins;
            txtTotal.Text = total.ToString("C");
        }

        private void AfficherReservations()
        {
            if (chargement || cboChambres.SelectedValue == null)
                return;

            decimal noChambre = Convert.ToDecimal(cboChambres.SelectedValue.ToString());

            DataTable reservations = new DataTable();
            reservations.Columns.Add("NomClient", typeof(string));
            reservations.Columns.Add("DateArrivee", typeof(DateTime));
            reservations.Columns.Add("DateDepart", typeof(DateTime));
            reservations.Columns.Add("NbPersonnes", typeof(decimal));

            foreach (BDB56Projet1BKGDataSet.ReservationChambreRow uneReservation in bDB56Projet1BKGDataSet.ReservationChambre.Rows)
            {
                if (uneReservation.NoChambre == noChambre)
                {
                    BDB56Projet1BKGDataSet.ClientRow unClient = bDB56Projet1BKGDataSet.Client.FindByNoClient(uneReservation.NoClient);

                    reservations.Rows.Add(unClient == null ? uneReservation.NoClient.ToString() : NomClient(unClient),
                                          uneReservation.DateArrivee,
                                          uneReservation.IsDateDepartNull() ? (object)DBNull.Value : uneReservation.DateDepart,
                                          uneReservation.IsNbPersonnesNull() ? (object)DBNull.Value : uneReservation.NbPersonnes);
                }
            }

            reservations.DefaultView.Sort = "DateArrivee";
            dgReservations.DataSource = reservations;
        }

        private void AfficherSoinsJour()
        {
            if (chargement || cboAssistants.SelectedValue == null)
                return;

            decimal noAssistant = Convert.ToDecimal(cboAssistants.SelectedValue.ToString());
            DateTime date = dtpDate.Value.Date;

            DataTable soinsJour = new DataTable();
            soinsJour.Columns.Add("NoSoin", typeof(decimal));
            soinsJour.Columns.Add("Description", typeof(string));

            foreach (BDB56Projet1BKGDataSet.PlanifSoinRow unePlanif in bDB56Projet1BKGDataSet.PlanifSoin.Rows)
            {
                if (unePlanif.NoAssistant == noAssistant && unePlanif.DateHeure.Date == date
                    && soinsJour.Select("NoSoin = " + unePlanif.NoSoin.ToString(System.Globalization.CultureInfo.InvariantCulture)).Length == 0)
                {
                    BDB56Projet1BKGDataSet.SoinRow unSoin = bDB56Projet1BKGDataSet.Soin.FindByNoSoin(unePlanif.NoSoin);
                    soinsJour.Rows.Add(unePlanif.NoSoin, unSoin == null ? string.Empty : unSoin["Description"].ToString());
                }
            }

            soinsJour.DefaultView.Sort = "NoSoin";
            dgSoinsJour.DataSource = soinsJour;
            AfficherPersonnes();
        }

        private void AfficherPersonnes()
        {
            DataTable personnes = new DataTable();
            personnes.Columns.Add("Description", typeof(string));
            personnes.Columns.Add("DateHeure", typeof(DateTime));
            personnes.Columns.Add("Personne", typeof(string));

            if (dgSoinsJour.CurrentRow != null && dgSoinsJour.CurrentRow.DataBoundItem is DataRowView soinChoisi
                && cboAssistants.SelectedValue != null)
            {
                decimal noAssistant = Convert.ToDecimal(cboAssistants.SelectedValue.ToString());
                decimal noSoin = Convert.ToDecimal(soinChoisi["NoSoin"]);
                string description = soinChoisi["Description"].ToString();
                DateTime date = dtpDate.Value.Date;

                foreach (BDB56Projet1BKGDataSet.PlanifSoinRow unePlanif in bDB56Projet1BKGDataSet.PlanifSoin.Rows)
                {
                    if (unePlanif.NoAssistant == noAssistant && unePlanif.NoSoin == noSoin && unePlanif.DateHeure.Date == date)
                        personnes.Rows.Add(description, unePlanif.DateHeure, NomPersonne(unePlanif.NoPersonne));
                }
            }

            personnes.DefaultView.Sort = "DateHeure";
            dgPersonnes.DataSource = personnes;
        }

        private void cboPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherSoinsPersonne();
        }

        private void cboChambres_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherReservations();
        }

        private void cboAssistants_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherSoinsJour();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            AfficherSoinsJour();
        }

        private void dgSoinsJour_SelectionChanged(object sender, EventArgs e)
        {
            AfficherPersonnes();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
