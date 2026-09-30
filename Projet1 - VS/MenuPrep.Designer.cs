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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPréposéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificationDesSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationDeChambreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPréposéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPréposéToolStripMenuItem
            // 
            this.menuPréposéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geToolStripMenuItem,
            this.planificationDesSoinsToolStripMenuItem,
            this.réservationDeChambreToolStripMenuItem,
            this.déconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuPréposéToolStripMenuItem.Name = "menuPréposéToolStripMenuItem";
            this.menuPréposéToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.menuPréposéToolStripMenuItem.Text = "Menu préposé";
            // 
            // geToolStripMenuItem
            // 
            this.geToolStripMenuItem.Name = "geToolStripMenuItem";
            this.geToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.geToolStripMenuItem.Text = "Gestions: Clients et invités";
            this.geToolStripMenuItem.Click += new System.EventHandler(this.geToolStripMenuItem_Click);
            // 
            // planificationDesSoinsToolStripMenuItem
            // 
            this.planificationDesSoinsToolStripMenuItem.Name = "planificationDesSoinsToolStripMenuItem";
            this.planificationDesSoinsToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.planificationDesSoinsToolStripMenuItem.Text = "Planification des soins";
            this.planificationDesSoinsToolStripMenuItem.Click += new System.EventHandler(this.planificationDesSoinsToolStripMenuItem_Click);
            // 
            // réservationDeChambreToolStripMenuItem
            // 
            this.réservationDeChambreToolStripMenuItem.Name = "réservationDeChambreToolStripMenuItem";
            this.réservationDeChambreToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.réservationDeChambreToolStripMenuItem.Text = "Réservation de chambre";
            this.réservationDeChambreToolStripMenuItem.Click += new System.EventHandler(this.réservationDeChambreToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // MenuPrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuPrep";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPréposéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificationDesSoinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationDeChambreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}