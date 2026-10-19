using Projet1___VS.BDB56Projet1BKGDataSetTableAdapters;
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
    public partial class ReservationChambre : Form
    {
        private readonly BDB56Projet1BKGDataSet ds = new BDB56Projet1BKGDataSet();
        private readonly ClientTableAdapter clientTA = new ClientTableAdapter();
        private readonly TypeChambreTableAdapter typeTA = new TypeChambreTableAdapter();
        private readonly ChambreTableAdapter chambreTA = new ChambreTableAdapter();
        private readonly ReservationChambreTableAdapter reservTA = new ReservationChambreTableAdapter();

        public ReservationChambre()
        {
            InitializeComponent();
        }

        private void reservationChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);

        }

        private void ReservationChambre_Load(object sender, EventArgs e)
        {
            clientTA.Fill(ds.Client);
            typeTA.Fill(ds.TypeChambre);
            chambreTA.Fill(ds.Chambre);
            reservTA.Fill(ds.ReservationChambre);

            reservationChambreDataGridView.DataSource = ds.ReservationChambre;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DataRow nouvelle = ds.ReservationChambre.NewRow();

            using (var f = new AjouterReservation(nouvelle, ds))
            {
                if (f.ShowDialog() != DialogResult.OK) return;
            }

            try
            {
                ds.ReservationChambre.Rows.Add(nouvelle);
                reservTA.Update(ds.ReservationChambre);   // mémoire + base
            }
            catch (Exception ex)
            {
                ds.ReservationChambre.RejectChanges();
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!(reservationChambreDataGridView.CurrentRow?.DataBoundItem is DataRowView rv))
            {
                MessageBox.Show("Sélectionne une réservation à annuler.");
                return;
            }

            DateTime arrivee = Convert.ToDateTime(rv["DateArrivee"]);
            if (arrivee.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Impossible d'annuler : la date de début du séjour est antérieure à la date actuelle.",
                    "Annulation refusée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment annuler cette réservation ?", "Suppression",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                rv.Row.Delete();
                reservTA.Update(ds.ReservationChambre);
            }
            catch (Exception ex)
            {
                ds.ReservationChambre.RejectChanges();
                MessageBox.Show("Erreur lors de l'annulation : " + ex.Message, "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
