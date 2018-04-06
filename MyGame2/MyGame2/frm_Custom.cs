using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame2
{
    public partial class frm_Custom : Form
    {
        public bool OKwasclicked = false;

        public frm_Custom()
        {
            InitializeComponent();
        }

        public void btn_OK_Click(object sender, EventArgs e)
        {
            OKwasclicked = true;

            if (nud_bomb.Value > (nud_col.Value * nud_row.Value / 10))
            {
                MessageBox.Show("Bomb <= (Column*Row)/10", "Attention");
            }
            else
            {
                int col = int.Parse(nud_col.Value.ToString());
                int row = int.Parse(nud_row.Value.ToString());
                int bomb = int.Parse(nud_bomb.Value.ToString());

                frm_Main.gc = new Game_Control(col, row, bomb);

                this.Close();
            }
        }

        public void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
