using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1___VS
{
    public partial class frmTypeChambre : Form
    {
        public Regex exprMontant { get; }

        public frmTypeChambre()
        {
            InitializeComponent();

            char point = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            exprMontant = new Regex("^[0-9]{1,4}(" + Regex.Escape(point.ToString()) + "[0-9]{2})?$");
        }

        public BDB56Projet1BKGDataSet.TypeChambreRow unType;

        private void GestionTypeChambre_Load(object sender, EventArgs e)
        {
            if (unType.RowState == DataRowState.Detached)
            {
                this.Text = "Ajouter un type de chambre";
                lblTitre.Text = "Ajouter un type de chambre";
                lblSousTitre.Text = "La description du type doit être unique";
            }
            else
            {
                this.Text = "Modifier un type de chambre";
                lblTitre.Text = "Modifier un type de chambre";
                lblSousTitre.Text = "Le numéro du type n'est pas modifiable";
            }

            txtNoTypeChambre.Text = unType.NoTypeChambre.ToString();
            txtDescription.Text = unType.IsDescriptionNull() ? string.Empty : unType.Description;
            txtPrixHaut.Text = unType.IsPrixHautNull() ? string.Empty : unType.PrixHaut.ToString("0.00");
            txtPrixBas.Text = unType.IsPrixBasNull() ? string.Empty : unType.PrixBas.ToString("0.00");
            txtPrixMoyen.Text = unType.IsPrixMoyenNull() ? string.Empty : unType.PrixMoyen.ToString("0.00");
        }

        private decimal LireMontant(TextBox txt)
        {
            decimal valeur;
            return decimal.TryParse(txt.Text, out valeur) ? valeur : 0;
        }

        private void ValiderPrix(TextBox txt, CancelEventArgs e)
        {
            string messageErreur = string.Empty;
            if (!exprMontant.IsMatch(txt.Text.Trim()))
            {
                messageErreur = "Cette donnée n'est pas dans un format valide (ex. : 125" +
                    CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "00, maximum 9999" +
                    CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "99)";
                e.Cancel = true;
            }
            errMessage.SetError(txt, messageErreur);
        }

        private void txtPrixHaut_Validating(object sender, CancelEventArgs e)
        {
            ValiderPrix(txtPrixHaut, e);
        }

        private void txtPrixBas_Validating(object sender, CancelEventArgs e)
        {
            ValiderPrix(txtPrixBas, e);
        }

        private void txtPrixMoyen_Validating(object sender, CancelEventArgs e)
        {
            ValiderPrix(txtPrixMoyen, e);
        }

        private bool DescriptionExiste(string description)
        {
            foreach (BDB56Projet1BKGDataSet.TypeChambreRow uneLigne in unType.Table.Rows)
                if (uneLigne != unType && uneLigne.RowState != DataRowState.Deleted && !uneLigne.IsDescriptionNull()
                    && string.Compare(uneLigne.Description.Trim(), description, true) == 0)
                    return true;
            return false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text.Trim();

            if (description == string.Empty)
                errMessage.SetError(txtDescription, "La description ne peut pas être vide");
            else if (DescriptionExiste(description))
                errMessage.SetError(txtDescription, "Cette description existe déjà pour un autre type de chambre");
            else
            {
                errMessage.SetError(txtDescription, string.Empty);

                if (!exprMontant.IsMatch(txtPrixHaut.Text.Trim()))
                    errMessage.SetError(txtPrixHaut, "Le prix de la haute saison n'est pas dans un format valide");
                else if (!exprMontant.IsMatch(txtPrixBas.Text.Trim()))
                    errMessage.SetError(txtPrixBas, "Le prix de la basse saison n'est pas dans un format valide");
                else if (!exprMontant.IsMatch(txtPrixMoyen.Text.Trim()))
                    errMessage.SetError(txtPrixMoyen, "Le prix de la moyenne saison n'est pas dans un format valide");
                else
                {
                    decimal prixHaut = LireMontant(txtPrixHaut);
                    decimal prixBas = LireMontant(txtPrixBas);
                    decimal prixMoyen = LireMontant(txtPrixMoyen);

                    if (prixBas > prixMoyen)
                        errMessage.SetError(txtPrixBas, "Le prix de la basse saison ne doit pas dépasser celui de la moyenne saison");
                    else if (prixMoyen > prixHaut)
                        errMessage.SetError(txtPrixMoyen, "Le prix de la moyenne saison ne doit pas dépasser celui de la haute saison");
                    else
                    {
                        errMessage.Clear();
                        unType.Description = description;
                        unType.PrixHaut = prixHaut;
                        unType.PrixBas = prixBas;
                        unType.PrixMoyen = prixMoyen;
                        this.Close();
                    }
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionTypeChambre_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
