namespace Projet1___VS
{
    partial class frmConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(60, 40);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(200, 37);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Hôtel Plage Santé";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.Location = new System.Drawing.Point(66, 120);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(200, 37);
            this.lblSousTitre.TabIndex = 0;
            this.lblSousTitre.Text = "Connexion";
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilisateur.Location = new System.Drawing.Point(66, 220);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(200, 37);
            this.lblUtilisateur.TabIndex = 0;
            this.lblUtilisateur.Text = "Nom d\'utilisateur";
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilisateur.Location = new System.Drawing.Point(66, 262);
            this.txtUtilisateur.MaxLength = 50;
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(768, 44);
            this.txtUtilisateur.TabIndex = 0;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotDePasse.Location = new System.Drawing.Point(66, 330);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(200, 37);
            this.lblMotDePasse.TabIndex = 0;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotDePasse.Location = new System.Drawing.Point(66, 372);
            this.txtMotDePasse.MaxLength = 50;
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(768, 44);
            this.txtMotDePasse.UseSystemPasswordChar = true;
            this.txtMotDePasse.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(66, 440);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(200, 37);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(66, 500);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(376, 80);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.CausesValidation = false;
            this.btnQuitter.Location = new System.Drawing.Point(458, 500);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(376, 80);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Connexion
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.lblUtilisateur);
            this.Controls.Add(this.txtUtilisateur);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.btnQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hôtel Plage Santé - Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connexion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnQuitter;
    }
}
