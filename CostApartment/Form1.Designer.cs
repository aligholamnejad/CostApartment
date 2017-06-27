namespace CostApartment
{
    partial class Form1
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
            this.ApartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApartmentToolStripMenuItem,
            this.TermToolStripMenuItem,
            this.CostToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ApartmentToolStripMenuItem
            // 
            this.ApartmentToolStripMenuItem.Name = "ApartmentToolStripMenuItem";
            this.ApartmentToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ApartmentToolStripMenuItem.Text = "آپارتمان";
            this.ApartmentToolStripMenuItem.Click += new System.EventHandler(this.ApartmentToolStripMenuItem_Click);
            // 
            // TermToolStripMenuItem
            // 
            this.TermToolStripMenuItem.Name = "TermToolStripMenuItem";
            this.TermToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.TermToolStripMenuItem.Text = "دوره ";
            this.TermToolStripMenuItem.Click += new System.EventHandler(this.TermToolStripMenuItem_Click);
            // 
            // CostToolStripMenuItem
            // 
            this.CostToolStripMenuItem.Name = "CostToolStripMenuItem";
            this.CostToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.CostToolStripMenuItem.Text = "طرح هزینه";
            this.CostToolStripMenuItem.Click += new System.EventHandler(this.CostToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 353);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "آسان حساب";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ApartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TermToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CostToolStripMenuItem;
    }
}

