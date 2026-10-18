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
    public partial class frmClientEtInvite : Form
    {
        private bool conflit = false;

        public frmClientEtInvite()
        {
            InitializeComponent();
        }

        private void GestionClientEtInvite_Load(object sender, EventArgs e)
        {
            clientTableAdapter.Adapter.RowUpdated -= tableAdapter_RowUpdated;
            clientTableAdapter.Adapter.RowUpdated += tableAdapter_RowUpdated;
            inviteTableAdapter.Adapter.RowUpdated -= tableAdapter_RowUpdated;
            inviteTableAdapter.Adapter.RowUpdated += tableAdapter_RowUpdated;
        }

        private void GestionClientEtInvite_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                Recharger();
        }

        private void Recharger()
        {
            decimal noClient = NoCourant(clientBindingSource, "NoClient");
            decimal noInvite = NoCourant(inviteBindingSource, "NoInvite");

            try
            {
                this.inviteTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Invite);
                this.clientTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Client);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Positionner(clientBindingSource, "NoClient", noClient);
            Positionner(inviteBindingSource, "NoInvite", noInvite);
        }

        private decimal NoCourant(BindingSource source, string colonne)
        {
            if (source.Current == null)
                return -1;
            return (decimal)((DataRowView)source.Current)[colonne];
        }

        private void Positionner(BindingSource source, string colonne, decimal no)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if ((decimal)((DataRowView)source[i])[colonne] == no)
                {
                    source.Position = i;
                    return;
                }
            }
        }

        private bool EnregistrerClients()
        {
            conflit = false;
            try
            {
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.clientTableAdapter.Update(this.bDB56Projet1BKGDataSet.Client);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                conflit = true;
            }

            if (conflit)
            {
                Recharger();
                return false;
            }
            return true;
        }

        private bool EnregistrerInvites()
        {
            conflit = false;
            try
            {
                this.Validate();
                this.inviteBindingSource.EndEdit();
                this.inviteTableAdapter.Update(this.bDB56Projet1BKGDataSet.Invite);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                conflit = true;
            }

            if (conflit)
            {
                Recharger();
                return false;
            }
            return true;
        }

        private void btnClientPrecedent_Click(object sender, EventArgs e)
        {
            clientBindingSource.MovePrevious();
        }

        private void btnClientSuivant_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveNext();
        }

        private void btnInvitePrecedent_Click(object sender, EventArgs e)
        {
            inviteBindingSource.MovePrevious();
        }

        private void btnInviteSuivant_Click(object sender, EventArgs e)
        {
            inviteBindingSource.MoveNext();
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            Recharger();

            BDB56Projet1BKGDataSet.ClientRow unClient = bDB56Projet1BKGDataSet.Client.NewClientRow();

            decimal noClientMax = 0;
            foreach (BDB56Projet1BKGDataSet.ClientRow uneLigne in bDB56Projet1BKGDataSet.Client.Rows)
                if (uneLigne.RowState != DataRowState.Deleted && uneLigne.NoClient > noClientMax)
                    noClientMax = uneLigne.NoClient;

            unClient.NoClient = Math.Floor(noClientMax / 10) * 10 + 10;
            unClient.DateInscription = DateTime.Now.Date;

            frmClient frmAjout = new frmClient();
            frmAjout.unClient = unClient;
            frmAjout.ShowDialog();

            if (!unClient.IsNomNull())
            {
                bDB56Projet1BKGDataSet.Client.AddClientRow(unClient);
                decimal noClient = unClient.NoClient;

                if (EnregistrerClients())
                {
                    Positionner(clientBindingSource, "NoClient", noClient);
                    MessageBox.Show("Le client " + noClient.ToString() + " a été ajouté.", "Ajout d'un client",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if (clientBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Modification d'un client",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BDB56Projet1BKGDataSet.ClientRow unClient =
                (BDB56Projet1BKGDataSet.ClientRow)((DataRowView)clientBindingSource.Current).Row;
            decimal noClient = unClient.NoClient;

            frmClient frmModif = new frmClient();
            frmModif.unClient = unClient;
            frmModif.ShowDialog();

            if (unClient.RowState == DataRowState.Modified)
            {
                if (EnregistrerClients())
                    MessageBox.Show("Le client " + noClient.ToString() + " a été modifié.", "Modification d'un client",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (clientBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Suppression d'un client",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BDB56Projet1BKGDataSet.ClientRow unClient =
                (BDB56Projet1BKGDataSet.ClientRow)((DataRowView)clientBindingSource.Current).Row;
            decimal noClient = unClient.NoClient;

            try
            {
                this.inviteTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Invite);
                this.reservationChambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.ReservationChambre);
                this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string messageErreur = string.Empty;
            if (unClient.GetInviteRows().Length > 0)
                messageErreur = "Le client " + noClient + " ne peut pas être supprimé : il a des invités.";
            else if (unClient.GetReservationChambreRows().Length > 0)
                messageErreur = "Le client " + noClient + " ne peut pas être supprimé : il a réservé une chambre.";
            else if (bDB56Projet1BKGDataSet.PlanifSoin.Any(p => p.NoPersonne == noClient))
                messageErreur = "Le client " + noClient + " ne peut pas être supprimé : des soins sont planifiés pour lui.";

            if (messageErreur != string.Empty)
            {
                MessageBox.Show(messageErreur, "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer le client " + noClient + " ?", "Suppression d'un client",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            clientBindingSource.RemoveCurrent();

            if (EnregistrerClients())
                MessageBox.Show("Le client " + noClient.ToString() + " a été supprimé.", "Suppression d'un client",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAjouterInvite_Click(object sender, EventArgs e)
        {
            if (clientBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Ajout d'un invité",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Recharger();

            BDB56Projet1BKGDataSet.ClientRow leClient =
                (BDB56Projet1BKGDataSet.ClientRow)((DataRowView)clientBindingSource.Current).Row;
            decimal noClient = leClient.NoClient;

            if (leClient.GetInviteRows().Length >= 9)
            {
                MessageBox.Show("Le client " + noClient + " a déjà 9 invités (maximum).", "Ajout d'un invité",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BDB56Projet1BKGDataSet.InviteRow unInvite = bDB56Projet1BKGDataSet.Invite.NewInviteRow();

            decimal noInvite = noClient + 1;
            while (bDB56Projet1BKGDataSet.Invite.FindByNoInvite(noInvite) != null)
                noInvite++;

            unInvite.NoInvite = noInvite;
            unInvite.NoClient = noClient;

            frmInvite frmAjout = new frmInvite();
            frmAjout.unInvite = unInvite;
            frmAjout.ShowDialog();

            if (!unInvite.IsNomPrenomNull())
            {
                bDB56Projet1BKGDataSet.Invite.AddInviteRow(unInvite);

                if (EnregistrerInvites())
                {
                    Positionner(inviteBindingSource, "NoInvite", noInvite);
                    MessageBox.Show("L'invité " + noInvite.ToString() + " a été ajouté.", "Ajout d'un invité",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModifierInvite_Click(object sender, EventArgs e)
        {
            if (inviteBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un invité.", "Modification d'un invité",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BDB56Projet1BKGDataSet.InviteRow unInvite =
                (BDB56Projet1BKGDataSet.InviteRow)((DataRowView)inviteBindingSource.Current).Row;
            decimal noInvite = unInvite.NoInvite;

            frmInvite frmModif = new frmInvite();
            frmModif.unInvite = unInvite;
            frmModif.ShowDialog();

            if (unInvite.RowState == DataRowState.Modified)
            {
                if (EnregistrerInvites())
                    MessageBox.Show("L'invité " + noInvite.ToString() + " a été modifié.", "Modification d'un invité",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimerInvite_Click(object sender, EventArgs e)
        {
            if (inviteBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un invité.", "Suppression d'un invité",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal noInvite = NoCourant(inviteBindingSource, "NoInvite");

            try
            {
                this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bDB56Projet1BKGDataSet.PlanifSoin.Any(p => p.NoPersonne == noInvite))
            {
                MessageBox.Show("L'invité " + noInvite + " ne peut pas être supprimé : des soins sont planifiés pour lui.",
                    "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer l'invité " + noInvite + " ?", "Suppression d'un invité",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            inviteBindingSource.RemoveCurrent();

            if (EnregistrerInvites())
                MessageBox.Show("L'invité " + noInvite.ToString() + " a été supprimé.", "Suppression d'un invité",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0 &&
                (e.StatementType == StatementType.Update || e.StatementType == StatementType.Delete))
            {
                conflit = true;
                string no = e.Row[0, DataRowVersion.Original].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour l'enregistrement " + no +
                    ". Cet enregistrement ne sera pas sauvegardé.", "Conflit d'accès",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Status = UpdateStatus.Continue;
            }
        }

        private void GestionClientEtInvite_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bDB56Projet1BKGDataSet.Client.WriteXml("Client.xml");
                bDB56Projet1BKGDataSet.Invite.WriteXml("Invite.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement XML : " + ex.Message, "Enregistrement XML",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
