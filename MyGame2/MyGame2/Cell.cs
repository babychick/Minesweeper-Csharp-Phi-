using System.Drawing;

namespace MyGame2
{
    class Cell
    {
        private bool _Opened;
        private bool _Flagged;
        private bool _Minestate;
        private int _Mines;
        private Image _image;
        private int _x; // location
        private int _y; // location
        private bool _isshown;

        public bool Opened
        {
            get { return _Opened; }

            set { _Opened = value; }
        }

        public bool Flagged
        {
            get { return _Flagged; }

            set { _Flagged = value; }
        }

        public bool Minestate
        {
            get { return _Minestate; }

            set { _Minestate = value; }
        }

        public int Mines
        {
            get { return _Mines; }

            set { _Mines = value; }
        }

        public Image Image
        {
            get { return _image; }

            set { _image = value; }
        }

        public int X
        {
            get { return _x;  }

            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }

            set { _y = value; }
        }

        public bool Isshown { get => _isshown; set => _isshown = value; }

        public Cell()
        {
            _Opened = false;
            _Flagged = false;
            _Minestate = false;
            _Mines = 0;
            _x = -1;
            _y = -1;
            Isshown = false;
            _image = new Bitmap(Properties.Resources.cell);
        }

        public Cell(bool Opened, bool Flagged, bool Minestate, int Mines, int x, int y, bool isshown)
        {
            _Opened = Opened;
            _Flagged = Flagged;
            _Minestate = Minestate;
            _Mines = Mines;
            _x = x;
            _y = y;
            Isshown = isshown;
            _image = new Bitmap(Properties.Resources.cell);
        }
    }
}
