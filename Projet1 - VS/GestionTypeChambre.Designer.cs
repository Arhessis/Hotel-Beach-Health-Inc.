namespace Projet1___VS
{
    partial class GestionTypeChambre
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
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter();
            this.tableAdapterManager = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager();
            this.errTypeChambre = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlEntete = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.pnlFormulaire = new System.Windows.Forms.Panel();
            this.lblNoTypeChambre = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrixHaut = new System.Windows.Forms.Label();
            this.lblPrixBas = new System.Windows.Forms.Label();
            this.lblPrixMoyen = new System.Windows.Forms.Label();
            this.noTypeChambreTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.prixHautTextBox = new System.Windows.Forms.TextBox();
            this.prixBasTextBox = new System.Windows.Forms.TextBox();
            this.prixMoyenTextBox = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTypeChambre)).BeginInit();
            this.pnlEntete.SuspendLayout();
            this.pnlFormulaire.SuspendLayout();
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
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TypeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // errTypeChambre
            // 
            this.errTypeChambre.ContainerControl = this;
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
            this.lblTitre.Text = "Gestion des types de chambres";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.Location = new System.Drawing.Point(40, 95);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(800, 37);
            this.lblSousTitre.TabIndex = 1;
            this.lblSousTitre.Text = "La description du type doit être unique";
            // 
            // lblNoTypeChambre
            // 
            this.lblNoTypeChambre.AutoSize = true;
            this.lblNoTypeChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTypeChambre.Location = new System.Drawing.Point(40, 35);
            this.lblNoTypeChambre.Name = "lblNoTypeChambre";
            this.lblNoTypeChambre.Size = new System.Drawing.Size(200, 40);
            this.lblNoTypeChambre.TabIndex = 0;
            this.lblNoTypeChambre.Text = "No type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(40, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(200, 40);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblPrixHaut
            // 
            this.lblPrixHaut.AutoSize = true;
            this.lblPrixHaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixHaut.Location = new System.Drawing.Point(40, 175);
            this.lblPrixHaut.Name = "lblPrixHaut";
            this.lblPrixHaut.Size = new System.Drawing.Size(200, 40);
            this.lblPrixHaut.TabIndex = 4;
            this.lblPrixHaut.Text = "Prix saison haute";
            // 
            // lblPrixBas
            // 
            this.lblPrixBas.AutoSize = true;
            this.lblPrixBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixBas.Location = new System.Drawing.Point(40, 245);
            this.lblPrixBas.Name = "lblPrixBas";
            this.lblPrixBas.Size = new System.Drawing.Size(200, 40);
            this.lblPrixBas.TabIndex = 6;
            this.lblPrixBas.Text = "Prix saison basse";
            // 
            // lblPrixMoyen
            // 
            this.lblPrixMoyen.AutoSize = true;
            this.lblPrixMoyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixMoyen.Location = new System.Drawing.Point(40, 315);
            this.lblPrixMoyen.Name = "lblPrixMoyen";
            this.lblPrixMoyen.Size = new System.Drawing.Size(200, 40);
            this.lblPrixMoyen.TabIndex = 8;
            this.lblPrixMoyen.Text = "Prix saison moyenne";
            // 
            // noTypeChambreTextBox
            // 
            this.noTypeChambreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "NoTypeChambre", true));
            this.noTypeChambreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTypeChambreTextBox.Location = new System.Drawing.Point(380, 30);
            this.noTypeChambreTextBox.Name = "noTypeChambreTextBox";
            this.noTypeChambreTextBox.ReadOnly = true;
            this.noTypeChambreTextBox.Size = new System.Drawing.Size(500, 44);
            this.noTypeChambreTextBox.TabIndex = 1;
            this.noTypeChambreTextBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(380, 100);
            this.descriptionTextBox.MaxLength = 50;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(500, 44);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // prixHautTextBox
            // 
            this.prixHautTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "PrixHaut", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.prixHautTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixHautTextBox.Location = new System.Drawing.Point(380, 170);
            this.prixHautTextBox.Name = "prixHautTextBox";
            this.prixHautTextBox.Size = new System.Drawing.Size(500, 44);
            this.prixHautTextBox.TabIndex = 5;
            this.prixHautTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prixBasTextBox
            // 
            this.prixBasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "PrixBas", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.prixBasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixBasTextBox.Location = new System.Drawing.Point(380, 240);
            this.prixBasTextBox.Name = "prixBasTextBox";
            this.prixBasTextBox.Size = new System.Drawing.Size(500, 44);
            this.prixBasTextBox.TabIndex = 7;
            this.prixBasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prixMoyenTextBox
            // 
            this.prixMoyenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "PrixMoyen", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.prixMoyenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixMoyenTextBox.Location = new System.Drawing.Point(380, 310);
            this.prixMoyenTextBox.Name = "prixMoyenTextBox";
            this.prixMoyenTextBox.Size = new System.Drawing.Size(500, 44);
            this.prixMoyenTextBox.TabIndex = 9;
            this.prixMoyenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlFormulaire
            // 
            this.pnlFormulaire.Controls.Add(this.lblNoTypeChambre);
            this.pnlFormulaire.Controls.Add(this.noTypeChambreTextBox);
            this.pnlFormulaire.Controls.Add(this.lblDescription);
            this.pnlFormulaire.Controls.Add(this.descriptionTextBox);
            this.pnlFormulaire.Controls.Add(this.lblPrixHaut);
            this.pnlFormulaire.Controls.Add(this.prixHautTextBox);
            this.pnlFormulaire.Controls.Add(this.lblPrixBas);
            this.pnlFormulaire.Controls.Add(this.prixBasTextBox);
            this.pnlFormulaire.Controls.Add(this.lblPrixMoyen);
            this.pnlFormulaire.Controls.Add(this.prixMoyenTextBox);
            this.pnlFormulaire.Location = new System.Drawing.Point(40, 180);
            this.pnlFormulaire.Name = "pnlFormulaire";
            this.pnlFormulaire.Size = new System.Drawing.Size(920, 390);
            this.pnlFormulaire.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(40, 600);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(172, 80);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(227, 600);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(172, 80);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(414, 600);
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
            this.btnAnnuler.Location = new System.Drawing.Point(601, 600);
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
            this.btnFermer.Location = new System.Drawing.Point(788, 600);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(172, 80);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Quitter";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // GestionTypeChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.pnlFormulaire);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.pnlEntete);
            this.Name = "GestionTypeChambre";
            this.Text = "Hôtel Plage Santé - Gestion des types de chambres";
            this.Load += new System.EventHandler(this.GestionTypeChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTypeChambre)).EndInit();
            this.pnlEntete.ResumeLayout(false);
            this.pnlEntete.PerformLayout();
            this.pnlFormulaire.ResumeLayout(false);
            this.pnlFormulaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.TypeChambreTableAdapter typeChambreTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errTypeChambre;
        private System.Windows.Forms.Panel pnlEntete;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Panel pnlFormulaire;
        private System.Windows.Forms.Label lblNoTypeChambre;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrixHaut;
        private System.Windows.Forms.Label lblPrixBas;
        private System.Windows.Forms.Label lblPrixMoyen;
        private System.Windows.Forms.TextBox noTypeChambreTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox prixHautTextBox;
        private System.Windows.Forms.TextBox prixBasTextBox;
        private System.Windows.Forms.TextBox prixMoyenTextBox;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
    }
}
