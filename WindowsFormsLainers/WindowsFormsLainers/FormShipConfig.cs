using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLainers
{
    public partial class FormShipConfig : Form
    {
        ITransport ship = null;
        private event shipDelegate eventAddShip;

        public FormShipConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 5, pictureBoxShip.Width, pictureBoxShip.Height);
                ship.DrawShip(gr);
                pictureBoxShip.Image = bmp;
            }
        }

        public void AddEvent(shipDelegate ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new shipDelegate(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }

        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelLainer_MouseDown(object sender, MouseEventArgs e)
        {
            labelLainer.DoDragDrop(labelLainer.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    ship = new Ship(100, 500, Color.White);
                    break;
                case "Лайнер":
                    ship = new Lainer(100, 500, Color.White, Color.Black, true, true,
                   true, true);
                    break;
            }
            DrawShip();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is Lainer)
                {
                    (ship as Lainer).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }
    }
}
