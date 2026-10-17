namespace Projet1___VS
{
    partial class MenuPrep
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projet1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientEtInvitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificationsDesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationDeChambreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu préposé";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projet1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projet1ToolStripMenuItem
            // 
            this.projet1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientEtInvitésToolStripMenuItem,
            this.planificationsDesToolStripMenuItem,
            this.reservationDeChambreToolStripMenuItem,
            this.déconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.projet1ToolStripMenuItem.Name = "projet1ToolStripMenuItem";
            this.projet1ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.projet1ToolStripMenuItem.Text = "Menu préposé";
            // 
            // gestionClientEtInvitésToolStripMenuItem
            // 
            this.gestionClientEtInvitésToolStripMenuItem.Name = "gestionClientEtInvitésToolStripMenuItem";
            this.gestionClientEtInvitésToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gestionClientEtInvitésToolStripMenuItem.Text = "Gestion: Client et invités";
            this.gestionClientEtInvitésToolStripMenuItem.Click += new System.EventHandler(this.gestionClientEtInvitésToolStripMenuItem_Click);
            // 
            // planificationsDesToolStripMenuItem
            // 
            this.planificationsDesToolStripMenuItem.Name = "planificationsDesToolStripMenuItem";
            this.planificationsDesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.planificationsDesToolStripMenuItem.Text = "Planification des soins";
            this.planificationsDesToolStripMenuItem.Click += new System.EventHandler(this.planificationsDesToolStripMenuItem_Click);
            // 
            // reservationDeChambreToolStripMenuItem
            // 
            this.reservationDeChambreToolStripMenuItem.Name = "reservationDeChambreToolStripMenuItem";
            this.reservationDeChambreToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.reservationDeChambreToolStripMenuItem.Text = "Reservation de chambre";
            this.reservationDeChambreToolStripMenuItem.Click += new System.EventHandler(this.reservationDeChambreToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // MenuPrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 353);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrep";
            this.Text = "Menu prep";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projet1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientEtInvitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificationsDesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationDeChambreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}