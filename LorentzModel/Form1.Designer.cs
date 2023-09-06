namespace LorentzModel
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
            this.lorentzModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betweenXAndZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betweenYAndZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r10ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.r15ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lorentzModelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1452, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lorentzModelToolStripMenuItem
            // 
            this.lorentzModelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eulerMethodToolStripMenuItem,
            this.r10ToolStripMenuItem,
            this.r15ToolStripMenuItem,
            this.betweenXAndZToolStripMenuItem,
            this.betweenYAndZToolStripMenuItem,
            this.r10ToolStripMenuItem1,
            this.r15ToolStripMenuItem1});
            this.lorentzModelToolStripMenuItem.Name = "lorentzModelToolStripMenuItem";
            this.lorentzModelToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.lorentzModelToolStripMenuItem.Text = "LorentzModel";
            // 
            // eulerMethodToolStripMenuItem
            // 
            this.eulerMethodToolStripMenuItem.Name = "eulerMethodToolStripMenuItem";
            this.eulerMethodToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.eulerMethodToolStripMenuItem.Text = "z-versus-time r=5";
            this.eulerMethodToolStripMenuItem.Click += new System.EventHandler(this.eulerMethodToolStripMenuItem_Click);
            // 
            // r10ToolStripMenuItem
            // 
            this.r10ToolStripMenuItem.Name = "r10ToolStripMenuItem";
            this.r10ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.r10ToolStripMenuItem.Text = "r=10";
            this.r10ToolStripMenuItem.Click += new System.EventHandler(this.r10ToolStripMenuItem_Click);
            // 
            // r15ToolStripMenuItem
            // 
            this.r15ToolStripMenuItem.Name = "r15ToolStripMenuItem";
            this.r15ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.r15ToolStripMenuItem.Text = "r=15";
            this.r15ToolStripMenuItem.Click += new System.EventHandler(this.r15ToolStripMenuItem_Click);
            // 
            // betweenXAndZToolStripMenuItem
            // 
            this.betweenXAndZToolStripMenuItem.Name = "betweenXAndZToolStripMenuItem";
            this.betweenXAndZToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.betweenXAndZToolStripMenuItem.Text = "between X and Z";
            this.betweenXAndZToolStripMenuItem.Click += new System.EventHandler(this.betweenXAndZToolStripMenuItem_Click);
            // 
            // betweenYAndZToolStripMenuItem
            // 
            this.betweenYAndZToolStripMenuItem.Name = "betweenYAndZToolStripMenuItem";
            this.betweenYAndZToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.betweenYAndZToolStripMenuItem.Text = "between y and Z";
            this.betweenYAndZToolStripMenuItem.Click += new System.EventHandler(this.betweenYAndZToolStripMenuItem_Click);
            // 
            // r10ToolStripMenuItem1
            // 
            this.r10ToolStripMenuItem1.Name = "r10ToolStripMenuItem1";
            this.r10ToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.r10ToolStripMenuItem1.Text = "r=10";
            this.r10ToolStripMenuItem1.Click += new System.EventHandler(this.r10ToolStripMenuItem1_Click);
            // 
            // r15ToolStripMenuItem1
            // 
            this.r15ToolStripMenuItem1.Name = "r15ToolStripMenuItem1";
            this.r15ToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.r15ToolStripMenuItem1.Text = "r=15";
            this.r15ToolStripMenuItem1.Click += new System.EventHandler(this.r15ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 849);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lorentzModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betweenXAndZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betweenYAndZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r10ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem r15ToolStripMenuItem1;
    }
}

