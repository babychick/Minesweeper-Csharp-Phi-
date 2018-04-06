namespace MyGame2
{
    partial class frm_Custom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Custom));
            this.lbl_Col = new System.Windows.Forms.Label();
            this.lbl_Row = new System.Windows.Forms.Label();
            this.lbl_Bomb = new System.Windows.Forms.Label();
            this.nud_col = new System.Windows.Forms.NumericUpDown();
            this.nud_bomb = new System.Windows.Forms.NumericUpDown();
            this.nud_row = new System.Windows.Forms.NumericUpDown();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Customsetting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_col)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_row)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Col
            // 
            this.lbl_Col.AutoSize = true;
            this.lbl_Col.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Col.Location = new System.Drawing.Point(42, 52);
            this.lbl_Col.Name = "lbl_Col";
            this.lbl_Col.Size = new System.Drawing.Size(72, 20);
            this.lbl_Col.TabIndex = 0;
            this.lbl_Col.Text = "Column";
            // 
            // lbl_Row
            // 
            this.lbl_Row.AutoSize = true;
            this.lbl_Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Row.Location = new System.Drawing.Point(42, 85);
            this.lbl_Row.Name = "lbl_Row";
            this.lbl_Row.Size = new System.Drawing.Size(45, 20);
            this.lbl_Row.TabIndex = 1;
            this.lbl_Row.Text = "Row";
            // 
            // lbl_Bomb
            // 
            this.lbl_Bomb.AutoSize = true;
            this.lbl_Bomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bomb.Location = new System.Drawing.Point(42, 118);
            this.lbl_Bomb.Name = "lbl_Bomb";
            this.lbl_Bomb.Size = new System.Drawing.Size(57, 20);
            this.lbl_Bomb.TabIndex = 2;
            this.lbl_Bomb.Text = "Bomb";
            // 
            // nud_col
            // 
            this.nud_col.Location = new System.Drawing.Point(120, 51);
            this.nud_col.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_col.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_col.Name = "nud_col";
            this.nud_col.Size = new System.Drawing.Size(120, 22);
            this.nud_col.TabIndex = 3;
            this.nud_col.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nud_bomb
            // 
            this.nud_bomb.Location = new System.Drawing.Point(120, 117);
            this.nud_bomb.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_bomb.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_bomb.Name = "nud_bomb";
            this.nud_bomb.Size = new System.Drawing.Size(120, 22);
            this.nud_bomb.TabIndex = 4;
            this.nud_bomb.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nud_row
            // 
            this.nud_row.Location = new System.Drawing.Point(120, 84);
            this.nud_row.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nud_row.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_row.Name = "nud_row";
            this.nud_row.Size = new System.Drawing.Size(120, 22);
            this.nud_row.TabIndex = 5;
            this.nud_row.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(58, 168);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 25);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(153, 168);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 25);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Customsetting
            // 
            this.lbl_Customsetting.AutoSize = true;
            this.lbl_Customsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customsetting.Location = new System.Drawing.Point(72, 12);
            this.lbl_Customsetting.Name = "lbl_Customsetting";
            this.lbl_Customsetting.Size = new System.Drawing.Size(146, 25);
            this.lbl_Customsetting.TabIndex = 8;
            this.lbl_Customsetting.Text = "Custom Setting";
            // 
            // frm_Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 213);
            this.Controls.Add(this.lbl_Customsetting);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.nud_row);
            this.Controls.Add(this.nud_bomb);
            this.Controls.Add(this.nud_col);
            this.Controls.Add(this.lbl_Bomb);
            this.Controls.Add(this.lbl_Row);
            this.Controls.Add(this.lbl_Col);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Custom";
            this.Text = "Custom";
            ((System.ComponentModel.ISupportInitialize)(this.nud_col)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_row)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Col;
        private System.Windows.Forms.Label lbl_Row;
        private System.Windows.Forms.Label lbl_Bomb;
        private System.Windows.Forms.NumericUpDown nud_col;
        private System.Windows.Forms.NumericUpDown nud_bomb;
        private System.Windows.Forms.NumericUpDown nud_row;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Customsetting;
    }
}