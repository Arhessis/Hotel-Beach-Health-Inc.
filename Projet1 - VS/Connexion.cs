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
        public partial class Connexion : Form
        {
            public Connexion()
            {
                InitializeComponent();
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                string chaineConnexion = "Data Source=424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet1BKG;Persist Security Info=True;User ID=B56Projet1BKG;Password=Password-BKG;TrustServerCertificate=True";

                SqlConnection connexion = new SqlConnection(chaineConnexion);

                SqlCommand commande = new SqlCommand(
                    "SELECT NoUtilisateur, NoType FROM Utilisateur WHERE Nom = @user AND MotDePasse = @password",
                    connexion
                );

                commande.Parameters.AddWithValue("@user", txtUtilisateur.Text);
                commande.Parameters.AddWithValue("@password", txtMotDePasse.Text);

                connexion.Open();

                SqlDataReader resultat = commande.ExecuteReader();

                if (resultat.Read())
                {
                    int NoUtilisateur = Convert.ToInt32(resultat["NoUtilisateur"]);
                    int NoType = Convert.ToInt32(resultat["NoType"]);

                    ConnexionMarche.Text = "Connexion réussie";

                //case 1
                if (NoType == 1)
                {
                    MenuAdmin formulaire = new MenuAdmin();
                    formulaire.NoUtilisateur = NoUtilisateur.ToString();
                    formulaire.ShowDialog();
                }

                //case 2
                if (NoType == 2)
                {
                    MenuPrep formulaire = new MenuPrep();
                    formulaire.NoUtilisateur = NoUtilisateur.ToString();
                    formulaire.ShowDialog();
                }

            }
                else
                {
                    ConnexionMarche.Text = "Connexion échouée";
                }

            }
        }
    }


