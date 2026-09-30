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
    public partial class GestionClientEtInvite : Form
    {
        public GestionClientEtInvite()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

        }

        private void GestionClientEtInvite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.Invite' table. You can move, or remove it, as needed.
            this.inviteTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Invite);
            // TODO: This line of code loads data into the 'bDB56Projet1BKGDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Client);

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

        private void btnGestionClient_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionInvite_Click(object sender, EventArgs e)
        {

        }
    }
}
