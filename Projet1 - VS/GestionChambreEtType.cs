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
    public partial class GestionChambreEtType : Form
    {
        private bool conflit = false;

        public GestionChambreEtType()
        {
            InitializeComponent();
        }

        private void GestionChambreEtType_Load(object sender, EventArgs e)
        {
            typeChambreTableAdapter.Adapter.RowUpdated -= tableAdapter_RowUpdated;
            typeChambreTableAdapter.Adapter.RowUpdated += tableAdapter_RowUpdated;
            chambreTableAdapter.Adapter.RowUpdated -= tableAdapter_RowUpdated;
            chambreTableAdapter.Adapter.RowUpdated += tableAdapter_RowUpdated;
        }

        private void GestionChambreEtType_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                Recharger();
        }

        private void Recharger()
        {
            decimal noType = NoCourant(typeChambreBindingSource, "NoTypeChambre");
            decimal noChambre = NoCourant(chambreBindingSource, "NoChambre");

            try
            {
                this.chambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Chambre);
                this.typeChambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.TypeChambre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Positionner(typeChambreBindingSource, "NoTypeChambre", noType);
            Positionner(chambreBindingSource, "NoChambre", noChambre);
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

        private bool EnregistrerTypes()
        {
            conflit = false;
            try
            {
                this.Validate();
                this.typeChambreBindingSource.EndEdit();
                this.typeChambreTableAdapter.Update(this.bDB56Projet1BKGDataSet.TypeChambre);
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

        private bool EnregistrerChambres()
        {
            conflit = false;
            try
            {
                this.Validate();
                this.chambreBindingSource.EndEdit();
                this.chambreTableAdapter.Update(this.bDB56Projet1BKGDataSet.Chambre);
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

        private void btnTypePrecedent_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MovePrevious();
        }

        private void btnTypeSuivant_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MoveNext();
        }

        private void btnChambrePrecedent_Click(object sender, EventArgs e)
        {
            chambreBindingSource.MovePrevious();
        }

        private void btnChambreSuivant_Click(object sender, EventArgs e)
        {
            chambreBindingSource.MoveNext();
        }

        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            Recharger();

            BDB56Projet1BKGDataSet.TypeChambreRow unType = bDB56Projet1BKGDataSet.TypeChambre.NewTypeChambreRow();

            decimal noTypeMax = 0;
            foreach (BDB56Projet1BKGDataSet.TypeChambreRow uneLigne in bDB56Projet1BKGDataSet.TypeChambre.Rows)
                if (uneLigne.RowState != DataRowState.Deleted && uneLigne.NoTypeChambre > noTypeMax)
                    noTypeMax = uneLigne.NoTypeChambre;

            unType.NoTypeChambre = noTypeMax + 1;

            GestionTypeChambre frmAjout = new GestionTypeChambre();
            frmAjout.unType = unType;
            frmAjout.ShowDialog();

            if (!unType.IsDescriptionNull())
            {
                bDB56Projet1BKGDataSet.TypeChambre.AddTypeChambreRow(unType);
                decimal noType = unType.NoTypeChambre;

                if (EnregistrerTypes())
                {
                    Positionner(typeChambreBindingSource, "NoTypeChambre", noType);
                    MessageBox.Show("Le type de chambre " + noType.ToString() + " a été ajouté.", "Ajout d'un type de chambre",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModifierType_Click(object sender, EventArgs e)
        {
            if (typeChambreBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de chambre.", "Modification d'un type de chambre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BDB56Projet1BKGDataSet.TypeChambreRow unType =
                (BDB56Projet1BKGDataSet.TypeChambreRow)((DataRowView)typeChambreBindingSource.Current).Row;
            decimal noType = unType.NoTypeChambre;

            GestionTypeChambre frmModif = new GestionTypeChambre();
            frmModif.unType = unType;
            frmModif.ShowDialog();

            if (unType.RowState == DataRowState.Modified)
            {
                if (EnregistrerTypes())
                    MessageBox.Show("Le type de chambre " + noType.ToString() + " a été modifié.", "Modification d'un type de chambre",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimerType_Click(object sender, EventArgs e)
        {
            if (typeChambreBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de chambre.", "Suppression d'un type de chambre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BDB56Projet1BKGDataSet.TypeChambreRow unType =
                (BDB56Projet1BKGDataSet.TypeChambreRow)((DataRowView)typeChambreBindingSource.Current).Row;
            decimal noType = unType.NoTypeChambre;

            try
            {
                this.chambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.Chambre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (unType.GetChambreRows().Length > 0)
            {
                MessageBox.Show("Le type de chambre " + noType + " ne peut pas être supprimé : il existe des chambres de ce type.",
                    "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer le type de chambre " + noType + " ?", "Suppression d'un type de chambre",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            typeChambreBindingSource.RemoveCurrent();

            if (EnregistrerTypes())
                MessageBox.Show("Le type de chambre " + noType.ToString() + " a été supprimé.", "Suppression d'un type de chambre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {
            Recharger();

            if (typeChambreBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez d'abord ajouter un type de chambre.", "Ajout d'une chambre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BDB56Projet1BKGDataSet.ChambreRow uneChambre = bDB56Projet1BKGDataSet.Chambre.NewChambreRow();

            decimal noChambreMax = 0;
            foreach (BDB56Projet1BKGDataSet.ChambreRow uneLigne in bDB56Projet1BKGDataSet.Chambre.Rows)
                if (uneLigne.RowState != DataRowState.Deleted && uneLigne.NoChambre > noChambreMax)
                    noChambreMax = uneLigne.NoChambre;

            uneChambre.NoChambre = noChambreMax + 1;
            uneChambre.NoTypeChambre = NoCourant(typeChambreBindingSource, "NoTypeChambre");

            GestionChambre frmAjout = new GestionChambre();
            frmAjout.uneChambre = uneChambre;
            frmAjout.ShowDialog();

            if (!uneChambre.IsEmplacementNull())
            {
                bDB56Projet1BKGDataSet.Chambre.AddChambreRow(uneChambre);
                decimal noChambre = uneChambre.NoChambre;
                decimal noType = uneChambre.NoTypeChambre;

                if (EnregistrerChambres())
                {
                    Positionner(typeChambreBindingSource, "NoTypeChambre", noType);
                    Positionner(chambreBindingSource, "NoChambre", noChambre);
                    MessageBox.Show("La chambre " + noChambre.ToString() + " a été ajoutée.", "Ajout d'une chambre",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModifierChambre_Click(object sender, EventArgs e)
        {
            if (chambreBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner une chambre.", "Modification d'une chambre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BDB56Projet1BKGDataSet.ChambreRow uneChambre =
                (BDB56Projet1BKGDataSet.ChambreRow)((DataRowView)chambreBindingSource.Current).Row;
            decimal noChambre = uneChambre.NoChambre;

            GestionChambre frmModif = new GestionChambre();
            frmModif.uneChambre = uneChambre;
            frmModif.ShowDialog();

            if (uneChambre.RowState == DataRowState.Modified)
            {
                decimal noType = uneChambre.NoTypeChambre;

                if (EnregistrerChambres())
                {
                    Positionner(typeChambreBindingSource, "NoTypeChambre", noType);
                    Positionner(chambreBindingSource, "NoChambre", noChambre);
                    MessageBox.Show("La chambre " + noChambre.ToString() + " a été modifiée.", "Modification d'une chambre",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSupprimerChambre_Click(object sender, EventArgs e)
        {
            if (chambreBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner une chambre.", "Suppression d'une chambre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BDB56Projet1BKGDataSet.ChambreRow uneChambre =
                (BDB56Projet1BKGDataSet.ChambreRow)((DataRowView)chambreBindingSource.Current).Row;
            decimal noChambre = uneChambre.NoChambre;

            try
            {
                this.reservationChambreTableAdapter.Fill(this.bDB56Projet1BKGDataSet.ReservationChambre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (uneChambre.GetReservationChambreRows().Length > 0)
            {
                MessageBox.Show("La chambre " + noChambre + " ne peut pas être supprimée : elle est réservée.",
                    "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer la chambre " + noChambre + " ?", "Suppression d'une chambre",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            chambreBindingSource.RemoveCurrent();

            if (EnregistrerChambres())
                MessageBox.Show("La chambre " + noChambre.ToString() + " a été supprimée.", "Suppression d'une chambre",
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

        private void GestionChambreEtType_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bDB56Projet1BKGDataSet.TypeChambre.WriteXml("TypeChambre.xml");
                bDB56Projet1BKGDataSet.Chambre.WriteXml("Chambre.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement XML : " + ex.Message, "Enregistrement XML",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
