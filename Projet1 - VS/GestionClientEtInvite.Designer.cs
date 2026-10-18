namespace Projet1___VS
{
    partial class GestionClientEtInvite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ClientTableAdapter();
            this.inviteTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter();
            this.reservationChambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ReservationChambreTableAdapter();
            this.planifSoinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.PlanifSoinTableAdapter();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblClients = new System.Windows.Forms.Label();
            this.lblInvites = new System.Windows.Forms.Label();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.dgTxtNoClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDateInscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInvites = new System.Windows.Forms.DataGridView();
            this.dgTxtNoInvite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNomPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtNoClientInvite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClientPrecedent = new System.Windows.Forms.Button();
            this.btnClientSuivant = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnInvitePrecedent = new System.Windows.Forms.Button();
            this.btnInviteSuivant = new System.Windows.Forms.Button();
            this.btnAjouterInvite = new System.Windows.Forms.Button();
            this.btnModifierInvite = new System.Windows.Forms.Button();
            this.btnSupprimerInvite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvites)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "fk_Invite_Client";
            this.inviteBindingSource.DataSource = this.clientBindingSource;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // reservationChambreTableAdapter
            // 
            this.reservationChambreTableAdapter.ClearBeforeFill = true;
            // 
            // planifSoinTableAdapter
            // 
            this.planifSoinTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(32, 14);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(200, 37);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Clients et invités";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.Location = new System.Drawing.Point(40, 95);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(200, 37);
            this.lblSousTitre.TabIndex = 0;
            this.lblSousTitre.Text = "Sélectionnez un client pour afficher ses invités (maximum 9 par client)";
            // 
            // btnFermer
            // 
            this.btnFermer.CausesValidation = false;
            this.btnFermer.Location = new System.Drawing.Point(1960, 30);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(200, 80);
            this.btnFermer.TabIndex = 20;
            this.btnFermer.Text = "Quitter";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(32, 160);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(200, 37);
            this.lblClients.TabIndex = 0;
            this.lblClients.Text = "Clients";
            // 
            // lblInvites
            // 
            this.lblInvites.AutoSize = true;
            this.lblInvites.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvites.Location = new System.Drawing.Point(1432, 160);
            this.lblInvites.Name = "lblInvites";
            this.lblInvites.Size = new System.Drawing.Size(200, 37);
            this.lblInvites.TabIndex = 0;
            this.lblInvites.Text = "Invités du client sélectionné";
            // 
            // dgClients
            // 
            this.dgClients.AllowUserToAddRows = false;
            this.dgClients.AllowUserToDeleteRows = false;
            this.dgClients.AutoGenerateColumns = false;
            this.dgClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoClient,
            this.dgTxtNom,
            this.dgTxtPrenom,
            this.dgTxtVille,
            this.dgTxtPays,
            this.dgTxtAdresse,
            this.dgTxtCodePostal,
            this.dgTxtDateInscription});
            this.dgClients.DataSource = this.clientBindingSource;
            this.dgClients.Location = new System.Drawing.Point(40, 230);
            this.dgClients.MultiSelect = false;
            this.dgClients.Name = "dgClients";
            this.dgClients.ReadOnly = true;
            this.dgClients.RowHeadersWidth = 40;
            this.dgClients.RowTemplate.Height = 33;
            this.dgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClients.Size = new System.Drawing.Size(1360, 690);
            this.dgClients.TabIndex = 1;
            // 
            // dgTxtNoClient
            // 
            this.dgTxtNoClient.DataPropertyName = "NoClient";
            this.dgTxtNoClient.FillWeight = 50F;
            this.dgTxtNoClient.HeaderText = "No";
            this.dgTxtNoClient.MinimumWidth = 10;
            this.dgTxtNoClient.Name = "dgTxtNoClient";
            this.dgTxtNoClient.ReadOnly = true;
            // 
            // dgTxtNom
            // 
            this.dgTxtNom.DataPropertyName = "Nom";
            this.dgTxtNom.HeaderText = "Nom";
            this.dgTxtNom.MinimumWidth = 10;
            this.dgTxtNom.Name = "dgTxtNom";
            this.dgTxtNom.ReadOnly = true;
            // 
            // dgTxtPrenom
            // 
            this.dgTxtPrenom.DataPropertyName = "Prenom";
            this.dgTxtPrenom.HeaderText = "Prénom";
            this.dgTxtPrenom.MinimumWidth = 10;
            this.dgTxtPrenom.Name = "dgTxtPrenom";
            this.dgTxtPrenom.ReadOnly = true;
            // 
            // dgTxtVille
            // 
            this.dgTxtVille.DataPropertyName = "Ville";
            this.dgTxtVille.HeaderText = "Ville";
            this.dgTxtVille.MinimumWidth = 10;
            this.dgTxtVille.Name = "dgTxtVille";
            this.dgTxtVille.ReadOnly = true;
            // 
            // dgTxtPays
            // 
            this.dgTxtPays.DataPropertyName = "Pays";
            this.dgTxtPays.HeaderText = "Pays";
            this.dgTxtPays.MinimumWidth = 10;
            this.dgTxtPays.Name = "dgTxtPays";
            this.dgTxtPays.ReadOnly = true;
            // 
            // dgTxtAdresse
            // 
            this.dgTxtAdresse.DataPropertyName = "Adresse";
            this.dgTxtAdresse.FillWeight = 150F;
            this.dgTxtAdresse.HeaderText = "Adresse";
            this.dgTxtAdresse.MinimumWidth = 10;
            this.dgTxtAdresse.Name = "dgTxtAdresse";
            this.dgTxtAdresse.ReadOnly = true;
            // 
            // dgTxtCodePostal
            // 
            this.dgTxtCodePostal.DataPropertyName = "CodePostal";
            this.dgTxtCodePostal.FillWeight = 80F;
            this.dgTxtCodePostal.HeaderText = "Code postal";
            this.dgTxtCodePostal.MinimumWidth = 10;
            this.dgTxtCodePostal.Name = "dgTxtCodePostal";
            this.dgTxtCodePostal.ReadOnly = true;
            // 
            // dgTxtDateInscription
            // 
            this.dgTxtDateInscription.DataPropertyName = "DateInscription";
            dataGridViewCellStyle1.Format = "yyyy-MM-dd";
            this.dgTxtDateInscription.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgTxtDateInscription.HeaderText = "Inscription";
            this.dgTxtDateInscription.MinimumWidth = 10;
            this.dgTxtDateInscription.Name = "dgTxtDateInscription";
            this.dgTxtDateInscription.ReadOnly = true;
            // 
            // dgInvites
            // 
            this.dgInvites.AllowUserToAddRows = false;
            this.dgInvites.AllowUserToDeleteRows = false;
            this.dgInvites.AutoGenerateColumns = false;
            this.dgInvites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInvites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoInvite,
            this.dgTxtNomPrenom,
            this.dgTxtNoClientInvite});
            this.dgInvites.DataSource = this.inviteBindingSource;
            this.dgInvites.Location = new System.Drawing.Point(1440, 230);
            this.dgInvites.MultiSelect = false;
            this.dgInvites.Name = "dgInvites";
            this.dgInvites.ReadOnly = true;
            this.dgInvites.RowHeadersWidth = 40;
            this.dgInvites.RowTemplate.Height = 33;
            this.dgInvites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInvites.Size = new System.Drawing.Size(720, 690);
            this.dgInvites.TabIndex = 7;
            // 
            // dgTxtNoInvite
            // 
            this.dgTxtNoInvite.DataPropertyName = "NoInvite";
            this.dgTxtNoInvite.FillWeight = 60F;
            this.dgTxtNoInvite.HeaderText = "No invité";
            this.dgTxtNoInvite.MinimumWidth = 10;
            this.dgTxtNoInvite.Name = "dgTxtNoInvite";
            this.dgTxtNoInvite.ReadOnly = true;
            // 
            // dgTxtNomPrenom
            // 
            this.dgTxtNomPrenom.DataPropertyName = "NomPrenom";
            this.dgTxtNomPrenom.FillWeight = 160F;
            this.dgTxtNomPrenom.HeaderText = "Nom et prénom";
            this.dgTxtNomPrenom.MinimumWidth = 10;
            this.dgTxtNomPrenom.Name = "dgTxtNomPrenom";
            this.dgTxtNomPrenom.ReadOnly = true;
            // 
            // dgTxtNoClientInvite
            // 
            this.dgTxtNoClientInvite.DataPropertyName = "NoClient";
            this.dgTxtNoClientInvite.FillWeight = 60F;
            this.dgTxtNoClientInvite.HeaderText = "No client";
            this.dgTxtNoClientInvite.MinimumWidth = 10;
            this.dgTxtNoClientInvite.Name = "dgTxtNoClientInvite";
            this.dgTxtNoClientInvite.ReadOnly = true;
            // 
            // btnClientPrecedent
            // 
            this.btnClientPrecedent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientPrecedent.Location = new System.Drawing.Point(40, 945);
            this.btnClientPrecedent.Name = "btnClientPrecedent";
            this.btnClientPrecedent.Size = new System.Drawing.Size(160, 80);
            this.btnClientPrecedent.TabIndex = 2;
            this.btnClientPrecedent.Text = "<--";
            this.btnClientPrecedent.UseVisualStyleBackColor = true;
            this.btnClientPrecedent.Click += new System.EventHandler(this.btnClientPrecedent_Click);
            // 
            // btnClientSuivant
            // 
            this.btnClientSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSuivant.Location = new System.Drawing.Point(210, 945);
            this.btnClientSuivant.Name = "btnClientSuivant";
            this.btnClientSuivant.Size = new System.Drawing.Size(160, 80);
            this.btnClientSuivant.TabIndex = 3;
            this.btnClientSuivant.Text = "-->";
            this.btnClientSuivant.UseVisualStyleBackColor = true;
            this.btnClientSuivant.Click += new System.EventHandler(this.btnClientSuivant_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(740, 945);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(210, 80);
            this.btnAjouterClient.TabIndex = 4;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(965, 945);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(210, 80);
            this.btnModifierClient.TabIndex = 5;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(1190, 945);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(210, 80);
            this.btnSupprimerClient.TabIndex = 6;
            this.btnSupprimerClient.Text = "Supprimer";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnInvitePrecedent
            // 
            this.btnInvitePrecedent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvitePrecedent.Location = new System.Drawing.Point(1440, 945);
            this.btnInvitePrecedent.Name = "btnInvitePrecedent";
            this.btnInvitePrecedent.Size = new System.Drawing.Size(120, 80);
            this.btnInvitePrecedent.TabIndex = 8;
            this.btnInvitePrecedent.Text = "<--";
            this.btnInvitePrecedent.UseVisualStyleBackColor = true;
            this.btnInvitePrecedent.Click += new System.EventHandler(this.btnInvitePrecedent_Click);
            // 
            // btnInviteSuivant
            // 
            this.btnInviteSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInviteSuivant.Location = new System.Drawing.Point(1570, 945);
            this.btnInviteSuivant.Name = "btnInviteSuivant";
            this.btnInviteSuivant.Size = new System.Drawing.Size(120, 80);
            this.btnInviteSuivant.TabIndex = 9;
            this.btnInviteSuivant.Text = "-->";
            this.btnInviteSuivant.UseVisualStyleBackColor = true;
            this.btnInviteSuivant.Click += new System.EventHandler(this.btnInviteSuivant_Click);
            // 
            // btnAjouterInvite
            // 
            this.btnAjouterInvite.Location = new System.Drawing.Point(1730, 945);
            this.btnAjouterInvite.Name = "btnAjouterInvite";
            this.btnAjouterInvite.Size = new System.Drawing.Size(140, 80);
            this.btnAjouterInvite.TabIndex = 10;
            this.btnAjouterInvite.Text = "Ajouter";
            this.btnAjouterInvite.UseVisualStyleBackColor = true;
            this.btnAjouterInvite.Click += new System.EventHandler(this.btnAjouterInvite_Click);
            // 
            // btnModifierInvite
            // 
            this.btnModifierInvite.Location = new System.Drawing.Point(1875, 945);
            this.btnModifierInvite.Name = "btnModifierInvite";
            this.btnModifierInvite.Size = new System.Drawing.Size(140, 80);
            this.btnModifierInvite.TabIndex = 11;
            this.btnModifierInvite.Text = "Modifier";
            this.btnModifierInvite.UseVisualStyleBackColor = true;
            this.btnModifierInvite.Click += new System.EventHandler(this.btnModifierInvite_Click);
            // 
            // btnSupprimerInvite
            // 
            this.btnSupprimerInvite.Location = new System.Drawing.Point(2020, 945);
            this.btnSupprimerInvite.Name = "btnSupprimerInvite";
            this.btnSupprimerInvite.Size = new System.Drawing.Size(140, 80);
            this.btnSupprimerInvite.TabIndex = 12;
            this.btnSupprimerInvite.Text = "Supprimer";
            this.btnSupprimerInvite.UseVisualStyleBackColor = true;
            this.btnSupprimerInvite.Click += new System.EventHandler(this.btnSupprimerInvite_Click);
            // 
            // GestionClientEtInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2200, 1065);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.lblInvites);
            this.Controls.Add(this.dgClients);
            this.Controls.Add(this.dgInvites);
            this.Controls.Add(this.btnClientPrecedent);
            this.Controls.Add(this.btnClientSuivant);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnInvitePrecedent);
            this.Controls.Add(this.btnInviteSuivant);
            this.Controls.Add(this.btnAjouterInvite);
            this.Controls.Add(this.btnModifierInvite);
            this.Controls.Add(this.btnSupprimerInvite);
            this.Name = "GestionClientEtInvite";
            this.Text = "Gestion des clients et invités";
            this.Load += new System.EventHandler(this.GestionClientEtInvite_Load);
            this.VisibleChanged += new System.EventHandler(this.GestionClientEtInvite_VisibleChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionClientEtInvite_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter inviteTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.ReservationChambreTableAdapter reservationChambreTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.PlanifSoinTableAdapter planifSoinTableAdapter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Label lblInvites;
        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtCodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateInscription;
        private System.Windows.Forms.DataGridView dgInvites;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoInvite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNomPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoClientInvite;
        private System.Windows.Forms.Button btnClientPrecedent;
        private System.Windows.Forms.Button btnClientSuivant;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnInvitePrecedent;
        private System.Windows.Forms.Button btnInviteSuivant;
        private System.Windows.Forms.Button btnAjouterInvite;
        private System.Windows.Forms.Button btnModifierInvite;
        private System.Windows.Forms.Button btnSupprimerInvite;
    }
}
