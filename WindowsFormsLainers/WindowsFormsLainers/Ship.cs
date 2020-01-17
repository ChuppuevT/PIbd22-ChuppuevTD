using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLainers
{
    class Ship: Vehicle
    {
        protected const int shipWidth = 100;
        protected const int shipHeight = 60;
        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо 
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево 
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх 
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз 
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawShip(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY + 30, 100, 10);
            g.FillRectangle(br, _startPosX, _startPosY + 40, 80, 10);
            g.FillRectangle(br, _startPosX + 5, _startPosY + 50, 70, 10);
            Brush brGrey = new SolidBrush(Color.Gray);
            g.FillRectangle(brGrey, _startPosX + 5, _startPosY + 20, 65, 10);
        }
    }
}
