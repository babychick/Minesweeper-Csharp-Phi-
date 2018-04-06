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
    public partial class frm_Record : Form
    {
        public frm_Record()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtbox_typename.Text != "")
            {
                if (txtbox_typename.Text.Contains(' '))
                {
                    MessageBox.Show("Type your name without spaces!", "Attention");
                    frm_Record r = new frm_Record();
                    r.ShowDialog();
                }
                else
                    Game_Control.name = txtbox_typename.Text;
            }
                
            else
                Game_Control.name = "";

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
