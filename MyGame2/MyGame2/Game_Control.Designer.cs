namespace MyGame2
{
    partial class Game_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_timeCounter = new System.Windows.Forms.Label();
            this.lbl_flagCounter = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_flag = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_timeCounter
            // 
            this.lbl_timeCounter.AutoSize = true;
            this.lbl_timeCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_timeCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeCounter.ForeColor = System.Drawing.Color.Brown;
            this.lbl_timeCounter.Location = new System.Drawing.Point(45, 0);
            this.lbl_timeCounter.Name = "lbl_timeCounter";
            this.lbl_timeCounter.Size = new System.Drawing.Size(38, 22);
            this.lbl_timeCounter.TabIndex = 0;
            this.lbl_timeCounter.Text = "000";
            this.lbl_timeCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_flagCounter
            // 
            this.lbl_flagCounter.AutoSize = true;
            this.lbl_flagCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_flagCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flagCounter.ForeColor = System.Drawing.Color.Red;
            this.lbl_flagCounter.Location = new System.Drawing.Point(199, 0);
            this.lbl_flagCounter.Name = "lbl_flagCounter";
            this.lbl_flagCounter.Size = new System.Drawing.Size(38, 22);
            this.lbl_flagCounter.TabIndex = 1;
            this.lbl_flagCounter.Text = "000";
            this.lbl_flagCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(3, 2);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(39, 17);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "Time";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_flag
            // 
            this.lbl_flag.AutoSize = true;
            this.lbl_flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flag.Location = new System.Drawing.Point(161, 3);
            this.lbl_flag.Name = "lbl_flag";
            this.lbl_flag.Size = new System.Drawing.Size(35, 17);
            this.lbl_flag.TabIndex = 3;
            this.lbl_flag.Text = "Flag";
            this.lbl_flag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_flagCounter);
            this.panel1.Controls.Add(this.lbl_flag);
            this.panel1.Controls.Add(this.lbl_timeCounter);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 23);
            this.panel1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Game_Control";
            this.Size = new System.Drawing.Size(240, 188);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_timeCounter;
        private System.Windows.Forms.Label lbl_flagCounter;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_flag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}
