using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsLainers
{
    class Lainer: Ship, IComparable<Lainer>, IEquatable<Lainer>
    {
        public Color DopColor { private set; get; }
        public bool Jakor { private set; get; }
        public bool Truba { private set; get; }
        public bool Flag { private set; get; }
        public bool Okna { private set; get; }
        public Lainer(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool jakor, bool flag, bool truba, bool okna): base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Jakor = jakor;
            Truba = truba;
            Flag = flag;
            Okna = okna;
            Random rnd = new Random();
        }
        public Lainer(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Jakor = Convert.ToBoolean(strs[4]);
                Truba = Convert.ToBoolean(strs[5]);
                Flag = Convert.ToBoolean(strs[6]);
            }
        }
        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            base.DrawShip(g);
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
            
            Brush brGrey = new SolidBrush(DopColor);
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

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Jakor + ";" +
           Truba + ";" + Flag;
        }

        public int CompareTo(Lainer other)
        {
            var res = (this is Ship).CompareTo(other is Ship);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Jakor != other.Jakor)
            {
                return Jakor.CompareTo(other.Jakor);
            }
            if (Truba != other.Truba)
            {
                return Truba.CompareTo(other.Truba);
            }
            if (Flag != other.Flag)
            {
                return Flag.CompareTo(other.Flag);
            }
            return 0;
        }
        
        public bool Equals(Lainer other)
        {
            var res = (this as Ship).Equals(other as Ship);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Jakor != other.Jakor)
            {
                return false;
            }
            if (Truba != other.Truba)
            {
                return false;
            }
            if (Flag != other.Flag)
            {
                return false;
            }
            return true;
        }
        
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Lainer shipObj))
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
