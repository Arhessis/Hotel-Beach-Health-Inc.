namespace Projet1___VS
{
    partial class frmChambreEtType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter();
            this.chambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ChambreTableAdapter();
            this.reservationChambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.ReservationChambreTableAdapter();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblTypes = new System.Windows.Forms.Label();
            this.lblChambres = new System.Windows.Forms.Label();
            this.dgTypesChambres = new System.Windows.Forms.DataGridView();
            this.dgTxtNoTypeChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrixHaut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrixBas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtPrixMoyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgChambres = new System.Windows.Forms.DataGridView();
            this.dgTxtNoChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtEmplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtDecorations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTypePrecedent = new System.Windows.Forms.Button();
            this.btnTypeSuivant = new System.Windows.Forms.Button();
            this.btnAjouterType = new System.Windows.Forms.Button();
            this.btnModifierType = new System.Windows.Forms.Button();
            this.btnSupprimerType = new System.Windows.Forms.Button();
            this.btnChambrePrecedent = new System.Windows.Forms.Button();
            this.btnChambreSuivant = new System.Windows.Forms.Button();
            this.btnAjouterChambre = new System.Windows.Forms.Button();
            this.btnModifierChambre = new System.Windows.Forms.Button();
            this.btnSupprimerChambre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTypesChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "TypeChambre";
            this.typeChambreBindingSource.DataSource = this.bDB56Projet1BKGDataSet;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "fk_Chambre_TypeChambre";
            this.chambreBindingSource.DataSource = this.typeChambreBindingSource;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // reservationChambreTableAdapter
            // 
            this.reservationChambreTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(32, 14);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(200, 37);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Chambres et types de chambres";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.Location = new System.Drawing.Point(40, 95);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(200, 37);
            this.lblSousTitre.TabIndex = 0;
            this.lblSousTitre.Text = "Sélectionnez un type pour afficher ses chambres";
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
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypes.Location = new System.Drawing.Point(32, 160);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(200, 37);
            this.lblTypes.TabIndex = 0;
            this.lblTypes.Text = "Types de chambres";
            // 
            // lblChambres
            // 
            this.lblChambres.AutoSize = true;
            this.lblChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChambres.Location = new System.Drawing.Point(1252, 160);
            this.lblChambres.Name = "lblChambres";
            this.lblChambres.Size = new System.Drawing.Size(200, 37);
            this.lblChambres.TabIndex = 0;
            this.lblChambres.Text = "Chambres du type sélectionné";
            // 
            // dgTypesChambres
            // 
            this.dgTypesChambres.AllowUserToAddRows = false;
            this.dgTypesChambres.AllowUserToDeleteRows = false;
            this.dgTypesChambres.AutoGenerateColumns = false;
            this.dgTypesChambres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTypesChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTypesChambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoTypeChambre,
            this.dgTxtDescription,
            this.dgTxtPrixHaut,
            this.dgTxtPrixBas,
            this.dgTxtPrixMoyen});
            this.dgTypesChambres.DataSource = this.typeChambreBindingSource;
            this.dgTypesChambres.Location = new System.Drawing.Point(40, 230);
            this.dgTypesChambres.MultiSelect = false;
            this.dgTypesChambres.Name = "dgTypesChambres";
            this.dgTypesChambres.ReadOnly = true;
            this.dgTypesChambres.RowHeadersWidth = 40;
            this.dgTypesChambres.RowTemplate.Height = 33;
            this.dgTypesChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTypesChambres.Size = new System.Drawing.Size(1180, 690);
            this.dgTypesChambres.TabIndex = 1;
            // 
            // dgTxtNoTypeChambre
            // 
            this.dgTxtNoTypeChambre.DataPropertyName = "NoTypeChambre";
            this.dgTxtNoTypeChambre.FillWeight = 45F;
            this.dgTxtNoTypeChambre.HeaderText = "No";
            this.dgTxtNoTypeChambre.MinimumWidth = 10;
            this.dgTxtNoTypeChambre.Name = "dgTxtNoTypeChambre";
            this.dgTxtNoTypeChambre.ReadOnly = true;
            // 
            // dgTxtDescription
            // 
            this.dgTxtDescription.DataPropertyName = "Description";
            this.dgTxtDescription.FillWeight = 150F;
            this.dgTxtDescription.HeaderText = "Description";
            this.dgTxtDescription.MinimumWidth = 10;
            this.dgTxtDescription.Name = "dgTxtDescription";
            this.dgTxtDescription.ReadOnly = true;
            // 
            // dgTxtPrixHaut
            // 
            this.dgTxtPrixHaut.DataPropertyName = "PrixHaut";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            this.dgTxtPrixHaut.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgTxtPrixHaut.HeaderText = "Saison haute";
            this.dgTxtPrixHaut.MinimumWidth = 10;
            this.dgTxtPrixHaut.Name = "dgTxtPrixHaut";
            this.dgTxtPrixHaut.ReadOnly = true;
            // 
            // dgTxtPrixBas
            // 
            this.dgTxtPrixBas.DataPropertyName = "PrixBas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            this.dgTxtPrixBas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTxtPrixBas.HeaderText = "Saison basse";
            this.dgTxtPrixBas.MinimumWidth = 10;
            this.dgTxtPrixBas.Name = "dgTxtPrixBas";
            this.dgTxtPrixBas.ReadOnly = true;
            // 
            // dgTxtPrixMoyen
            // 
            this.dgTxtPrixMoyen.DataPropertyName = "PrixMoyen";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            this.dgTxtPrixMoyen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTxtPrixMoyen.HeaderText = "Saison moyenne";
            this.dgTxtPrixMoyen.MinimumWidth = 10;
            this.dgTxtPrixMoyen.Name = "dgTxtPrixMoyen";
            this.dgTxtPrixMoyen.ReadOnly = true;
            // 
            // dgChambres
            // 
            this.dgChambres.AllowUserToAddRows = false;
            this.dgChambres.AllowUserToDeleteRows = false;
            this.dgChambres.AutoGenerateColumns = false;
            this.dgChambres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtNoChambre,
            this.dgTxtEmplacement,
            this.dgTxtDecorations});
            this.dgChambres.DataSource = this.chambreBindingSource;
            this.dgChambres.Location = new System.Drawing.Point(1260, 230);
            this.dgChambres.MultiSelect = false;
            this.dgChambres.Name = "dgChambres";
            this.dgChambres.ReadOnly = true;
            this.dgChambres.RowHeadersWidth = 40;
            this.dgChambres.RowTemplate.Height = 33;
            this.dgChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChambres.Size = new System.Drawing.Size(900, 690);
            this.dgChambres.TabIndex = 7;
            // 
            // dgTxtNoChambre
            // 
            this.dgTxtNoChambre.DataPropertyName = "NoChambre";
            this.dgTxtNoChambre.FillWeight = 50F;
            this.dgTxtNoChambre.HeaderText = "No";
            this.dgTxtNoChambre.MinimumWidth = 10;
            this.dgTxtNoChambre.Name = "dgTxtNoChambre";
            this.dgTxtNoChambre.ReadOnly = true;
            // 
            // dgTxtEmplacement
            // 
            this.dgTxtEmplacement.DataPropertyName = "Emplacement";
            this.dgTxtEmplacement.HeaderText = "Emplacement";
            this.dgTxtEmplacement.MinimumWidth = 10;
            this.dgTxtEmplacement.Name = "dgTxtEmplacement";
            this.dgTxtEmplacement.ReadOnly = true;
            // 
            // dgTxtDecorations
            // 
            this.dgTxtDecorations.DataPropertyName = "Decorations";
            this.dgTxtDecorations.FillWeight = 140F;
            this.dgTxtDecorations.HeaderText = "Décoration";
            this.dgTxtDecorations.MinimumWidth = 10;
            this.dgTxtDecorations.Name = "dgTxtDecorations";
            this.dgTxtDecorations.ReadOnly = true;
            // 
            // btnTypePrecedent
            // 
            this.btnTypePrecedent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypePrecedent.Location = new System.Drawing.Point(40, 945);
            this.btnTypePrecedent.Name = "btnTypePrecedent";
            this.btnTypePrecedent.Size = new System.Drawing.Size(160, 80);
            this.btnTypePrecedent.TabIndex = 2;
            this.btnTypePrecedent.Text = "<--";
            this.btnTypePrecedent.UseVisualStyleBackColor = true;
            this.btnTypePrecedent.Click += new System.EventHandler(this.btnTypePrecedent_Click);
            // 
            // btnTypeSuivant
            // 
            this.btnTypeSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeSuivant.Location = new System.Drawing.Point(210, 945);
            this.btnTypeSuivant.Name = "btnTypeSuivant";
            this.btnTypeSuivant.Size = new System.Drawing.Size(160, 80);
            this.btnTypeSuivant.TabIndex = 3;
            this.btnTypeSuivant.Text = "-->";
            this.btnTypeSuivant.UseVisualStyleBackColor = true;
            this.btnTypeSuivant.Click += new System.EventHandler(this.btnTypeSuivant_Click);
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Location = new System.Drawing.Point(560, 945);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(210, 80);
            this.btnAjouterType.TabIndex = 4;
            this.btnAjouterType.Text = "Ajouter";
            this.btnAjouterType.UseVisualStyleBackColor = true;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // btnModifierType
            // 
            this.btnModifierType.Location = new System.Drawing.Point(785, 945);
            this.btnModifierType.Name = "btnModifierType";
            this.btnModifierType.Size = new System.Drawing.Size(210, 80);
            this.btnModifierType.TabIndex = 5;
            this.btnModifierType.Text = "Modifier";
            this.btnModifierType.UseVisualStyleBackColor = true;
            this.btnModifierType.Click += new System.EventHandler(this.btnModifierType_Click);
            // 
            // btnSupprimerType
            // 
            this.btnSupprimerType.Location = new System.Drawing.Point(1010, 945);
            this.btnSupprimerType.Name = "btnSupprimerType";
            this.btnSupprimerType.Size = new System.Drawing.Size(210, 80);
            this.btnSupprimerType.TabIndex = 6;
            this.btnSupprimerType.Text = "Supprimer";
            this.btnSupprimerType.UseVisualStyleBackColor = true;
            this.btnSupprimerType.Click += new System.EventHandler(this.btnSupprimerType_Click);
            // 
            // btnChambrePrecedent
            // 
            this.btnChambrePrecedent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChambrePrecedent.Location = new System.Drawing.Point(1260, 945);
            this.btnChambrePrecedent.Name = "btnChambrePrecedent";
            this.btnChambrePrecedent.Size = new System.Drawing.Size(140, 80);
            this.btnChambrePrecedent.TabIndex = 8;
            this.btnChambrePrecedent.Text = "<--";
            this.btnChambrePrecedent.UseVisualStyleBackColor = true;
            this.btnChambrePrecedent.Click += new System.EventHandler(this.btnChambrePrecedent_Click);
            // 
            // btnChambreSuivant
            // 
            this.btnChambreSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChambreSuivant.Location = new System.Drawing.Point(1410, 945);
            this.btnChambreSuivant.Name = "btnChambreSuivant";
            this.btnChambreSuivant.Size = new System.Drawing.Size(140, 80);
            this.btnChambreSuivant.TabIndex = 9;
            this.btnChambreSuivant.Text = "-->";
            this.btnChambreSuivant.UseVisualStyleBackColor = true;
            this.btnChambreSuivant.Click += new System.EventHandler(this.btnChambreSuivant_Click);
            // 
            // btnAjouterChambre
            // 
            this.btnAjouterChambre.Location = new System.Drawing.Point(1580, 945);
            this.btnAjouterChambre.Name = "btnAjouterChambre";
            this.btnAjouterChambre.Size = new System.Drawing.Size(190, 80);
            this.btnAjouterChambre.TabIndex = 10;
            this.btnAjouterChambre.Text = "Ajouter";
            this.btnAjouterChambre.UseVisualStyleBackColor = true;
            this.btnAjouterChambre.Click += new System.EventHandler(this.btnAjouterChambre_Click);
            // 
            // btnModifierChambre
            // 
            this.btnModifierChambre.Location = new System.Drawing.Point(1775, 945);
            this.btnModifierChambre.Name = "btnModifierChambre";
            this.btnModifierChambre.Size = new System.Drawing.Size(190, 80);
            this.btnModifierChambre.TabIndex = 11;
            this.btnModifierChambre.Text = "Modifier";
            this.btnModifierChambre.UseVisualStyleBackColor = true;
            this.btnModifierChambre.Click += new System.EventHandler(this.btnModifierChambre_Click);
            // 
            // btnSupprimerChambre
            // 
            this.btnSupprimerChambre.Location = new System.Drawing.Point(1970, 945);
            this.btnSupprimerChambre.Name = "btnSupprimerChambre";
            this.btnSupprimerChambre.Size = new System.Drawing.Size(190, 80);
            this.btnSupprimerChambre.TabIndex = 12;
            this.btnSupprimerChambre.Text = "Supprimer";
            this.btnSupprimerChambre.UseVisualStyleBackColor = true;
            this.btnSupprimerChambre.Click += new System.EventHandler(this.btnSupprimerChambre_Click);
            // 
            // GestionChambreEtType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2200, 1065);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblSousTitre);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.lblChambres);
            this.Controls.Add(this.dgTypesChambres);
            this.Controls.Add(this.dgChambres);
            this.Controls.Add(this.btnTypePrecedent);
            this.Controls.Add(this.btnTypeSuivant);
            this.Controls.Add(this.btnAjouterType);
            this.Controls.Add(this.btnModifierType);
            this.Controls.Add(this.btnSupprimerType);
            this.Controls.Add(this.btnChambrePrecedent);
            this.Controls.Add(this.btnChambreSuivant);
            this.Controls.Add(this.btnAjouterChambre);
            this.Controls.Add(this.btnModifierChambre);
            this.Controls.Add(this.btnSupprimerChambre);
            this.Name = "GestionChambreEtType";
            this.Text = "Gestion des chambres et types de chambres";
            this.Load += new System.EventHandler(this.GestionChambreEtType_Load);
            this.VisibleChanged += new System.EventHandler(this.GestionChambreEtType_VisibleChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionChambreEtType_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTypesChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter typeChambreTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.ChambreTableAdapter chambreTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.ReservationChambreTableAdapter reservationChambreTableAdapter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.Label lblChambres;
        private System.Windows.Forms.DataGridView dgTypesChambres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoTypeChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrixHaut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrixBas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtPrixMoyen;
        private System.Windows.Forms.DataGridView dgChambres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtNoChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtEmplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtDecorations;
        private System.Windows.Forms.Button btnTypePrecedent;
        private System.Windows.Forms.Button btnTypeSuivant;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.Button btnModifierType;
        private System.Windows.Forms.Button btnSupprimerType;
        private System.Windows.Forms.Button btnChambrePrecedent;
        private System.Windows.Forms.Button btnChambreSuivant;
        private System.Windows.Forms.Button btnAjouterChambre;
        private System.Windows.Forms.Button btnModifierChambre;
        private System.Windows.Forms.Button btnSupprimerChambre;
    }
}
