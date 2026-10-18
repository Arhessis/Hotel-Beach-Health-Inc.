namespace Projet1___VS
{
    partial class PlannificationSoin
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
            System.Windows.Forms.Label noPersonneLabel;
            System.Windows.Forms.Label noAssistantLabel;
            System.Windows.Forms.Label dateHeureLabel;
            System.Windows.Forms.Label noSoinLabel;
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.planifSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planifSoinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.PlanifSoinTableAdapter();
            this.tableAdapterManager = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager();
            this.cboNoPersonne = new System.Windows.Forms.ComboBox();
            this.cboNoAssistant = new System.Windows.Forms.ComboBox();
            this.cboNoSoin = new System.Windows.Forms.ComboBox();
            this.dtpDateHeure = new System.Windows.Forms.DateTimePicker();
            this.planifSoinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ClientTableAdapter();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inviteTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.SoinTableAdapter();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.AssistantTableAdapter();
            this.assistantSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.AssistantSoinTableAdapter();
            noPersonneLabel = new System.Windows.Forms.Label();
            noAssistantLabel = new System.Windows.Forms.Label();
            dateHeureLabel = new System.Windows.Forms.Label();
            noSoinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noPersonneLabel
            // 
            noPersonneLabel.AutoSize = true;
            noPersonneLabel.Location = new System.Drawing.Point(14, 82);
            noPersonneLabel.Name = "noPersonneLabel";
            noPersonneLabel.Size = new System.Drawing.Size(72, 13);
            noPersonneLabel.TabIndex = 1;
            noPersonneLabel.Text = "No Personne:";
            // 
            // noAssistantLabel
            // 
            noAssistantLabel.AutoSize = true;
            noAssistantLabel.Location = new System.Drawing.Point(14, 109);
            noAssistantLabel.Name = "noAssistantLabel";
            noAssistantLabel.Size = new System.Drawing.Size(69, 13);
            noAssistantLabel.TabIndex = 3;
            noAssistantLabel.Text = "No Assistant:";
            // 
            // dateHeureLabel
            // 
            dateHeureLabel.AutoSize = true;
            dateHeureLabel.Location = new System.Drawing.Point(14, 137);
            dateHeureLabel.Name = "dateHeureLabel";
            dateHeureLabel.Size = new System.Drawing.Size(65, 13);
            dateHeureLabel.TabIndex = 5;
            dateHeureLabel.Text = "Date Heure:";
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Location = new System.Drawing.Point(14, 162);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(48, 13);
            noSoinLabel.TabIndex = 7;
            noSoinLabel.Text = "No Soin:";
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planifSoinBindingSource
            // 
            this.planifSoinBindingSource.DataMember = "PlanifSoin";
            this.planifSoinBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // planifSoinTableAdapter
            // 
            this.planifSoinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = this.planifSoinTableAdapter;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // cboNoPersonne
            // 
            this.cboNoPersonne.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planifSoinBindingSource, "NoPersonne", true));
            this.cboNoPersonne.FormattingEnabled = true;
            this.cboNoPersonne.Location = new System.Drawing.Point(92, 79);
            this.cboNoPersonne.Name = "cboNoPersonne";
            this.cboNoPersonne.Size = new System.Drawing.Size(173, 21);
            this.cboNoPersonne.TabIndex = 2;
            // 
            // cboNoAssistant
            // 
            this.cboNoAssistant.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planifSoinBindingSource, "NoAssistant", true));
            this.cboNoAssistant.Location = new System.Drawing.Point(92, 106);
            this.cboNoAssistant.Name = "cboNoAssistant";
            this.cboNoAssistant.Size = new System.Drawing.Size(173, 21);
            this.cboNoAssistant.TabIndex = 4;
            // 
            // cboNoSoin
            // 
            this.cboNoSoin.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planifSoinBindingSource, "NoSoin", true));
            this.cboNoSoin.FormattingEnabled = true;
            this.cboNoSoin.Location = new System.Drawing.Point(92, 159);
            this.cboNoSoin.Name = "cboNoSoin";
            this.cboNoSoin.Size = new System.Drawing.Size(173, 21);
            this.cboNoSoin.TabIndex = 8;
            // 
            // dtpDateHeure
            // 
            this.dtpDateHeure.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDateHeure.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.planifSoinBindingSource, "DateHeure", true));
            this.dtpDateHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateHeure.Location = new System.Drawing.Point(92, 133);
            this.dtpDateHeure.Name = "dtpDateHeure";
            this.dtpDateHeure.Size = new System.Drawing.Size(173, 20);
            this.dtpDateHeure.TabIndex = 6;
            // 
            // planifSoinDataGridView
            // 
            this.planifSoinDataGridView.AutoGenerateColumns = false;
            this.planifSoinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planifSoinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.planifSoinDataGridView.DataSource = this.planifSoinBindingSource;
            this.planifSoinDataGridView.Location = new System.Drawing.Point(12, 203);
            this.planifSoinDataGridView.Name = "planifSoinDataGridView";
            this.planifSoinDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.planifSoinDataGridView.Size = new System.Drawing.Size(443, 220);
            this.planifSoinDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoPersonne";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoPersonne";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NoAssistant";
            this.dataGridViewTextBoxColumn2.HeaderText = "NoAssistant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateHeure";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateHeure";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoSoin";
            this.dataGridViewTextBoxColumn4.HeaderText = "NoSoin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskervville", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plannification des soins";
            // 
            // btnFermer
            // 
            this.btnFermer.CausesValidation = false;
            this.btnFermer.Location = new System.Drawing.Point(379, 147);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(81, 29);
            this.btnFermer.TabIndex = 23;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Location = new System.Drawing.Point(292, 147);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 30);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(379, 109);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(81, 30);
            this.btnEnregistrer.TabIndex = 21;
            this.btnEnregistrer.Text = "Enregister";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(292, 108);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(81, 33);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(292, 70);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(81, 32);
            this.btnAjouter.TabIndex = 19;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "Invite";
            this.inviteBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "Soin";
            this.soinBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "Assistant";
            this.assistantBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // assistantSoinBindingSource
            // 
            this.assistantSoinBindingSource.DataMember = "AssistantSoin";
            this.assistantSoinBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // assistantSoinTableAdapter
            // 
            this.assistantSoinTableAdapter.ClearBeforeFill = true;
            // 
            // PlannificationSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 441);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planifSoinDataGridView);
            this.Controls.Add(noPersonneLabel);
            this.Controls.Add(this.cboNoPersonne);
            this.Controls.Add(noAssistantLabel);
            this.Controls.Add(this.cboNoAssistant);
            this.Controls.Add(dateHeureLabel);
            this.Controls.Add(this.dtpDateHeure);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.cboNoSoin);
            this.Name = "PlannificationSoin";
            this.Text = "PlannificationSoin";
            this.Load += new System.EventHandler(this.PlannificationSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource planifSoinBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.PlanifSoinTableAdapter planifSoinTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboNoPersonne;
        private System.Windows.Forms.ComboBox cboNoAssistant;
        private System.Windows.Forms.ComboBox cboNoSoin;
        private System.Windows.Forms.DateTimePicker dtpDateHeure;
        private System.Windows.Forms.DataGridView planifSoinDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter inviteTableAdapter;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.AssistantTableAdapter assistantTableAdapter;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.AssistantSoinTableAdapter assistantSoinTableAdapter;
    }
}