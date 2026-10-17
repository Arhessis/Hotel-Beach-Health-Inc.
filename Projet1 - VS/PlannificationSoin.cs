using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet1___VS
{
    public partial class PlannificationSoin : Form
    {
        private bool enModeAjout = false;

        public PlannificationSoin()
        {
            InitializeComponent();
        }

        private void PlannificationSoin_Load(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Client);
                this.inviteTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Invite);
                this.soinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Soin);
                this.assistantTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Assistant);
                this.assistantSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.AssistantSoin);
                this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);

                ChargerListesDeroulantes();
                GererEtatControles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerListesDeroulantes()
        {
            DataTable dtPersonnes = new DataTable();
            dtPersonnes.Columns.Add("NoPersonne", typeof(decimal));
            dtPersonnes.Columns.Add("NomAffichage", typeof(string));

            foreach (DataRow cRow in bDB56Projet1BKGDataSet.Client.Rows)
            {
                dtPersonnes.Rows.Add(cRow["NoClient"], $"Client: {cRow["Prenom"]} {cRow["Nom"]} (No {cRow["NoClient"]})");
            }
            foreach (DataRow iRow in bDB56Projet1BKGDataSet.Invite.Rows)
            {
                dtPersonnes.Rows.Add(iRow["NoInvite"], $"Invité: {iRow["NomPrenom"]} (No {iRow["NoClient"]})");
            }

            cboNoPersonne.DataSource = dtPersonnes;
            cboNoPersonne.DisplayMember = "NomAffichage";
            cboNoPersonne.ValueMember = "NoPersonne";
            cboNoPersonne.DropDownStyle = ComboBoxStyle.DropDownList;

            cboNoSoin.DataSource = bDB56Projet1BKGDataSet.Soin;
            cboNoSoin.DisplayMember = "Description";
            cboNoSoin.ValueMember = "NoSoin";
            cboNoSoin.DropDownStyle = ComboBoxStyle.DropDownList;

            cboNoSoin.SelectedIndexChanged += cboNoSoin_SelectedIndexChanged;
            MettreAJourAssistants();
        }

        private void cboNoSoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourAssistants();
        }

        private decimal GetSelectedId(ComboBox cbo)
        {
            if (cbo.SelectedValue == null) return 0;

            if (cbo.SelectedValue is DataRowView drv)
            {
                string colName = cbo.ValueMember;
                if (drv.Row.Table.Columns.Contains(colName))
                {
                    return Convert.ToDecimal(drv[colName]);
                }
            }

            if (decimal.TryParse(cbo.SelectedValue.ToString(), out decimal val))
            {
                return val;
            }

            return 0;
        }

        private void MettreAJourAssistants()
        {
            decimal noSoinSelectionne = GetSelectedId(cboNoSoin);
            if (noSoinSelectionne == 0) return;

            var assistantIds = bDB56Projet1BKGDataSet.AssistantSoin
                .Where(ast => ast.NoSoin == noSoinSelectionne)
                .Select(ast => ast.NoAssistant)
                .ToList();

            var assistantsFiltres = bDB56Projet1BKGDataSet.Assistant
                .Where(a => assistantIds.Contains(a.NoAssistant))
                .ToList();

            DataTable dtAssistantsFiltres = bDB56Projet1BKGDataSet.Assistant.Clone();
            foreach (var ast in assistantsFiltres)
            {
                dtAssistantsFiltres.ImportRow(ast);
            }

            cboNoAssistant.DataSource = dtAssistantsFiltres;
            cboNoAssistant.DisplayMember = "Nom";
            cboNoAssistant.ValueMember = "NoAssistant";
            cboNoAssistant.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void GererEtatControles(bool enEdition)
        {
            planifSoinDataGridView.Enabled = !enEdition;
            btnAjouter.Enabled = !enEdition;
            btnSupprimer.Enabled = !enEdition && planifSoinBindingSource.Count > 0;
            btnEnregistrer.Enabled = enEdition;
            btnAnnuler.Enabled = enEdition;

            cboNoPersonne.Enabled = enEdition;
            cboNoSoin.Enabled = enEdition;
            cboNoAssistant.Enabled = enEdition;
            dtpDateHeure.Enabled = enEdition;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            enModeAjout = true;
            planifSoinBindingSource.AddNew();
            dtpDateHeure.Value = DateTime.Now.AddDays(1);
            GererEtatControles(true);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (planifSoinBindingSource.Current == null) return;

            DataRowView row = (DataRowView)planifSoinBindingSource.Current;
            DateTime dateHeure = Convert.ToDateTime(row["DateHeure"]);

            if (dateHeure < DateTime.Now)
            {
                MessageBox.Show("Impossible de supprimer un soin déjà offert.", "Opération interdite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer cette planification de soin ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                planifSoinBindingSource.RemoveCurrent();
                SauvegarderDonnees();
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            decimal personneId = GetSelectedId(cboNoPersonne);
            decimal soinId = GetSelectedId(cboNoSoin);
            decimal assistantId = GetSelectedId(cboNoAssistant);

            if (personneId == 0 || soinId == 0 || assistantId == 0)
            {
                MessageBox.Show("Tous les champs sont obligatoires.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dateHeureSaisie = dtpDateHeure.Value;

            if (dateHeureSaisie.Date < DateTime.Today)
            {
                MessageBox.Show("La date de réservation ne peut pas être antérieure à la date du jour.", "Validation de date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateHeureSaisie.DayOfWeek == DayOfWeek.Saturday || dateHeureSaisie.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("La date de réservation ne peut pas être un samedi ou un dimanche.", "Validation de date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int heure = dateHeureSaisie.Hour;
            if (heure < 8 || heure >= 17)
            {
                MessageBox.Show("L'heure de réservation doit être entre 8h et 17h.", "Validation d'heure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool conflitAssistant = bDB56Projet1BKGDataSet.PlanifSoin.Any(p =>
                p.RowState != DataRowState.Deleted &&
                p.NoAssistant == assistantId &&
                p.DateHeure == dateHeureSaisie);

            if (conflitAssistant)
            {
                MessageBox.Show("Cet assistant est déjà assigné à un autre soin à cette date et heure.", "Conflit d'horaire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView currentRow = (DataRowView)planifSoinBindingSource.Current;
            currentRow["NoPersonne"] = personneId;
            currentRow["NoSoin"] = soinId;
            currentRow["NoAssistant"] = assistantId;
            currentRow["DateHeure"] = dateHeureSaisie;

            if (SauvegarderDonnees())
            {
                enModeAjout = false;
                GererEtatControles(false);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            planifSoinBindingSource.CancelEdit();
            bDB56Projet1BKGDataSet.PlanifSoin.RejectChanges();
            enModeAjout = false;
            GererEtatControles(false);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool SauvegarderDonnees()
        {
            try
            {
                this.Validate();
                this.planifSoinBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDB56Projet1BKGDataSet);
                MessageBox.Show("Planification sauvegardée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Conflit d'accès détecté : les données ont été modifiées par un autre utilisateur.", "Conflit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.planifSoinTableAdapter.Fill(this.bDB56Projet1BKGDataSet.PlanifSoin);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}