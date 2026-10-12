namespace Projet1___VS
{
    partial class frmInvite
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
            System.Windows.Forms.Label noInviteLabel;
            System.Windows.Forms.Label nomPrenomLabel;
            System.Windows.Forms.Label noClientLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvite));
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.bDB56Projet1BKGDataSet = new Projet1___VS.BDB56Projet1BKGDataSet();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inviteTableAdapter = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter();
            this.tableAdapterManager = new Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager();
            this.inviteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inviteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.noInviteTextBox = new System.Windows.Forms.TextBox();
            this.nomPrenomTextBox = new System.Windows.Forms.TextBox();
            this.noClientTextBox1 = new System.Windows.Forms.TextBox();
            this.pnlEntete = new System.Windows.Forms.Panel();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.pnlFormulaire = new System.Windows.Forms.Panel();
            noInviteLabel = new System.Windows.Forms.Label();
            nomPrenomLabel = new System.Windows.Forms.Label();
            noClientLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingNavigator)).BeginInit();
            this.inviteBindingNavigator.SuspendLayout();
            this.pnlEntete.SuspendLayout();
            this.pnlFormulaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // noInviteLabel
            // 
            noInviteLabel.AutoSize = true;
            noInviteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noInviteLabel.Location = new System.Drawing.Point(40, 35);
            noInviteLabel.Name = "noInviteLabel";
            noInviteLabel.Size = new System.Drawing.Size(200, 40);
            noInviteLabel.TabIndex = 0;
            noInviteLabel.Text = "No invité";
            // 
            // nomPrenomLabel
            // 
            nomPrenomLabel.AutoSize = true;
            nomPrenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomPrenomLabel.Location = new System.Drawing.Point(40, 105);
            nomPrenomLabel.Name = "nomPrenomLabel";
            nomPrenomLabel.Size = new System.Drawing.Size(200, 40);
            nomPrenomLabel.TabIndex = 2;
            nomPrenomLabel.Text = "Nom et prénom";
            // 
            // noClientLabel1
            // 
            noClientLabel1.AutoSize = true;
            noClientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noClientLabel1.Location = new System.Drawing.Point(40, 175);
            noClientLabel1.Name = "noClientLabel1";
            noClientLabel1.Size = new System.Drawing.Size(200, 40);
            noClientLabel1.TabIndex = 4;
            noClientLabel1.Text = "No client";
            // 
            // bDB56Projet1BKGDataSet
            // 
            this.bDB56Projet1BKGDataSet.DataSetName = "BDB56Projet1BKGDataSet";
            this.bDB56Projet1BKGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = this.inviteTableAdapter;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1___VS.BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // inviteBindingNavigator
            // 
            this.inviteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inviteBindingNavigator.BindingSource = this.inviteBindingSource;
            this.inviteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inviteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inviteBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.inviteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inviteBindingNavigatorSaveItem});
            this.inviteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inviteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inviteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inviteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inviteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inviteBindingNavigator.Name = "inviteBindingNavigator";
            this.inviteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inviteBindingNavigator.Size = new System.Drawing.Size(1000, 50);
            this.inviteBindingNavigator.TabIndex = 54;
            this.inviteBindingNavigator.Text = "bindingNavigator1";
            this.inviteBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // inviteBindingNavigatorSaveItem
            // 
            this.inviteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inviteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inviteBindingNavigatorSaveItem.Image")));
            this.inviteBindingNavigatorSaveItem.Name = "inviteBindingNavigatorSaveItem";
            this.inviteBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.inviteBindingNavigatorSaveItem.Text = "Save Data";
            this.inviteBindingNavigatorSaveItem.Click += new System.EventHandler(this.inviteBindingNavigatorSaveItem_Click);
            // 
            // noInviteTextBox
            // 
            this.noInviteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "NoInvite", true));
            this.noInviteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noInviteTextBox.Location = new System.Drawing.Point(340, 30);
            this.noInviteTextBox.Name = "noInviteTextBox";
            this.noInviteTextBox.ReadOnly = true;
            this.noInviteTextBox.Size = new System.Drawing.Size(540, 44);
            this.noInviteTextBox.TabIndex = 1;
            this.noInviteTextBox.TabStop = false;
            // 
            // nomPrenomTextBox
            // 
            this.nomPrenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "NomPrenom", true));
            this.nomPrenomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomPrenomTextBox.Location = new System.Drawing.Point(340, 100);
            this.nomPrenomTextBox.MaxLength = 50;
            this.nomPrenomTextBox.Name = "nomPrenomTextBox";
            this.nomPrenomTextBox.Size = new System.Drawing.Size(540, 44);
            this.nomPrenomTextBox.TabIndex = 3;
            // 
            // noClientTextBox1
            // 
            this.noClientTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "NoClient", true));
            this.noClientTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noClientTextBox1.Location = new System.Drawing.Point(340, 170);
            this.noClientTextBox1.Name = "noClientTextBox1";
            this.noClientTextBox1.ReadOnly = true;
            this.noClientTextBox1.Size = new System.Drawing.Size(540, 44);
            this.noClientTextBox1.TabIndex = 5;
            this.noClientTextBox1.TabStop = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(40, 460);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(218, 80);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(274, 460);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(218, 80);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Location = new System.Drawing.Point(508, 460);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(218, 80);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.CausesValidation = false;
            this.btnFermer.Location = new System.Drawing.Point(742, 460);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(218, 80);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Quitter";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // pnlEntete
            // 
            this.pnlEntete.Controls.Add(this.lblSousTitre);
            this.pnlEntete.Controls.Add(this.label2);
            this.pnlEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEntete.Location = new System.Drawing.Point(0, 0);
            this.pnlEntete.Name = "pnlEntete";
            this.pnlEntete.Size = new System.Drawing.Size(1000, 140);
            this.pnlEntete.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestion des invités";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTitre.Location = new System.Drawing.Point(40, 95);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(800, 37);
            this.lblSousTitre.TabIndex = 1;
            this.lblSousTitre.Text = "Seul le nom est modifiable";
            // 
            // pnlFormulaire
            // 
            this.pnlFormulaire.Controls.Add(noInviteLabel);
            this.pnlFormulaire.Controls.Add(this.noInviteTextBox);
            this.pnlFormulaire.Controls.Add(nomPrenomLabel);
            this.pnlFormulaire.Controls.Add(this.nomPrenomTextBox);
            this.pnlFormulaire.Controls.Add(noClientLabel1);
            this.pnlFormulaire.Controls.Add(this.noClientTextBox1);
            this.pnlFormulaire.Location = new System.Drawing.Point(40, 180);
            this.pnlFormulaire.Name = "pnlFormulaire";
            this.pnlFormulaire.Size = new System.Drawing.Size(920, 250);
            this.pnlFormulaire.TabIndex = 1;
            // 
            // frmInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.pnlFormulaire);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.pnlEntete);
            this.Controls.Add(this.inviteBindingNavigator);
            this.Name = "frmInvite";
            this.Text = "Hôtel Plage Santé - Gestion des invités";
            this.Load += new System.EventHandler(this.frmInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1BKGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingNavigator)).EndInit();
            this.inviteBindingNavigator.ResumeLayout(false);
            this.inviteBindingNavigator.PerformLayout();
            this.pnlEntete.ResumeLayout(false);
            this.pnlEntete.PerformLayout();
            this.pnlFormulaire.ResumeLayout(false);
            this.pnlFormulaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
        private BDB56Projet1BKGDataSet bDB56Projet1BKGDataSet;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private BDB56Projet1BKGDataSetTableAdapters.InviteTableAdapter inviteTableAdapter;
        private BDB56Projet1BKGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inviteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inviteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox noInviteTextBox;
        private System.Windows.Forms.TextBox nomPrenomTextBox;
        private System.Windows.Forms.TextBox noClientTextBox1;
        private System.Windows.Forms.Panel pnlEntete;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Panel pnlFormulaire;
    }
}
