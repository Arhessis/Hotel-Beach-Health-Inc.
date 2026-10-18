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
    public partial class frmConnexion : Form
    {
        private bool utilisateurConnecte = false;

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            txtUtilisateur.Focus();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            if (txtUtilisateur.Text.Trim() == string.Empty || txtMotDePasse.Text == string.Empty)
            {
                lblMessage.Text = "Veuillez entrer votre nom d'utilisateur et votre mot de passe.";
                return;
            }

            decimal noUtilisateur;
            decimal noType;
            string nom;

            try
            {
                using (SqlConnection connexion = new SqlConnection(Properties.Settings.Default.BDB56Projet1BKGConnectionString))
                using (SqlCommand commande = new SqlCommand(
                    "SELECT NoUtilisateur, Nom, NoType FROM Utilisateur WHERE Nom = @user AND MotDePasse = @password", connexion))
                {
                    commande.Parameters.AddWithValue("@user", txtUtilisateur.Text.Trim());
                    commande.Parameters.AddWithValue("@password", txtMotDePasse.Text);
                    connexion.Open();

                    using (SqlDataReader resultat = commande.ExecuteReader())
                    {
                        if (!resultat.Read())
                        {
                            lblMessage.Text = "Nom d'utilisateur ou mot de passe invalide.";
                            txtMotDePasse.Clear();
                            txtMotDePasse.Focus();
                            return;
                        }

                        noUtilisateur = Convert.ToDecimal(resultat["NoUtilisateur"]);
                        nom = resultat["Nom"].ToString();
                        noType = Convert.ToDecimal(resultat["NoType"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter à la base de données : " + ex.Message, "Erreur de connexion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultatMenu;
            this.Hide();

            if (noType == 1)
            {
                frmMenuAdmin formulaire = new frmMenuAdmin();
                formulaire.NoUtilisateur = noUtilisateur.ToString();
                formulaire.NomUtilisateur = nom;
                utilisateurConnecte = true;
                resultatMenu = formulaire.ShowDialog();
            }
            else if (noType == 2)
            {
                frmMenuPrep formulaire = new frmMenuPrep();
                formulaire.NoUtilisateur = noUtilisateur.ToString();
                formulaire.NomUtilisateur = nom;
                utilisateurConnecte = true;
                resultatMenu = formulaire.ShowDialog();
            }
            else
            {
                this.Show();
                lblMessage.Text = "Type d'utilisateur inconnu.";
                return;
            }

            if (resultatMenu == DialogResult.Abort)
            {
                this.Close();
                return;
            }

            txtUtilisateur.Clear();
            txtMotDePasse.Clear();
            lblMessage.Text = string.Empty;
            this.Show();
            txtUtilisateur.Focus();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (utilisateurConnecte)
                SauvegarderXML();
        }

        private void SauvegarderXML()
        {
            try
            {
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
                MessageBox.Show("Erreur lors de la sauvegarde XML : " + ex.Message, "Enregistrement XML",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
