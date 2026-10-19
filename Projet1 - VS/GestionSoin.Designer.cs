namespace Projet1___VS
{
    partial class GestionSoin
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
            System.Windows.Forms.Label noSoinLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label noTypeSoinLabel;
            System.Windows.Forms.Label prixLabel;
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.SoinTableAdapter();
            this.tableAdapterManager = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager();
            this.assistantSoinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.AssistantSoinTableAdapter();
            this.typeSoinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TypeSoinTableAdapter();
            this.noSoinTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dureeTextBox = new System.Windows.Forms.TextBox();
            this.noTypeSoinComboBox = new System.Windows.Forms.ComboBox();
            this.typeSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.assistantSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.planifSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planifSoinTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.PlanifSoinTableAdapter();
            this.soinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTypePrecedent = new System.Windows.Forms.Button();
            this.btnTypeSuivant = new System.Windows.Forms.Button();
            noSoinLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            noTypeSoinLabel = new System.Windows.Forms.Label();
            prixLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Location = new System.Drawing.Point(13, 98);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(48, 13);
            noSoinLabel.TabIndex = 1;
            noSoinLabel.Text = "No Soin:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(13, 124);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Location = new System.Drawing.Point(13, 150);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(39, 13);
            dureeLabel.TabIndex = 5;
            dureeLabel.Text = "Duree:";
            // 
            // noTypeSoinLabel
            // 
            noTypeSoinLabel.AutoSize = true;
            noTypeSoinLabel.Location = new System.Drawing.Point(13, 176);
            noTypeSoinLabel.Name = "noTypeSoinLabel";
            noTypeSoinLabel.Size = new System.Drawing.Size(75, 13);
            noTypeSoinLabel.TabIndex = 7;
            noTypeSoinLabel.Text = "No Type Soin:";
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Location = new System.Drawing.Point(13, 203);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(27, 13);
            prixLabel.TabIndex = 9;
            prixLabel.Text = "Prix:";
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = this.assistantSoinTableAdapter;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = this.soinTableAdapter;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = this.typeSoinTableAdapter;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // assistantSoinTableAdapter
            // 
            this.assistantSoinTableAdapter.ClearBeforeFill = true;
            // 
            // typeSoinTableAdapter
            // 
            this.typeSoinTableAdapter.ClearBeforeFill = true;
            // 
            // noSoinTextBox
            // 
            this.noSoinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soinBindingSource, "NoSoin", true));
            this.noSoinTextBox.Location = new System.Drawing.Point(94, 95);
            this.noSoinTextBox.Name = "noSoinTextBox";
            this.noSoinTextBox.ReadOnly = true;
            this.noSoinTextBox.Size = new System.Drawing.Size(121, 20);
            this.noSoinTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soinBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(94, 121);
            this.descriptionTextBox.MaxLength = 50;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // dureeTextBox
            // 
            this.dureeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soinBindingSource, "Duree", true));
            this.dureeTextBox.Location = new System.Drawing.Point(94, 147);
            this.dureeTextBox.Name = "dureeTextBox";
            this.dureeTextBox.ReadOnly = true;
            this.dureeTextBox.Size = new System.Drawing.Size(121, 20);
            this.dureeTextBox.TabIndex = 6;
            // 
            // noTypeSoinComboBox
            // 
            this.noTypeSoinComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soinBindingSource, "NoTypeSoin", true));
            this.noTypeSoinComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soinBindingSource, "NoTypeSoin", true));
            this.noTypeSoinComboBox.DataSource = this.typeSoinBindingSource;
            this.noTypeSoinComboBox.DisplayMember = "Description";
            this.noTypeSoinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noTypeSoinComboBox.FormattingEnabled = true;
            this.noTypeSoinComboBox.Location = new System.Drawing.Point(94, 173);
            this.noTypeSoinComboBox.Name = "noTypeSoinComboBox";
            this.noTypeSoinComboBox.Size = new System.Drawing.Size(121, 21);
            this.noTypeSoinComboBox.TabIndex = 8;
            this.noTypeSoinComboBox.ValueMember = "NoTypeSoin";
            // 
            // typeSoinBindingSource
            // 
            this.typeSoinBindingSource.DataMember = "TypeSoin";
            this.typeSoinBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // prixTextBox
            // 
            this.prixTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soinBindingSource, "Prix", true));
            this.prixTextBox.Location = new System.Drawing.Point(94, 200);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(121, 20);
            this.prixTextBox.TabIndex = 10;
            // 
            // assistantSoinBindingSource
            // 
            this.assistantSoinBindingSource.DataMember = "AssistantSoin";
            this.assistantSoinBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // btnFermer
            // 
            this.btnFermer.CausesValidation = false;
            this.btnFermer.Location = new System.Drawing.Point(474, 182);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(81, 29);
            this.btnFermer.TabIndex = 24;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Location = new System.Drawing.Point(387, 182);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 30);
            this.btnAnnuler.TabIndex = 23;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(474, 144);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(81, 30);
            this.btnEnregistrer.TabIndex = 22;
            this.btnEnregistrer.Text = "Enregister";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(387, 143);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(81, 33);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(474, 105);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(81, 32);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(387, 105);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(81, 32);
            this.btnAjouter.TabIndex = 19;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskervville", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gestion des soins";
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
            // soinDataGridView
            // 
            this.soinDataGridView.AutoGenerateColumns = false;
            this.soinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.soinDataGridView.DataSource = this.soinBindingSource;
            this.soinDataGridView.Location = new System.Drawing.Point(12, 226);
            this.soinDataGridView.Name = "soinDataGridView";
            this.soinDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.soinDataGridView.Size = new System.Drawing.Size(543, 220);
            this.soinDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoSoin";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoSoin";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Duree";
            this.dataGridViewTextBoxColumn3.HeaderText = "Duree";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoTypeSoin";
            this.dataGridViewTextBoxColumn4.HeaderText = "NoTypeSoin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnTypePrecedent
            // 
            this.btnTypePrecedent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypePrecedent.Location = new System.Drawing.Point(16, 477);
            this.btnTypePrecedent.Margin = new System.Windows.Forms.Padding(2);
            this.btnTypePrecedent.Name = "btnTypePrecedent";
            this.btnTypePrecedent.Size = new System.Drawing.Size(80, 42);
            this.btnTypePrecedent.TabIndex = 26;
            this.btnTypePrecedent.Text = "<--";
            this.btnTypePrecedent.UseVisualStyleBackColor = true;
            this.btnTypePrecedent.Click += new System.EventHandler(this.btnTypePrecedent_Click);
            // 
            // btnTypeSuivant
            // 
            this.btnTypeSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeSuivant.Location = new System.Drawing.Point(475, 477);
            this.btnTypeSuivant.Margin = new System.Windows.Forms.Padding(2);
            this.btnTypeSuivant.Name = "btnTypeSuivant";
            this.btnTypeSuivant.Size = new System.Drawing.Size(80, 42);
            this.btnTypeSuivant.TabIndex = 27;
            this.btnTypeSuivant.Text = "-->";
            this.btnTypeSuivant.UseVisualStyleBackColor = true;
            this.btnTypeSuivant.Click += new System.EventHandler(this.btnTypeSuivant_Click);
            // 
            // GestionSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 539);
            this.Controls.Add(this.btnTypeSuivant);
            this.Controls.Add(this.btnTypePrecedent);
            this.Controls.Add(this.soinDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.noSoinTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(dureeLabel);
            this.Controls.Add(this.dureeTextBox);
            this.Controls.Add(noTypeSoinLabel);
            this.Controls.Add(this.noTypeSoinComboBox);
            this.Controls.Add(prixLabel);
            this.Controls.Add(this.prixTextBox);
            this.Name = "GestionSoin";
            this.Text = "GestionSoin";
            this.Load += new System.EventHandler(this.GestionSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox noSoinTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox dureeTextBox;
        private System.Windows.Forms.ComboBox noTypeSoinComboBox;
        private System.Windows.Forms.TextBox prixTextBox;
        private BDB56Projet1BKGDataSetTableAdapters.TypeSoinTableAdapter typeSoinTableAdapter;
        private System.Windows.Forms.BindingSource typeSoinBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.AssistantSoinTableAdapter assistantSoinTableAdapter;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource planifSoinBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.PlanifSoinTableAdapter planifSoinTableAdapter;
        private System.Windows.Forms.DataGridView soinDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnTypePrecedent;
        private System.Windows.Forms.Button btnTypeSuivant;
    }
}