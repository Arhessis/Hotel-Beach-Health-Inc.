namespace Projet1___VS
{
    partial class frmMenuAdmin
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.btnClientsInvites = new System.Windows.Forms.Button();
            this.grpClients = new System.Windows.Forms.GroupBox();
            this.btnChambres = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.grpChambres = new System.Windows.Forms.GroupBox();
            this.btnAssistants = new System.Windows.Forms.Button();
            this.btnSoins = new System.Windows.Forms.Button();
            this.btnPlanification = new System.Windows.Forms.Button();
            this.grpSoins = new System.Windows.Forms.GroupBox();
            this.btnUtilisateurs = new System.Windows.Forms.Button();
            this.btnRapports = new System.Windows.Forms.Button();
            this.grpAdministration = new System.Windows.Forms.GroupBox();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpClients.SuspendLayout();
            this.grpChambres.SuspendLayout();
            this.grpSoins.SuspendLayout();
            this.grpAdministration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(60, 40);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(567, 73);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Hôtel Plage Santé";
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(66, 120);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(165, 37);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue";
            // 
            // btnClientsInvites
            // 
            this.btnClientsInvites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsInvites.Location = new System.Drawing.Point(40, 60);
            this.btnClientsInvites.Name = "btnClientsInvites";
            this.btnClientsInvites.Size = new System.Drawing.Size(480, 80);
            this.btnClientsInvites.TabIndex = 0;
            this.btnClientsInvites.Text = "Clients et invités";
            this.btnClientsInvites.UseVisualStyleBackColor = true;
            this.btnClientsInvites.Click += new System.EventHandler(this.btnClientsInvites_Click);
            // 
            // grpClients
            // 
            this.grpClients.Controls.Add(this.btnClientsInvites);
            this.grpClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClients.Location = new System.Drawing.Point(60, 200);
            this.grpClients.Name = "grpClients";
            this.grpClients.Size = new System.Drawing.Size(560, 170);
            this.grpClients.TabIndex = 0;
            this.grpClients.TabStop = false;
            this.grpClients.Text = "Clients";
            // 
            // btnChambres
            // 
            this.btnChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChambres.Location = new System.Drawing.Point(40, 60);
            this.btnChambres.Name = "btnChambres";
            this.btnChambres.Size = new System.Drawing.Size(480, 80);
            this.btnChambres.TabIndex = 0;
            this.btnChambres.Text = "Chambres et types";
            this.btnChambres.UseVisualStyleBackColor = true;
            this.btnChambres.Click += new System.EventHandler(this.btnChambres_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.Location = new System.Drawing.Point(40, 160);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(480, 80);
            this.btnReservations.TabIndex = 1;
            this.btnReservations.Text = "Réservation des chambres";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // grpChambres
            // 
            this.grpChambres.Controls.Add(this.btnChambres);
            this.grpChambres.Controls.Add(this.btnReservations);
            this.grpChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChambres.Location = new System.Drawing.Point(60, 400);
            this.grpChambres.Name = "grpChambres";
            this.grpChambres.Size = new System.Drawing.Size(560, 270);
            this.grpChambres.TabIndex = 1;
            this.grpChambres.TabStop = false;
            this.grpChambres.Text = "Chambres";
            // 
            // btnAssistants
            // 
            this.btnAssistants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssistants.Location = new System.Drawing.Point(40, 60);
            this.btnAssistants.Name = "btnAssistants";
            this.btnAssistants.Size = new System.Drawing.Size(480, 80);
            this.btnAssistants.TabIndex = 0;
            this.btnAssistants.Text = "Assistants et leurs soins";
            this.btnAssistants.UseVisualStyleBackColor = true;
            this.btnAssistants.Click += new System.EventHandler(this.btnAssistants_Click);
            // 
            // btnSoins
            // 
            this.btnSoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoins.Location = new System.Drawing.Point(40, 160);
            this.btnSoins.Name = "btnSoins";
            this.btnSoins.Size = new System.Drawing.Size(480, 80);
            this.btnSoins.TabIndex = 1;
            this.btnSoins.Text = "Gestion des soins";
            this.btnSoins.UseVisualStyleBackColor = true;
            this.btnSoins.Click += new System.EventHandler(this.btnSoins_Click);
            // 
            // btnPlanification
            // 
            this.btnPlanification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanification.Location = new System.Drawing.Point(40, 260);
            this.btnPlanification.Name = "btnPlanification";
            this.btnPlanification.Size = new System.Drawing.Size(480, 80);
            this.btnPlanification.TabIndex = 2;
            this.btnPlanification.Text = "Planification des soins";
            this.btnPlanification.UseVisualStyleBackColor = true;
            this.btnPlanification.Click += new System.EventHandler(this.btnPlanification_Click);
            // 
            // grpSoins
            // 
            this.grpSoins.Controls.Add(this.btnAssistants);
            this.grpSoins.Controls.Add(this.btnSoins);
            this.grpSoins.Controls.Add(this.btnPlanification);
            this.grpSoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSoins.Location = new System.Drawing.Point(680, 200);
            this.grpSoins.Name = "grpSoins";
            this.grpSoins.Size = new System.Drawing.Size(560, 370);
            this.grpSoins.TabIndex = 2;
            this.grpSoins.TabStop = false;
            this.grpSoins.Text = "Soins";
            // 
            // btnUtilisateurs
            // 
            this.btnUtilisateurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilisateurs.Location = new System.Drawing.Point(40, 60);
            this.btnUtilisateurs.Name = "btnUtilisateurs";
            this.btnUtilisateurs.Size = new System.Drawing.Size(480, 80);
            this.btnUtilisateurs.TabIndex = 0;
            this.btnUtilisateurs.Text = "Gestion des utilisateurs";
            this.btnUtilisateurs.UseVisualStyleBackColor = true;
            this.btnUtilisateurs.Click += new System.EventHandler(this.btnUtilisateurs_Click);
            // 
            // btnRapports
            // 
            this.btnRapports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapports.Location = new System.Drawing.Point(40, 160);
            this.btnRapports.Name = "btnRapports";
            this.btnRapports.Size = new System.Drawing.Size(480, 80);
            this.btnRapports.TabIndex = 1;
            this.btnRapports.Text = "Visualisation des rapports";
            this.btnRapports.UseVisualStyleBackColor = true;
            this.btnRapports.Click += new System.EventHandler(this.btnRapports_Click);
            // 
            // grpAdministration
            // 
            this.grpAdministration.Controls.Add(this.btnUtilisateurs);
            this.grpAdministration.Controls.Add(this.btnRapports);
            this.grpAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdministration.Location = new System.Drawing.Point(680, 600);
            this.grpAdministration.Name = "grpAdministration";
            this.grpAdministration.Size = new System.Drawing.Size(560, 270);
            this.grpAdministration.TabIndex = 3;
            this.grpAdministration.TabStop = false;
            this.grpAdministration.Text = "Administration";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(680, 40);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(270, 80);
            this.btnDeconnexion.TabIndex = 4;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(970, 40);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(270, 80);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1300, 891);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.grpClients);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.grpChambres);
            this.Controls.Add(this.grpSoins);
            this.Controls.Add(this.grpAdministration);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hôtel Plage Santé - Menu administrateur";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.grpClients.ResumeLayout(false);
            this.grpChambres.ResumeLayout(false);
            this.grpSoins.ResumeLayout(false);
            this.grpAdministration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Button btnClientsInvites;
        private System.Windows.Forms.GroupBox grpClients;
        private System.Windows.Forms.Button btnChambres;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.GroupBox grpChambres;
        private System.Windows.Forms.Button btnAssistants;
        private System.Windows.Forms.Button btnSoins;
        private System.Windows.Forms.Button btnPlanification;
        private System.Windows.Forms.GroupBox grpSoins;
        private System.Windows.Forms.Button btnUtilisateurs;
        private System.Windows.Forms.Button btnRapports;
        private System.Windows.Forms.GroupBox grpAdministration;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnQuitter;
    }
}
