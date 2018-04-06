using System;
using System.Drawing;

namespace MyGame2
{
    class MineMatrix
    {
        const int SizeofCell = 20;

        Image[] numbers = { new Bitmap(Properties.Resources._1),
                            new Bitmap(Properties.Resources._2),
                            new Bitmap(Properties.Resources._3),
                            new Bitmap(Properties.Resources._4),
                            new Bitmap(Properties.Resources._5),
                            new Bitmap(Properties.Resources._6),
                            new Bitmap(Properties.Resources._7),
                            new Bitmap(Properties.Resources._8),};

        Image Image_cell = new Bitmap(Properties.Resources.cell);
        Image Image_flag = new Bitmap(Properties.Resources.flag);
        Image Image_bomb = new Bitmap(Properties.Resources.bomb);
        Image Image_opendcell = new Bitmap(Properties.Resources.openedcell);

        Cell[,] _matrix;

        private int _column;
        private int _row;
        private int _numofmines;
        private int _numofflag;
        private bool _lose;
        private bool _finish;
        private int[] _bombx;
        private int[] _bomby;

        public Cell this[int x, int y]
        {
            get { return _matrix[x, y]; }
        }

        public int Column
        {
            get { return _column; }

            set { _column = value; }
        }

        public int Row
        {
            get { return _row; }

            set { _row = value; }
        }

        public bool Lose
        {
            get { return _lose; }

            set { _lose = value; }
        }

        public int Numofmines
        {
            get { return _numofmines; }

            set { _numofmines = value; }
        }

        public int Numofflag
        {
            get { return _numofflag; }

            set { _numofflag = value; }
        }

        public bool Finish
        {
            get { return _finish; }

            set { _finish = value; }
        }

        public int[] Bombx
        {
            get { return _bombx; }

            set { _bombx = value; }
        }

        public int[] Bomby
        {
            get { return _bomby; }

            set { _bomby = value; }
        }

        public MineMatrix()
        {
            _column = 1;
            _row = 1;
            _lose = false;
            _finish = false;
            _numofmines = (_column * _row) / 10;
            _numofflag = _numofmines;
            _matrix = new Cell[Column, Row];
            _bombx = new int[_numofmines];
            _bomby = new int[_numofmines];
        }

        public MineMatrix(int col, int row, int bomb)
        {
            _column = col;
            _row = row;
            _matrix = new Cell[col, row];
            _numofmines = bomb;
            _numofflag = _numofmines;
            _lose = false;
            _finish = false;
            _bombx = new int[_numofmines];
            _bomby = new int[_numofmines];
        }

        public void Create_Matrix()
        {
            for (int i = 0; i < Column; i++) //3
            {
                for (int j = 0; j < Row; j++) //3
                {
                    _matrix[i, j] = new Cell();
                }
            }

            int bomb = Numofmines;
            int count = 0;
            while (bomb > 0)
            {
                Random r = new Random();
                int x, y;
                do
                {
                    x = r.Next(0, Column);
                    y = r.Next(0, Row);

                } while (_matrix[x, y].Minestate == true);

                _matrix[x, y].Minestate = true;

                _bombx[count] = x;
                _bomby[count] = y;
                count++;

                bomb--;

                Mines_Around(x, y);
            }
        }

        public void Mines_Around(int x, int y)
        {
            int up = y - 1;
            int down = y + 1;
            int left = x - 1;
            int right = x + 1;

            if (left >= 0)
            {
                _matrix[left, y].Mines++;

                if (up >= 0)
                    _matrix[left, up].Mines++;
                if (down < Row)
                    _matrix[left, down].Mines++;
            }

            if (right < Column)
            {
                _matrix[right, y].Mines++;

                if (up >= 0)
                    _matrix[right, up].Mines++;
                if (down < Row)
                    _matrix[right, down].Mines++;
            }

            if (up >= 0)
                _matrix[x, up].Mines++;

            if (down < Row)
                _matrix[x, down].Mines++;
        }

        public void Show_all_Bomb()
        {
            //for (int i = 0; i < Column; i++)
            //    for (int j = 0; j < Row; j++)
            //        if (_matrix[i, j].Minestate == true)
            //            _matrix[i, j].Image = Image_bomb;
            for (int i = 0; i < _numofmines; i++)
                _matrix[_bombx[i], _bomby[i]].Image = Image_bomb;
        }

        public void Open_Cell(int x, int y)
        {
            if (_matrix[x, y].Opened == false)
            {
                _matrix[x, y].Opened = true;
                
                if (_matrix[x, y].Minestate == false)
                {
                    if (_matrix[x, y].Mines == 0)
                    {
                        _matrix[x, y].Image = Image_opendcell;
                        
                        int up = y - 1;
                        int down = y + 1;
                        int left = x - 1;
                        int right = x + 1;

                        if (left >= 0)
                        {
                            Open_Cell(left, y);

                            if (up >= 0)
                                Open_Cell(left, up);
                            if (down < Row)
                                Open_Cell(left, down);
                        }

                        if (right < Column)
                        {
                            Open_Cell(right, y);

                            if (up >= 0)
                                Open_Cell(right, up);
                            if (down < Row)
                                Open_Cell(right, down);
                        }

                        if (up >= 0)
                            Open_Cell(x, up);

                        if (down < Row)
                            Open_Cell(x, down);
                    }

                    if (_matrix[x, y].Mines > 0)
                        _matrix[x, y].Image = numbers[_matrix[x, y].Mines - 1];
                }

                else
                {
                    Show_all_Bomb();
                    Lose = true;
                }

                if (Win() == Numofmines)
                {
                    Show_All_Flag();
                    Finish = true;
                }
            }
        }

        public int Win()
        {
            int count = 0;

            for (int i = 0; i < Column; i++)
                for (int j = 0; j < Row; j++)
                    if (_matrix[i, j].Opened == false)
                        count++;
            return count;
        }

        public void Show_All_Flag()
        {
            for (int i = 0; i < Column; i++)
                for (int j = 0; j < Row; j++)
                    if (_matrix[i, j].Minestate == true && _matrix[i,j].Opened == false)
                    {
                        _matrix[i, j].Flagged = true;
                        _matrix[i, j].Image = Image_flag;
                    }
        }

        public void Set_Flag(int x, int y)
        {
            if (_matrix[x, y].Opened == false)
            {
                if (_matrix[x, y].Flagged == false)
                {
                    _matrix[x, y].Flagged = true;
                    _matrix[x, y].Image = Image_flag;
                    Numofflag--;
                }
                else
                {
                    _matrix[x, y].Flagged = false;
                    _matrix[x, y].Image = Image_cell;
                    Numofflag++;
                }
            }
        }
    }
}
