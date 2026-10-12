namespace Projet1___VS
{
    partial class GestionChambre
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
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ChambreTableAdapter();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter();
            this.tableAdapterManager = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager();
            this.errChambre = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.pnlFormulaire = new System.Windows.Forms.Panel();
            this.lblNoChambre = new System.Windows.Forms.Label();
            this.lblEmplacement = new System.Windows.Forms.Label();
            this.lblDecorations = new System.Windows.Forms.Label();
            this.lblTypeChambre = new System.Windows.Forms.Label();
            this.noChambreTextBox = new System.Windows.Forms.TextBox();
            this.emplacementTextBox = new System.Windows.Forms.TextBox();
            this.decorationsTextBox = new System.Windows.Forms.TextBox();
            this.typeChambreComboBox = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errChambre)).BeginInit();
            this.pnlEntete.SuspendLayout();
            this.pnlFormulaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "Chambre";
            this.chambreBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "TypeChambre";
            this.typeChambreBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = this.chambreTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // errChambre
            // 
            this.errChambre.ContainerControl = this;
            // 
            // pnlEntete
            // 
            this.pnlEntete.Controls.Add(this.lblSousTitre);
            this.pnlEntete.Controls.Add(this.lblTitre);
            this.pnlEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEntete.Location = new System.Drawing.Point(0, 0);
            this.pnlEntete.Name = "pnlEntete";
            this.pnlEntete.Size = new System.Drawing.Size(1000, 140);
            this.pnlEntete.TabIndex = 8;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(32, 14);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(600, 72);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des chambres";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.Location = new System.Drawing.Point(40, 95);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(800, 37);
            this.lblSousTitre.TabIndex = 1;
            this.lblSousTitre.Text = "Tous les champs sont obligatoires";
            // 
            // lblNoChambre
            // 
            this.lblNoChambre.AutoSize = true;
            this.lblNoChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoChambre.Location = new System.Drawing.Point(40, 35);
            this.lblNoChambre.Name = "lblNoChambre";
            this.lblNoChambre.Size = new System.Drawing.Size(200, 40);
            this.lblNoChambre.TabIndex = 0;
            this.lblNoChambre.Text = "No chambre";
            // 
            // lblEmplacement
            // 
            this.lblEmplacement.AutoSize = true;
            this.lblEmplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplacement.Location = new System.Drawing.Point(40, 105);
            this.lblEmplacement.Name = "lblEmplacement";
            this.lblEmplacement.Size = new System.Drawing.Size(200, 40);
            this.lblEmplacement.TabIndex = 2;
            this.lblEmplacement.Text = "Emplacement";
            // 
            // lblDecorations
            // 
            this.lblDecorations.AutoSize = true;
            this.lblDecorations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecorations.Location = new System.Drawing.Point(40, 175);
            this.lblDecorations.Name = "lblDecorations";
            this.lblDecorations.Size = new System.Drawing.Size(200, 40);
            this.lblDecorations.TabIndex = 4;
            this.lblDecorations.Text = "Décorations";
            // 
            // lblTypeChambre
            // 
            this.lblTypeChambre.AutoSize = true;
            this.lblTypeChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeChambre.Location = new System.Drawing.Point(40, 245);
            this.lblTypeChambre.Name = "lblTypeChambre";
            this.lblTypeChambre.Size = new System.Drawing.Size(200, 40);
            this.lblTypeChambre.TabIndex = 6;
            this.lblTypeChambre.Text = "Type de chambre";
            // 
            // noChambreTextBox
            // 
            this.noChambreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "NoChambre", true));
            this.noChambreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noChambreTextBox.Location = new System.Drawing.Point(340, 30);
            this.noChambreTextBox.Name = "noChambreTextBox";
            this.noChambreTextBox.ReadOnly = true;
            this.noChambreTextBox.Size = new System.Drawing.Size(540, 44);
            this.noChambreTextBox.TabIndex = 1;
            this.noChambreTextBox.TabStop = false;
            // 
            // emplacementTextBox
            // 
            this.emplacementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "Emplacement", true));
            this.emplacementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplacementTextBox.Location = new System.Drawing.Point(340, 100);
            this.emplacementTextBox.MaxLength = 30;
            this.emplacementTextBox.Name = "emplacementTextBox";
            this.emplacementTextBox.Size = new System.Drawing.Size(540, 44);
            this.emplacementTextBox.TabIndex = 3;
            // 
            // decorationsTextBox
            // 
            this.decorationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "Decorations", true));
            this.decorationsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decorationsTextBox.Location = new System.Drawing.Point(340, 170);
            this.decorationsTextBox.MaxLength = 50;
            this.decorationsTextBox.Name = "decorationsTextBox";
            this.decorationsTextBox.Size = new System.Drawing.Size(540, 44);
            this.decorationsTextBox.TabIndex = 5;
            // 
            // typeChambreComboBox
            // 
            this.typeChambreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chambreBindingSource, "NoTypeChambre", true));
            this.typeChambreComboBox.DataSource = this.typeChambreBindingSource;
            this.typeChambreComboBox.DisplayMember = "Description";
            this.typeChambreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeChambreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeChambreComboBox.FormattingEnabled = true;
            this.typeChambreComboBox.Location = new System.Drawing.Point(340, 240);
            this.typeChambreComboBox.Name = "typeChambreComboBox";
            this.typeChambreComboBox.Size = new System.Drawing.Size(540, 48);
            this.typeChambreComboBox.TabIndex = 7;
            this.typeChambreComboBox.ValueMember = "NoTypeChambre";
            // 
            // pnlFormulaire
            // 
            this.pnlFormulaire.Controls.Add(this.lblNoChambre);
            this.pnlFormulaire.Controls.Add(this.noChambreTextBox);
            this.pnlFormulaire.Controls.Add(this.lblEmplacement);
            this.pnlFormulaire.Controls.Add(this.emplacementTextBox);
            this.pnlFormulaire.Controls.Add(this.lblDecorations);
            this.pnlFormulaire.Controls.Add(this.decorationsTextBox);
            this.pnlFormulaire.Controls.Add(this.lblTypeChambre);
            this.pnlFormulaire.Controls.Add(this.typeChambreComboBox);
            this.pnlFormulaire.Location = new System.Drawing.Point(40, 180);
            this.pnlFormulaire.Name = "pnlFormulaire";
            this.pnlFormulaire.Size = new System.Drawing.Size(920, 320);
            this.pnlFormulaire.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(40, 530);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(172, 80);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(227, 530);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(172, 80);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(414, 530);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(172, 80);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Location = new System.Drawing.Point(601, 530);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(172, 80);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.CausesValidation = false;
            this.btnFermer.Location = new System.Drawing.Point(788, 530);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(172, 80);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Quitter";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // GestionChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlFormulaire);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.pnlEntete);
            this.Name = "GestionChambre";
            this.Text = "Hôtel Plage Santé - Gestion des chambres";
            this.Load += new System.EventHandler(this.GestionChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errChambre)).EndInit();
            this.pnlEntete.ResumeLayout(false);
            this.pnlEntete.PerformLayout();
            this.pnlFormulaire.ResumeLayout(false);
            this.pnlFormulaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.ChambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter typeChambreTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errChambre;
        private System.Windows.Forms.Panel pnlEntete;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Panel pnlFormulaire;
        private System.Windows.Forms.Label lblNoChambre;
        private System.Windows.Forms.Label lblEmplacement;
        private System.Windows.Forms.Label lblDecorations;
        private System.Windows.Forms.Label lblTypeChambre;
        private System.Windows.Forms.TextBox noChambreTextBox;
        private System.Windows.Forms.TextBox emplacementTextBox;
        private System.Windows.Forms.TextBox decorationsTextBox;
        private System.Windows.Forms.ComboBox typeChambreComboBox;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
    }
}
