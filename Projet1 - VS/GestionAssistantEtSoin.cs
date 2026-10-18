

using Projet1___VS.BDB56Projet1BKGDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1___VS
{

    public partial class GestionAssistantEtSoin : Form
    {


        private readonly string chaineConnexion = "Data Source=424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet1BKG;Persist Security Info=True;User ID=B56Projet1BKG;Password=Password-BKG;TrustServerCertificate=True";
        private readonly AssistantSoinTableAdapter assistantSoinTableAdapter = new AssistantSoinTableAdapter();

        public GestionAssistantEtSoin()
        {
            InitializeComponent();
        }



        private void GestionAssistantEtSoin_Load(object sender, EventArgs e)
        {
           assistantTableAdapter.Fill(bDB56Projet1BKGDataSet.Assistant);
    soinTableAdapter.Fill(bDB56Projet1BKGDataSet.Soin);                 // tous les soins
    assistantSoinTableAdapter.Fill(bDB56Projet1BKGDataSet.AssistantSoin);
    AfficherSoinsAssistant();

        }

        private DataTable SoinsDisponibles(decimal noAssistant)
        {
            var dt = bDB56Projet1BKGDataSet.Soin.Clone();
            var deja = bDB56Projet1BKGDataSet.AssistantSoin
                .Select("NoAssistant = " + noAssistant.ToString(CultureInfo.InvariantCulture))
                .Select(r => Convert.ToDecimal(r["NoSoin"]))
                .ToList();

            foreach (DataRow s in bDB56Projet1BKGDataSet.Soin.Rows)
                if (!deja.Contains(Convert.ToDecimal(s["NoSoin"])))
                    dt.ImportRow(s);

            return dt;
        }


        private void dgAssistant_SelectionChanged(object sender, EventArgs e)
        {
            AfficherSoinsAssistant();
        }

        private decimal? AssistantCourant()
        {
            if (assistantBindingSource.Current is DataRowView a &&
                a["NoAssistant"] != DBNull.Value)
                return Convert.ToDecimal(a["NoAssistant"]);
            return null;
        }

        private void AfficherSoinsAssistant()
        {
            decimal? no = AssistantCourant();
            if (no == null) { soinBindingSource.Filter = "1 = 0"; return; }

            var noms = bDB56Projet1BKGDataSet.AssistantSoin
                .Select("NoAssistant = " + no.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))
                .Select(r => Convert.ToDecimal(r["NoSoin"]).ToString(System.Globalization.CultureInfo.InvariantCulture))
                .ToArray();

            soinBindingSource.Filter = noms.Length == 0
                ? "1 = 0"
                : "NoSoin IN (" + string.Join(",", noms) + ")";
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var unAssistant = bDB56Projet1BKGDataSet.Assistant.NewAssistantRow();

            decimal noMax = 0;
            foreach (BDB56Projet1BKGDataSet.AssistantRow ligne in bDB56Projet1BKGDataSet.Assistant.Rows)
                if (ligne.NoAssistant > noMax) noMax = ligne.NoAssistant;

            unAssistant.NoAssistant = noMax + 1;

            using (var assistAdd = new AjouterAssist())
            {
                assistAdd.unAssistant = unAssistant;

                if (assistAdd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bDB56Projet1BKGDataSet.Assistant.AddAssistantRow(unAssistant);
                        assistantTableAdapter.Update(bDB56Projet1BKGDataSet.Assistant);
                        assistantBindingSource.MoveLast();
                    }
                    catch (Exception ex)
                    {
                        bDB56Projet1BKGDataSet.Assistant.RejectChanges();
                        MessageBox.Show("Erreur lors de l'ajout : " + ex.Message,
                                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            decimal? no = AssistantCourant();
            if (no == null) return;

            try
            {
                if (ACesPlanifications(no.Value))
                {
                    MessageBox.Show(
                        "Impossible de supprimer cet assistant : des planifications de soins lui sont assignées.",
                        "Suppression refusée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show(
                        "Supprimer cet assistant ainsi que tous les soins qu'il offre ?",
                        "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                SupprimerAssistantEtSesSoins(no.Value);

                bDB56Projet1BKGDataSet.AssistantSoin.Clear();
                bDB56Projet1BKGDataSet.Assistant.Clear();
                assistantTableAdapter.Fill(bDB56Projet1BKGDataSet.Assistant);
                assistantSoinTableAdapter.Fill(bDB56Projet1BKGDataSet.AssistantSoin);
                AfficherSoinsAssistant();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ACesPlanifications(decimal noAssistant)
        {
            using (var cn = new SqlConnection(chaineConnexion))
            using (var cmd = new SqlCommand(
                "SELECT COUNT(*) FROM PlanifSoin WHERE NoAssistant = @no", cn))
            {
                cmd.Parameters.AddWithValue("@no", noAssistant);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void SupprimerAssistantEtSesSoins(decimal noAssistant)
        {
            using (var cn = new SqlConnection(chaineConnexion))
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (var c1 = new SqlCommand(
                            "DELETE FROM AssistantSoin WHERE NoAssistant = @no", cn, tx))
                        {
                            c1.Parameters.AddWithValue("@no", noAssistant);
                            c1.ExecuteNonQuery();
                        }
                        using (var c2 = new SqlCommand(
                            "DELETE FROM Assistant WHERE NoAssistant = @no", cn, tx))
                        {
                            c2.Parameters.AddWithValue("@no", noAssistant);
                            c2.ExecuteNonQuery();
                        }
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }


        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            decimal? no = AssistantCourant();
            if (no == null) return;

            DataTable dispo = SoinsDisponibles(no.Value);
            if (dispo.Rows.Count == 0)
            {
                MessageBox.Show("Cet assistant offre déjà tous les soins disponibles.",
                                "Aucun soin à ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var f = new AjouterSoinAssistant(dispo))
            {
                if (f.ShowDialog() != DialogResult.OK || f.SoinChoisi == null) return;

                try
                {
                    DataRow lien = bDB56Projet1BKGDataSet.AssistantSoin.NewRow();
                    lien["NoAssistant"] = no.Value;
                    lien["NoSoin"] = f.SoinChoisi["NoSoin"];
                    bDB56Projet1BKGDataSet.AssistantSoin.Rows.Add(lien);

                    assistantSoinTableAdapter.Update(bDB56Projet1BKGDataSet.AssistantSoin);
                    AfficherSoinsAssistant();
                }
                catch (Exception ex)
                {
                    bDB56Projet1BKGDataSet.AssistantSoin.RejectChanges();
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSupprimerSoin_Click(object sender, EventArgs e)
        {
            decimal? noAssistant = AssistantCourant();
            if (noAssistant == null) return;

            if (!(soinBindingSource.Current is DataRowView soin))
            {
                MessageBox.Show("Sélectionne un soin à retirer.");
                return;
            }

            decimal noSoin = Convert.ToDecimal(soin["NoSoin"]);

            try
            {
                using (var cn = new SqlConnection(chaineConnexion))
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM PlanifSoin WHERE NoAssistant = @a AND NoSoin = @s", cn))
                {
                    cmd.Parameters.AddWithValue("@a", noAssistant.Value);
                    cmd.Parameters.AddWithValue("@s", noSoin);
                    cn.Open();

                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show(
                            "Impossible de retirer ce soin : des planifications l'utilisent avec cet assistant.",
                            "Suppression refusée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (MessageBox.Show("Retirer ce soin de l'assistant ?", "Suppression",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                DataRow[] liens = bDB56Projet1BKGDataSet.AssistantSoin.Select(
                    "NoAssistant = " + noAssistant.Value.ToString(CultureInfo.InvariantCulture) +
                    " AND NoSoin = " + noSoin.ToString(CultureInfo.InvariantCulture));

                foreach (DataRow l in liens) l.Delete();
                assistantSoinTableAdapter.Update(bDB56Projet1BKGDataSet.AssistantSoin);

                AfficherSoinsAssistant();
            }
            catch (Exception ex)
            {
                bDB56Projet1BKGDataSet.AssistantSoin.RejectChanges();
                MessageBox.Show("Erreur lors du retrait du soin : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgAssistant_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string col = dgAssistant.Columns[e.ColumnIndex].DataPropertyName;

            // Prénom, Nom et Spécialités sont obligatoires, Remarques est facultatif
            if ((col == "Prenom" || col == "Nom" || col == "Specialites") &&
                string.IsNullOrWhiteSpace(e.FormattedValue?.ToString()))
            {
                MessageBox.Show("Le champ " + col + " est obligatoire.",
                                "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;   // garde l'utilisateur dans la cellule
            }
        }

       

        private void dgAssistant_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                assistantBindingSource.EndEdit();

                // On n'enregistre que si une ligne existante a vraiment été modifiée
                if (bDB56Projet1BKGDataSet.Assistant.GetChanges(DataRowState.Modified) != null)
                    assistantTableAdapter.Update(bDB56Projet1BKGDataSet.Assistant);
            }
            catch (Exception ex)
            {
                bDB56Projet1BKGDataSet.Assistant.RejectChanges();
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

