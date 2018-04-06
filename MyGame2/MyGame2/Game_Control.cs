using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MyGame2
{
    public partial class Game_Control : UserControl
    {
        const int SizeofCell = 20;

        private int mark;

        int count = 0;

        public static string name = "";

        MineMatrix matrix;
    
        public Game_Control()
        {
            InitializeComponent();

            matrix = new MineMatrix(10, 10, 10);

            lbl_flagCounter.Text = "0" + matrix.Numofflag.ToString();
            lbl_flagCounter.TextAlign = ContentAlignment.MiddleCenter;

            this.Height = matrix.Row * SizeofCell + 25;
            this.Width = matrix.Column * SizeofCell;

            lbl_flag.Location = new Point(this.Width - (lbl_flag.Width + lbl_flagCounter.Width) + 7, 0);
            lbl_flagCounter.Location = new Point(this.Width - lbl_flagCounter.Width, 0);

            matrix.Create_Matrix();
        }

        public Game_Control(int col, int row, int bomb)
        {
            InitializeComponent();

            Mark = mark;

            matrix = new MineMatrix(col, row, bomb);

            lbl_flagCounter.Text = "0" + matrix.Numofflag.ToString();
            lbl_flagCounter.TextAlign = ContentAlignment.MiddleCenter;

            this.Height = matrix.Row * SizeofCell + 25;
            this.Width = matrix.Column * SizeofCell;

            lbl_flag.Location = new Point(this.Width - (lbl_flag.Width + lbl_flagCounter.Width), 0);
            lbl_flagCounter.Location = new Point(this.Width - lbl_flagCounter.Width, 0);

            matrix.Create_Matrix();
        }

        public int Column
        {
            get { return matrix.Column; }
        }

        public int Row
        {
            get { return matrix.Row; }
        }

        public int Bomb
        {
            get { return matrix.Numofmines; }
        }

        public int Numofflag
        {
            get { return matrix.Numofflag; }
        }

        public int Mark
        {
            get { return mark; }

            set { mark = value; }
        }

        public void RedrawCell (Graphics g, int x, int y)
        {
            int ix = x * SizeofCell;
            int iy = y * SizeofCell + 25;

            if (matrix.Lose == false)
            {
                if (matrix[x, y].Opened == true && matrix[x, y].Isshown == false)
                {
                    g.DrawImage(matrix[x, y].Image, ix, iy);
                    matrix[x, y].Isshown = true;

                    int up = y - 1;
                    int down = y + 1;
                    int left = x - 1;
                    int right = x + 1;

                    if (left >= 0)
                    {
                        RedrawCell(g, left, y);

                        if (up >= 0)
                            RedrawCell(g, left, up);
                        if (down < Row)
                            RedrawCell(g, left, down);
                    }

                    if (right < Column)
                    {
                        RedrawCell(g, right, y);

                        if (up >= 0)
                            RedrawCell(g, right, up);
                        if (down < Row)
                            RedrawCell(g, right, down);
                    }
                }
            }
            else
            {
                ShowBomb(g);
            }
        }

        public void ShowBomb (Graphics g)
        {
            for (int i = 0; i < matrix.Numofmines; i++)
            {
                int a = matrix.Bombx[i];
                int b = matrix.Bomby[i];
                int ix = a * SizeofCell;
                int iy = b * SizeofCell + 25;
                g.DrawImage(matrix[a, b].Image, ix, iy);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            Graphics g = CreateGraphics();

            timer1.Start();
            int x = e.X / SizeofCell;
            int y = (e.Y - 25) / SizeofCell;

            if (e.Button == MouseButtons.Left)
            {
                if (matrix[x, y].Opened == false && matrix[x, y].Flagged == false)
                {
                    matrix.Open_Cell(x, y);
                    RedrawCell(g, x, y);
                }

                //Invalidate();

                if (matrix.Finish == true)
                {
                    timer1.Stop();
                    this.Enabled = false;
                    if (MessageBox.Show("You Win", "Result") == DialogResult.OK)
                    {
                        frm_Record rc = new frm_Record();
                        rc.ShowDialog();

                        if (name != "")
                        {
                            frm_Main._score[Mark].count++;
                            Array.Resize(ref frm_Main._score[Mark].name, frm_Main._score[Mark].count);
                            Array.Resize(ref frm_Main._score[Mark].time, frm_Main._score[Mark].count);
                            frm_Main._score[Mark].name[frm_Main._score[Mark].count - 1] = name;
                            frm_Main._score[Mark].time[frm_Main._score[Mark].count - 1] = count;
                        }

                        rc.Dispose();
                    }
                    timer1.Dispose();
                }

                if (matrix.Lose == true)
                {
                    timer1.Stop();
                    panel1.Enabled = false;
                    MessageBox.Show("You Lose", "Result");
                    timer1.Dispose();
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                matrix.Set_Flag(x, y);
                g.DrawImage(matrix[x, y].Image, x * SizeofCell, y * SizeofCell + 25);
                if (matrix.Numofflag >= 10)
                    lbl_flagCounter.Text = "0" + matrix.Numofflag.ToString();
                else
                    lbl_flagCounter.Text = "00" + matrix.Numofflag.ToString();
                //Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle r = new Rectangle(0, 0, this.Width, this.Height + 25);

            Pen p = new Pen(Color.White, 1);

            e.Graphics.DrawRectangle(p, r);

            int x, y;

            for (int i = 0; i < matrix.Column; i++)
            {
                x = i * SizeofCell;

                for (int j = 0; j < matrix.Row; j++)
                {
                    y = j * SizeofCell + 25;

                    e.Graphics.DrawImage(matrix[i, j].Image, x, y);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count >= 100)
            {
                lbl_timeCounter.Text = count + "";
            }
            else if (count >= 10)
            {
                lbl_timeCounter.Text = "0" + count;
            }
            else
            {
                lbl_timeCounter.Text = "00" + count;
            }

            if (count == 999)
            {
                MessageBox.Show("Time out!", "Result");
            }

        }
    }
}
