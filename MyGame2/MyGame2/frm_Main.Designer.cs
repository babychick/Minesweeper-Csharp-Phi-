namespace MyGame2
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnStrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip_beginner = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip_intermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip_expert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip_custom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip_bestplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip_help = new System.Windows.Forms.ToolStripMenuItem();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Projectname = new System.Windows.Forms.Label();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnStrip_menu,
            this.mnStrip_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnStrip_menu
            // 
            this.mnStrip_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnStrip_new,
            this.mnStrip_beginner,
            this.mnStrip_intermediate,
            this.mnStrip_expert,
            this.mnStrip_custom,
            this.mnStrip_bestplayer});
            this.mnStrip_menu.Name = "mnStrip_menu";
            this.mnStrip_menu.Size = new System.Drawing.Size(58, 24);
            this.mnStrip_menu.Text = "Menu";
            // 
            // mnStrip_new
            // 
            this.mnStrip_new.Name = "mnStrip_new";
            this.mnStrip_new.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnStrip_new.Size = new System.Drawing.Size(169, 26);
            this.mnStrip_new.Text = "New";
            this.mnStrip_new.Click += new System.EventHandler(this.mnStrip_new_Click);
            // 
            // mnStrip_beginner
            // 
            this.mnStrip_beginner.Name = "mnStrip_beginner";
            this.mnStrip_beginner.Size = new System.Drawing.Size(169, 26);
            this.mnStrip_beginner.Text = "Beginner";
            this.mnStrip_beginner.Click += new System.EventHandler(this.mnStrip_beginner_Click);
            // 
            // mnStrip_intermediate
            // 
            this.mnStrip_intermediate.Name = "mnStrip_intermediate";
            this.mnStrip_intermediate.Size = new System.Drawing.Size(169, 26);
            this.mnStrip_intermediate.Text = "Intermediate";
            this.mnStrip_intermediate.Click += new System.EventHandler(this.mnStrip_intermediate_Click);
            // 
            // mnStrip_expert
            // 
            this.mnStrip_expert.Name = "mnStrip_expert";
            this.mnStrip_expert.Size = new System.Drawing.Size(169, 26);
            this.mnStrip_expert.Text = "Expert";
            this.mnStrip_expert.Click += new System.EventHandler(this.mnStrip_expert_Click);
            // 
            // mnStrip_custom
            // 
            this.mnStrip_custom.Name = "mnStrip_custom";
            this.mnStrip_custom.Size = new System.Drawing.Size(169, 26);
            this.mnStrip_custom.Text = "Custom";
            this.mnStrip_custom.Click += new System.EventHandler(this.mnStrip_custom_Click);
            // 
            // mnStrip_bestplayer
            // 
            this.mnStrip_bestplayer.Name = "mnStrip_bestplayer";
            this.mnStrip_bestplayer.Size = new System.Drawing.Size(169, 26);
            this.mnStrip_bestplayer.Text = "Best players";
            this.mnStrip_bestplayer.Click += new System.EventHandler(this.mnStrip_bestplayer_Click);
            // 
            // mnStrip_help
            // 
            this.mnStrip_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnStrip_help.Name = "mnStrip_help";
            this.mnStrip_help.Size = new System.Drawing.Size(53, 24);
            this.mnStrip_help.Text = "Help";
            // 
            // flp
            // 
            this.flp.Controls.Add(this.lbl_Projectname);
            this.flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp.Location = new System.Drawing.Point(0, 28);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(282, 225);
            this.flp.TabIndex = 1;
            // 
            // lbl_Projectname
            // 
            this.lbl_Projectname.AutoSize = true;
            this.lbl_Projectname.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Projectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Projectname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Projectname.Location = new System.Drawing.Point(40, 40);
            this.lbl_Projectname.Margin = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.lbl_Projectname.Name = "lbl_Projectname";
            this.lbl_Projectname.Size = new System.Drawing.Size(203, 116);
            this.lbl_Projectname.TabIndex = 2;
            this.lbl_Projectname.Text = "Minesweeper\r\nProject C# .NET\r\nNguyễn Đình Phi\r\nB1400716";
            this.lbl_Projectname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.Text = "Minesweeper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnStrip_menu;
        private System.Windows.Forms.ToolStripMenuItem mnStrip_beginner;
        private System.Windows.Forms.ToolStripMenuItem mnStrip_intermediate;
        private System.Windows.Forms.ToolStripMenuItem mnStrip_expert;
        private System.Windows.Forms.ToolStripMenuItem mnStrip_custom;
        private System.Windows.Forms.ToolStripMenuItem mnStrip_help;
        private System.Windows.Forms.ToolStripMenuItem mnStrip_new;
        private System.Windows.Forms.ToolStripMenuItem mnStrip_bestplayer;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Label lbl_Projectname;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

