using System;
using System.Windows.Forms;
using System.IO;

namespace MyGame2
{
    public partial class frm_Main : Form
    {
        const int SizeofCell = 20;

        public struct Score
        {
            public string[] name;
            public int[] time;
            public int count;
        }   

        public static Score[] _score = new Score[3];

        public static Game_Control gc = new Game_Control();

        public frm_Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Read_File();
            this.FormClosed += new FormClosedEventHandler(frm_Main_FormClosed);
        }

        private void Read_File()
        {
            StreamReader r = new StreamReader("..//..//DataScore.txt");
            
            int i = 0;

            while (i < 3)
            {
                _score[i].name = new string[5];
                _score[i].time = new int[5];
                _score[i].count = Int32.Parse(r.ReadLine());

                for (int j = 0; j < _score[i].count; j++)
                {
                    string line = r.ReadLine();

                    int a = 0;

                    while (line[a] != ' ')
                    {
                        _score[i].name[j] += line[a] + "";
                        a++;
                    }

                    _score[i].time[j] = Int32.Parse(line.Substring(a));
                }

                for (int k = _score[i].count; k < 5; k++)
                {
                    _score[i].name[k] = "";
                    _score[i].time[k] = 0;
                }

                int min_index;

                for (int a = 0; a < _score[i].count-1; a++)
                {
                    min_index = a;

                    for (int b = a+1; b < _score[i].count; b++)
                    {
                        if (_score[i].time[b] < _score[i].time[min_index])
                            min_index = b;
                    }

                    if (min_index != a)
                    {
                        int temp_time;
                        string temp_name;

                        temp_time = _score[i].time[min_index];
                        temp_name = _score[i].name[min_index];

                        _score[i].time[min_index] = _score[i].time[a];
                        _score[i].name[min_index] = _score[i].name[a];

                        _score[i].time[a] = temp_time;
                        _score[i].name[a] = temp_name;
                    }
                }
                i++;
            }
            r.Close();
        }

        private void Write_File()
        {
            StreamWriter w = new StreamWriter("..//..//DataScore.txt");

            int i = 0;

            while (i < 3)
            {
                while (_score[i].count > 5)
                    _score[i].count--;

                w.WriteLine(_score[i].count);

                for (int j = 0; j < _score[i].count; j++)
                {
                    string s = _score[i].name[j] + " " + _score[i].time[j];
                    w.WriteLine(s);
                }
                i++;
            }            

            w.Close();
        }

        public void New(int col, int row, int bomb)
        {
            gc = new Game_Control(col, row, bomb);
            this.Height = row * SizeofCell + 95;
            this.Width = col * SizeofCell + 20;
            flp.Controls.Clear();
            flp.Controls.Add(gc);
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Write_File();
        }

        private void mnStrip_beginner_Click(object sender, EventArgs e)
        {
            New(8, 8, 10);
            gc.Mark = 0;
        }

        private void mnStrip_intermediate_Click(object sender, EventArgs e)
        {
            New(16, 16, 40);
            gc.Mark = 1;
        }

        private void mnStrip_expert_Click(object sender, EventArgs e)
        {
            New(30, 16, 99);
            gc.Mark = 2;
        }

        private void mnStrip_custom_Click(object sender, EventArgs e)
        {
            frm_Custom c = new frm_Custom();

            c.ShowDialog();

            if (c.OKwasclicked == true)
            {
                New(gc.Column, gc.Row, gc.Bomb);
            }

            c.Dispose();
        }

        private void mnStrip_new_Click(object sender, EventArgs e)
        {
                New(gc.Column, gc.Row, gc.Bomb);
        }

        private void mnStrip_bestplayer_Click(object sender, EventArgs e)
        {
            frm_Score sc = new frm_Score();
            sc.ShowDialog();
            sc.Dispose();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label howtoplay = new Label();

            howtoplay.Text = "Use the left mouse button to open a cell and you will get 1 of 3 situations:"
                           + "\n1.That cell is containing bomb: all bombs are showed up and you lose the game."
                           + "\n2.The number of bombs is showed and tells you how many bombs in 8 neighbour cells around it."
                           + "\n3.That cell is empty, it will open 8 neighbour cells around it automatically."
                           + "\nUse that infomation to guess where bombs is."
                           + "\nUse the right mouse button to set flag if you know a cell is containing bomb.";
            howtoplay.AutoSize = true;
            this.Width = 400;

            flp.Controls.Clear();
            flp.Controls.Add(howtoplay);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Label about = new Label();

            about.Text = "Minesweeper is a single-player computer game. \nIt is built and installed on Windows. However, it is said to be derived from the game Cube (1973).";
            about.AutoSize = true;

            flp.Controls.Clear();
            flp.Controls.Add(about);
        }
    }
}
