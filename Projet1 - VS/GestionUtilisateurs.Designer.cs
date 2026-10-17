namespace Projet1___VS
{
    partial class GestionUtilisateurs
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
            System.Windows.Forms.Label noUtilisateurLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label motDePasseLabel;
            System.Windows.Forms.Label noTypeLabel1;
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.UtilisateurTableAdapter();
            this.tableAdapterManager = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager();
            this.utilisateurDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.typeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUtilisateurTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TypeUtilisateurTableAdapter();
            this.typeUtilisateurDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.txtNoUtilisateur = new System.Windows.Forms.TextBox();
            this.cboTypeUtilisateur = new System.Windows.Forms.ComboBox();
            noUtilisateurLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            motDePasseLabel = new System.Windows.Forms.Label();
            noTypeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "Utilisateur";
            this.utilisateurBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = this.utilisateurTableAdapter;
            // 
            // utilisateurDataGridView
            // 
            this.utilisateurDataGridView.AutoGenerateColumns = false;
            this.utilisateurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilisateurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.utilisateurDataGridView.DataSource = this.utilisateurBindingSource;
            this.utilisateurDataGridView.Location = new System.Drawing.Point(12, 216);
            this.utilisateurDataGridView.Name = "utilisateurDataGridView";
            this.utilisateurDataGridView.ReadOnly = true;
            this.utilisateurDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.utilisateurDataGridView.Size = new System.Drawing.Size(443, 220);
            this.utilisateurDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoUtilisateur";
            this.dataGridViewTextBoxColumn1.HeaderText = "No d\'utilisateur";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MotDePasse";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mot de Passe";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoType";
            this.dataGridViewTextBoxColumn4.HeaderText = "No de type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskervville", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion des utilisateurs";
            // 
            // noUtilisateurLabel
            // 
            noUtilisateurLabel.AutoSize = true;
            noUtilisateurLabel.Location = new System.Drawing.Point(26, 97);
            noUtilisateurLabel.Name = "noUtilisateurLabel";
            noUtilisateurLabel.Size = new System.Drawing.Size(73, 13);
            noUtilisateurLabel.TabIndex = 3;
            noUtilisateurLabel.Text = "No Utilisateur:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(26, 123);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "Nom:";
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "Nom", true));
            this.txtNom.Location = new System.Drawing.Point(109, 120);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 6;
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Location = new System.Drawing.Point(26, 149);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(77, 13);
            motDePasseLabel.TabIndex = 7;
            motDePasseLabel.Text = "Mot De Passe:";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "MotDePasse", true));
            this.txtMotDePasse.Location = new System.Drawing.Point(109, 146);
            this.txtMotDePasse.MaxLength = 30;
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(100, 20);
            this.txtMotDePasse.TabIndex = 8;
            // 
            // noTypeLabel1
            // 
            noTypeLabel1.AutoSize = true;
            noTypeLabel1.Location = new System.Drawing.Point(26, 175);
            noTypeLabel1.Name = "noTypeLabel1";
            noTypeLabel1.Size = new System.Drawing.Size(51, 13);
            noTypeLabel1.TabIndex = 11;
            noTypeLabel1.Text = "No Type:";
            // 
            // typeUtilisateurBindingSource
            // 
            this.typeUtilisateurBindingSource.DataMember = "TypeUtilisateur";
            this.typeUtilisateurBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // typeUtilisateurTableAdapter
            // 
            this.typeUtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // typeUtilisateurDataGridView
            // 
            this.typeUtilisateurDataGridView.AutoGenerateColumns = false;
            this.typeUtilisateurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeUtilisateurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.typeUtilisateurDataGridView.DataSource = this.typeUtilisateurBindingSource;
            this.typeUtilisateurDataGridView.Location = new System.Drawing.Point(939, 28);
            this.typeUtilisateurDataGridView.Name = "typeUtilisateurDataGridView";
            this.typeUtilisateurDataGridView.Size = new System.Drawing.Size(11, 11);
            this.typeUtilisateurDataGridView.TabIndex = 12;
            this.typeUtilisateurDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NoType";
            this.dataGridViewTextBoxColumn5.HeaderText = "NoType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "identification";
            this.dataGridViewTextBoxColumn6.HeaderText = "identification";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(264, 94);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(81, 32);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(351, 94);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(81, 32);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(264, 132);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(81, 33);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(351, 133);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(81, 30);
            this.btnEnregistrer.TabIndex = 16;
            this.btnEnregistrer.Text = "Enregister";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(264, 171);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 30);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);

            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(351, 171);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(81, 29);
            this.btnFermer.TabIndex = 18;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.CausesValidation = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionUtilisateurs_FormClosing);
            // 
            // txtNoUtilisateur
            // 
            this.txtNoUtilisateur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "NoUtilisateur", true));
            this.txtNoUtilisateur.Location = new System.Drawing.Point(109, 94);
            this.txtNoUtilisateur.Name = "txtNoUtilisateur";
            this.txtNoUtilisateur.ReadOnly = true;
            this.txtNoUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.txtNoUtilisateur.TabIndex = 4;
            // 
            // cboTypeUtilisateur
            // 
            this.cboTypeUtilisateur.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.utilisateurBindingSource, "NoType", true));
            this.cboTypeUtilisateur.DataSource = this.typeUtilisateurBindingSource;
            this.cboTypeUtilisateur.DisplayMember = "identification";
            this.cboTypeUtilisateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeUtilisateur.FormattingEnabled = true;
            this.cboTypeUtilisateur.Location = new System.Drawing.Point(109, 172);
            this.cboTypeUtilisateur.Name = "cboTypeUtilisateur";
            this.cboTypeUtilisateur.Size = new System.Drawing.Size(100, 21);
            this.cboTypeUtilisateur.TabIndex = 12;
            this.cboTypeUtilisateur.ValueMember = "NoType";
            // 
            // GestionUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 456);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.typeUtilisateurDataGridView);
            this.Controls.Add(noTypeLabel1);
            this.Controls.Add(this.cboTypeUtilisateur);
            this.Controls.Add(noUtilisateurLabel);
            this.Controls.Add(this.txtNoUtilisateur);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.utilisateurDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionUtilisateurs";
            this.Text = "GestionUtilisateurs";
            this.Load += new System.EventHandler(this.GestionUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.UtilisateurTableAdapter utilisateurTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView utilisateurDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.TypeUtilisateurTableAdapter typeUtilisateurTableAdapter;
        private System.Windows.Forms.DataGridView typeUtilisateurDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox txtNoUtilisateur;
        private System.Windows.Forms.ComboBox cboTypeUtilisateur;
    }
}