using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1___VS
{
    public partial class AjouterReservation : Form
    {
        private readonly DataRow reservation;
        private readonly BDB56Projet1BKGDataSet ds;
        private DataTable chambres;

        public AjouterReservation(DataRow nouvelleReservation, BDB56Projet1BKGDataSet dataSet)
        {
            InitializeComponent();
            reservation = nouvelleReservation;
            ds = dataSet;
        }

        private void AjouterReservation_Load(object sender, EventArgs e)
        {
            // Liste des clients : "numéro - prénom nom"
            DataTable clients = ds.Client.Copy();
            clients.Columns.Add("Affichage", typeof(string),
                "Convert(NoClient, 'System.String') + ' - ' + Prenom + ' ' + Nom");
            cbClient.DataSource = clients;
            cbClient.DisplayMember = "Affichage";
            cbClient.ValueMember = "NoClient";

            // Tableau des chambres avec les prix du type de chambre
            chambres = new DataTable();
            chambres.Columns.Add("NoChambre", ds.Chambre.NoChambreColumn.DataType);
            chambres.Columns.Add("Emplacement", typeof(string));
            chambres.Columns.Add("Decorations", typeof(string));
            chambres.Columns.Add("PrixHaut", ds.TypeChambre.PrixHautColumn.DataType);
            chambres.Columns.Add("PrixMoyen", ds.TypeChambre.PrixMoyenColumn.DataType);
            chambres.Columns.Add("PrixBas", ds.TypeChambre.PrixBasColumn.DataType);

            foreach (DataRow c in ds.Chambre.Rows)
            {
                DataRow[] t = ds.TypeChambre.Select("NoTypeChambre = " +
                    Convert.ToDecimal(c["NoTypeChambre"]).ToString(CultureInfo.InvariantCulture));
                if (t.Length == 0) continue;

                chambres.Rows.Add(c["NoChambre"], c["Emplacement"], c["Decorations"],
                                  t[0]["PrixHaut"], t[0]["PrixMoyen"], t[0]["PrixBas"]);
            }
            dgChambre.DataSource = chambres;

            // Dates
            dtpDebut.MinDate = DateTime.Today;
            dtpDebut.Value = DateTime.Today;
            dtpFin.MinDate = DateTime.Today.AddDays(1);
            dtpFin.Value = DateTime.Today.AddDays(1);
        }

        private bool ChambreDisponible(object noChambre, DateTime debut, DateTime fin)
        {
            DataRow[] existantes = ds.ReservationChambre.Select("NoChambre = " +
                Convert.ToDecimal(noChambre).ToString(CultureInfo.InvariantCulture));

            foreach (DataRow r in existantes)
            {
                DateTime rDebut = Convert.ToDateTime(r["DateArrivee"]).Date;
                DateTime rFin = Convert.ToDateTime(r["DateDepart"]).Date;

                // Chevauchement : le jour de départ d'une réservation reste libre
                if (rDebut < fin && rFin > debut)
                    return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbClient.SelectedValue == null)
            {
                MessageBox.Show("Sélectionne un client.");
                return;
            }

            if (!(dgChambre.CurrentRow?.DataBoundItem is DataRowView chambre))
            {
                MessageBox.Show("Sélectionne une chambre.");
                return;
            }

            DateTime debut = dtpDebut.Value.Date;
            DateTime fin = dtpFin.Value.Date;

            if (debut < DateTime.Today)
            {
                MessageBox.Show("La date de début ne peut pas être antérieure à aujourd'hui.");
                return;
            }

            if (fin <= debut)
            {
                MessageBox.Show("La date de fin doit être postérieure à la date de début.");
                return;
            }

            if (!ChambreDisponible(chambre["NoChambre"], debut, fin))
            {
                MessageBox.Show("Cette chambre n'est pas disponible pour toute la période demandée.",
                                "Chambre non disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            reservation["NoClient"] = cbClient.SelectedValue;
            reservation["NoChambre"] = chambre["NoChambre"];
            reservation["DateArrivee"] = debut;
            reservation["DateDepart"] = fin;
            reservation["NbPersonnes"] = Convert.ChangeType(
                nudPersonnes.Value, ds.ReservationChambre.NbPersonnesColumn.DataType);

            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
