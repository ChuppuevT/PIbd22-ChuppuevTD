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
    public partial class FormPier : Form
    {
        Pier<ITransport> pier;
        public FormPier()
        {
            InitializeComponent();
            pier = new Pier<ITransport>(20, pictureBoxPier.Width, pictureBoxPier.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPier.Width, pictureBoxPier.Height);
            Graphics gr = Graphics.FromImage(bmp);
            pier.Draw(gr);
            pictureBoxPier.Image = bmp;
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                int place = pier + ship;
                Draw();
            }
        }

        private void buttonSetLainer_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Lainer(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true, true);
                    int place = pier + ship;
                    Draw();
                }
            }
        }

        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var ship = pier - Convert.ToInt32(maskedTextBox.Text);
                if (ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                   pictureBoxTakeShip.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.SetPosition(5, 5, pictureBoxTakeShip.Width,
                   pictureBoxTakeShip.Height);
                    ship.DrawShip(gr);
                    pictureBoxTakeShip.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                   pictureBoxTakeShip.Height);
                    pictureBoxTakeShip.Image = bmp;
                }
                Draw();
            }
        }
    }
}
