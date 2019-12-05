using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsLainers
{
    class Lainer
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int shipWidth = 100;
        private const int shipHeight = 60;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Jakor { private set; get; }
        public bool Truba { private set; get; }
        public bool Flag { private set; get; }
        public bool Okna { private set; get; }
        public Lainer(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool jakor, bool flag, bool truba, bool okna)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Jakor = jakor;
            Truba = truba;
            Flag = flag;
            Okna = okna;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                 case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                 case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            
            if (Jakor)
            {
                g.DrawLine(pen, _startPosX + 95, _startPosY + 30, _startPosX + 95, _startPosY + 50);
                g.DrawLine(pen, _startPosX + 95, _startPosY + 50, _startPosX + 100, _startPosY + 45);
                g.DrawLine(pen, _startPosX + 95, _startPosY + 50, _startPosX + 90, _startPosY + 45);
            }

            if (Flag)
            {
                g.DrawLine(pen, _startPosX + 100, _startPosY + 30, _startPosX + 100, _startPosY + 15);
                Brush ar = new SolidBrush(Color.DarkGreen);
                g.FillRectangle(ar, _startPosX + 90, _startPosY + 15, 10, 10);
                g.DrawLine(pen, _startPosX + 90, _startPosY + 15, _startPosX + 100, _startPosY + 25);
                g.DrawLine(pen, _startPosX + 90, _startPosY + 25, _startPosX + 100, _startPosY + 15);

            }

            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY + 30, 100, 10);
            g.FillRectangle(br, _startPosX, _startPosY + 40, 80, 10);
            g.FillRectangle(br, _startPosX + 5, _startPosY + 50, 70, 10);

            Brush brGrey = new SolidBrush(DopColor);
            g.FillRectangle(brGrey, _startPosX + 5, _startPosY + 20, 65, 10);

            if (Okna)
            {
                g.FillRectangle(brGrey, _startPosX + 7, _startPosY + 10, 55, 10);
                Brush brBlue = new SolidBrush(Color.Blue);
                g.FillRectangle(brBlue, _startPosX + 10, _startPosY + 22, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 22, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 30, _startPosY + 22, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 40, _startPosY + 22, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 50, _startPosY + 22, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 60, _startPosY + 22, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 10, _startPosY + 11 + 2, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 11 + 2, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 30, _startPosY + 11 + 2, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 40, _startPosY + 11 + 2, 5, 5);
                g.FillRectangle(brBlue, _startPosX + 50, _startPosY + 11 + 2, 5, 5);
            }
            
            if (Truba)
            {
                Brush truba = new SolidBrush(Color.Black);
                g.FillRectangle(truba, _startPosX + 15, _startPosY, 10, 10);
                g.FillRectangle(truba, _startPosX + 30, _startPosY, 10, 10);
                g.FillRectangle(truba, _startPosX + 45, _startPosY, 10, 10);

            }
        }
    }
}
