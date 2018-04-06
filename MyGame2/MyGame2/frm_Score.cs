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
    public partial class frm_Score : Form
    {
        public frm_Score()
        {
            InitializeComponent();
        }

        private void frm_Score_Load(object sender, EventArgs e)
        {
            int min_index;
            int x = 0;
            while (x < 3)
            {
                for (int i = 0; i < frm_Main._score[x].count - 1; i++)
                {
                    min_index = i;

                    for (int j = i+1; j < frm_Main._score[x].count; j++)
                    {
                        if (frm_Main._score[x].time[j] < frm_Main._score[x].time[min_index])
                            min_index = j;
                    }

                    if (min_index != i)
                    {
                        int temp_time;
                        string temp_name;

                        temp_time = frm_Main._score[x].time[min_index];
                        temp_name = frm_Main._score[x].name[min_index];

                        frm_Main._score[x].time[min_index] = frm_Main._score[x].time[i];
                        frm_Main._score[x].name[min_index] = frm_Main._score[x].name[i];

                        frm_Main._score[x].time[i] = temp_time;
                        frm_Main._score[x].name[i] = temp_name;
                    }
                }

                x++;
            }

            lbl_b1.Text = frm_Main._score[0].time[0] + " " + frm_Main._score[0].name[0];
            lbl_b2.Text = frm_Main._score[0].time[1] + " " + frm_Main._score[0].name[1];
            lbl_b3.Text = frm_Main._score[0].time[2] + " " + frm_Main._score[0].name[2];
            lbl_b4.Text = frm_Main._score[0].time[3] + " " + frm_Main._score[0].name[3];
            lbl_b5.Text = frm_Main._score[0].time[4] + " " + frm_Main._score[0].name[4];

            lbl_i1.Text = frm_Main._score[1].time[0] + " " + frm_Main._score[1].name[0];
            lbl_i2.Text = frm_Main._score[1].time[1] + " " + frm_Main._score[1].name[1];
            lbl_i3.Text = frm_Main._score[1].time[2] + " " + frm_Main._score[1].name[2];
            lbl_i4.Text = frm_Main._score[1].time[3] + " " + frm_Main._score[1].name[3];
            lbl_i5.Text = frm_Main._score[1].time[4] + " " + frm_Main._score[1].name[4];

            lbl_e1.Text = frm_Main._score[2].time[0] + " " + frm_Main._score[2].name[0];
            lbl_e2.Text = frm_Main._score[2].time[1] + " " + frm_Main._score[2].name[1];
            lbl_e3.Text = frm_Main._score[2].time[2] + " " + frm_Main._score[2].name[2];
            lbl_e4.Text = frm_Main._score[2].time[3] + " " + frm_Main._score[2].name[3];
            lbl_e5.Text = frm_Main._score[2].time[4] + " " + frm_Main._score[2].name[4];
        }
    }
}
