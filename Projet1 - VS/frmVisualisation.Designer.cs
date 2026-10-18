namespace Projet1___VS
{
    partial class frmVisualisation
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
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.clientTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ClientTableAdapter();
            this.inviteTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter();
            this.assistantTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.AssistantTableAdapter();
            this.soinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.SoinTableAdapter();
            this.planifSoinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.PlanifSoinTableAdapter();
            this.chambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ChambreTableAdapter();
            this.reservationChambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ReservationChambreTableAdapter();
            this.lblPersonne = new System.Windows.Forms.Label();
            this.cboPersonnes = new System.Windows.Forms.ComboBox();
            this.dgSoinsPersonne = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tabSoinsPersonne = new System.Windows.Forms.TabPage();
            this.lblChambre = new System.Windows.Forms.Label();
            this.cboChambres = new System.Windows.Forms.ComboBox();
            this.dgReservations = new System.Windows.Forms.DataGridView();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.lblAssistant = new System.Windows.Forms.Label();
            this.cboAssistants = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblSoinsJour = new System.Windows.Forms.Label();
            this.dgSoinsJour = new System.Windows.Forms.DataGridView();
            this.lblPersonnes = new System.Windows.Forms.Label();
            this.dgPersonnes = new System.Windows.Forms.DataGridView();
            this.tabSoinsAssistant = new System.Windows.Forms.TabPage();
            this.tabRapports = new System.Windows.Forms.TabControl();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoinsPersonne)).BeginInit();
            this.tabSoinsPersonne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).BeginInit();
            this.tabReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoinsJour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonnes)).BeginInit();
            this.tabSoinsAssistant.SuspendLayout();
            this.tabRapports.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // planifSoinTableAdapter
            // 
            this.planifSoinTableAdapter.ClearBeforeFill = true;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // reservationChambreTableAdapter
            // 
            this.reservationChambreTableAdapter.ClearBeforeFill = true;
            // 
            // lblPersonne
            // 
            this.lblPersonne.AutoSize = true;
            this.lblPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonne.Location = new System.Drawing.Point(30, 30);
            this.lblPersonne.Name = "lblPersonne";
            this.lblPersonne.Size = new System.Drawing.Size(243, 37);
            this.lblPersonne.TabIndex = 0;
            this.lblPersonne.Text = "Client ou invité :";
            // 
            // cboPersonnes
            // 
            this.cboPersonnes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPersonnes.FormattingEnabled = true;
            this.cboPersonnes.Location = new System.Drawing.Point(300, 25);
            this.cboPersonnes.Name = "cboPersonnes";
            this.cboPersonnes.Size = new System.Drawing.Size(800, 45);
            this.cboPersonnes.TabIndex = 0;
            this.cboPersonnes.SelectedIndexChanged += new System.EventHandler(this.cboPersonnes_SelectedIndexChanged);
            // 
            // dgSoinsPersonne
            // 
            this.dgSoinsPersonne.AllowUserToAddRows = false;
            this.dgSoinsPersonne.AllowUserToDeleteRows = false;
            this.dgSoinsPersonne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSoinsPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoinsPersonne.Location = new System.Drawing.Point(30, 100);
            this.dgSoinsPersonne.MultiSelect = false;
            this.dgSoinsPersonne.Name = "dgSoinsPersonne";
            this.dgSoinsPersonne.ReadOnly = true;
            this.dgSoinsPersonne.RowHeadersWidth = 40;
            this.dgSoinsPersonne.RowTemplate.Height = 33;
            this.dgSoinsPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSoinsPersonne.Size = new System.Drawing.Size(1660, 480);
            this.dgSoinsPersonne.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(980, 605);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(365, 37);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Montant total des soins :";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1350, 600);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(340, 44);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabSoinsPersonne
            // 
            this.tabSoinsPersonne.Controls.Add(this.lblPersonne);
            this.tabSoinsPersonne.Controls.Add(this.cboPersonnes);
            this.tabSoinsPersonne.Controls.Add(this.dgSoinsPersonne);
            this.tabSoinsPersonne.Controls.Add(this.lblTotal);
            this.tabSoinsPersonne.Controls.Add(this.txtTotal);
            this.tabSoinsPersonne.Location = new System.Drawing.Point(8, 51);
            this.tabSoinsPersonne.Name = "tabSoinsPersonne";
            this.tabSoinsPersonne.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoinsPersonne.Size = new System.Drawing.Size(1724, 688);
            this.tabSoinsPersonne.TabIndex = 0;
            this.tabSoinsPersonne.Text = "Soins par personne";
            this.tabSoinsPersonne.UseVisualStyleBackColor = true;
            // 
            // lblChambre
            // 
            this.lblChambre.AutoSize = true;
            this.lblChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChambre.Location = new System.Drawing.Point(30, 30);
            this.lblChambre.Name = "lblChambre";
            this.lblChambre.Size = new System.Drawing.Size(167, 37);
            this.lblChambre.TabIndex = 0;
            this.lblChambre.Text = "Chambre :";
            // 
            // cboChambres
            // 
            this.cboChambres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChambres.FormattingEnabled = true;
            this.cboChambres.Location = new System.Drawing.Point(300, 25);
            this.cboChambres.Name = "cboChambres";
            this.cboChambres.Size = new System.Drawing.Size(800, 45);
            this.cboChambres.TabIndex = 0;
            this.cboChambres.SelectedIndexChanged += new System.EventHandler(this.cboChambres_SelectedIndexChanged);
            // 
            // dgReservations
            // 
            this.dgReservations.AllowUserToAddRows = false;
            this.dgReservations.AllowUserToDeleteRows = false;
            this.dgReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservations.Location = new System.Drawing.Point(30, 100);
            this.dgReservations.MultiSelect = false;
            this.dgReservations.Name = "dgReservations";
            this.dgReservations.ReadOnly = true;
            this.dgReservations.RowHeadersWidth = 40;
            this.dgReservations.RowTemplate.Height = 33;
            this.dgReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservations.Size = new System.Drawing.Size(1660, 560);
            this.dgReservations.TabIndex = 1;
            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.lblChambre);
            this.tabReservations.Controls.Add(this.cboChambres);
            this.tabReservations.Controls.Add(this.dgReservations);
            this.tabReservations.Location = new System.Drawing.Point(8, 51);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(1724, 701);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "Réservations par chambre";
            this.tabReservations.UseVisualStyleBackColor = true;
            // 
            // lblAssistant
            // 
            this.lblAssistant.AutoSize = true;
            this.lblAssistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistant.Location = new System.Drawing.Point(30, 30);
            this.lblAssistant.Name = "lblAssistant";
            this.lblAssistant.Size = new System.Drawing.Size(166, 37);
            this.lblAssistant.TabIndex = 0;
            this.lblAssistant.Text = "Assistant :";
            // 
            // cboAssistants
            // 
            this.cboAssistants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssistants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAssistants.FormattingEnabled = true;
            this.cboAssistants.Location = new System.Drawing.Point(300, 25);
            this.cboAssistants.Name = "cboAssistants";
            this.cboAssistants.Size = new System.Drawing.Size(640, 45);
            this.cboAssistants.TabIndex = 0;
            this.cboAssistants.SelectedIndexChanged += new System.EventHandler(this.cboAssistants_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1000, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(102, 37);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date :";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(1100, 25);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(400, 44);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblSoinsJour
            // 
            this.lblSoinsJour.AutoSize = true;
            this.lblSoinsJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoinsJour.Location = new System.Drawing.Point(30, 95);
            this.lblSoinsJour.Name = "lblSoinsJour";
            this.lblSoinsJour.Size = new System.Drawing.Size(195, 37);
            this.lblSoinsJour.TabIndex = 0;
            this.lblSoinsJour.Text = "Soins offerts";
            // 
            // dgSoinsJour
            // 
            this.dgSoinsJour.AllowUserToAddRows = false;
            this.dgSoinsJour.AllowUserToDeleteRows = false;
            this.dgSoinsJour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSoinsJour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoinsJour.Location = new System.Drawing.Point(30, 140);
            this.dgSoinsJour.MultiSelect = false;
            this.dgSoinsJour.Name = "dgSoinsJour";
            this.dgSoinsJour.ReadOnly = true;
            this.dgSoinsJour.RowHeadersWidth = 40;
            this.dgSoinsJour.RowTemplate.Height = 33;
            this.dgSoinsJour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSoinsJour.Size = new System.Drawing.Size(600, 520);
            this.dgSoinsJour.TabIndex = 2;
            this.dgSoinsJour.SelectionChanged += new System.EventHandler(this.dgSoinsJour_SelectionChanged);
            // 
            // lblPersonnes
            // 
            this.lblPersonnes.AutoSize = true;
            this.lblPersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnes.Location = new System.Drawing.Point(660, 95);
            this.lblPersonnes.Name = "lblPersonnes";
            this.lblPersonnes.Size = new System.Drawing.Size(196, 37);
            this.lblPersonnes.TabIndex = 0;
            this.lblPersonnes.Text = "Soins clients";
            // 
            // dgPersonnes
            // 
            this.dgPersonnes.AllowUserToAddRows = false;
            this.dgPersonnes.AllowUserToDeleteRows = false;
            this.dgPersonnes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonnes.Location = new System.Drawing.Point(660, 140);
            this.dgPersonnes.MultiSelect = false;
            this.dgPersonnes.Name = "dgPersonnes";
            this.dgPersonnes.ReadOnly = true;
            this.dgPersonnes.RowHeadersWidth = 40;
            this.dgPersonnes.RowTemplate.Height = 33;
            this.dgPersonnes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPersonnes.Size = new System.Drawing.Size(1030, 520);
            this.dgPersonnes.TabIndex = 3;
            // 
            // tabSoinsAssistant
            // 
            this.tabSoinsAssistant.Controls.Add(this.lblAssistant);
            this.tabSoinsAssistant.Controls.Add(this.cboAssistants);
            this.tabSoinsAssistant.Controls.Add(this.lblDate);
            this.tabSoinsAssistant.Controls.Add(this.dtpDate);
            this.tabSoinsAssistant.Controls.Add(this.lblSoinsJour);
            this.tabSoinsAssistant.Controls.Add(this.dgSoinsJour);
            this.tabSoinsAssistant.Controls.Add(this.lblPersonnes);
            this.tabSoinsAssistant.Controls.Add(this.dgPersonnes);
            this.tabSoinsAssistant.Location = new System.Drawing.Point(8, 51);
            this.tabSoinsAssistant.Name = "tabSoinsAssistant";
            this.tabSoinsAssistant.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoinsAssistant.Size = new System.Drawing.Size(1724, 701);
            this.tabSoinsAssistant.TabIndex = 2;
            this.tabSoinsAssistant.Text = "Soins journaliers d\'un assistant";
            this.tabSoinsAssistant.UseVisualStyleBackColor = true;
            // 
            // tabRapports
            // 
            this.tabRapports.Controls.Add(this.tabSoinsPersonne);
            this.tabRapports.Controls.Add(this.tabReservations);
            this.tabRapports.Controls.Add(this.tabSoinsAssistant);
            this.tabRapports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRapports.Location = new System.Drawing.Point(30, 97);
            this.tabRapports.Name = "tabRapports";
            this.tabRapports.SelectedIndex = 0;
            this.tabRapports.Size = new System.Drawing.Size(1740, 747);
            this.tabRapports.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.CausesValidation = false;
            this.btnFermer.Location = new System.Drawing.Point(1522, 21);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(240, 57);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Quitter";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmVisualisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 887);
            this.Controls.Add(this.tabRapports);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmVisualisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualisation des rapports";
            this.Load += new System.EventHandler(this.Visualisation_Load);
            this.VisibleChanged += new System.EventHandler(this.Visualisation_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoinsPersonne)).EndInit();
            this.tabSoinsPersonne.ResumeLayout(false);
            this.tabSoinsPersonne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).EndInit();
            this.tabReservations.ResumeLayout(false);
            this.tabReservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoinsJour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonnes)).EndInit();
            this.tabSoinsAssistant.ResumeLayout(false);
            this.tabSoinsAssistant.PerformLayout();
            this.tabRapports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private BDB56Projet1BKGDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter inviteTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.AssistantTableAdapter assistantTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.PlanifSoinTableAdapter planifSoinTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.ChambreTableAdapter chambreTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.ReservationChambreTableAdapter reservationChambreTableAdapter;
        private System.Windows.Forms.Label lblPersonne;
        private System.Windows.Forms.ComboBox cboPersonnes;
        private System.Windows.Forms.DataGridView dgSoinsPersonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDescriptionSoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateHeureSoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrixSoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtAssistant;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TabPage tabSoinsPersonne;
        private System.Windows.Forms.Label lblChambre;
        private System.Windows.Forms.ComboBox cboChambres;
        private System.Windows.Forms.DataGridView dgReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNbPersonnes;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.Label lblAssistant;
        private System.Windows.Forms.ComboBox cboAssistants;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblSoinsJour;
        private System.Windows.Forms.DataGridView dgSoinsJour;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoSoinJour;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDescriptionJour;
        private System.Windows.Forms.Label lblPersonnes;
        private System.Windows.Forms.DataGridView dgPersonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDescriptionPers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDateHeurePers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPersonne;
        private System.Windows.Forms.TabPage tabSoinsAssistant;
        private System.Windows.Forms.TabControl tabRapports;
        private System.Windows.Forms.Button btnFermer;
    }
}
