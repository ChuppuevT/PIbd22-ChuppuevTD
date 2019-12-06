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
        MultiLevelPier pier;
        private const int countLevel = 5;

        public FormPier()
        {
            InitializeComponent();
            pier = new MultiLevelPier(countLevel, pictureBoxPier.Width,
           pictureBoxPier.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxPier.Width, pictureBoxPier.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pier[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxPier.Image = bmp;
            }
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Ship(100, 1000, dialog.Color);
                    int place = pier[listBoxLevels.SelectedIndex] + ship;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void buttonSetLainer_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var ship = new Lainer(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, true, true);
                        int place = pier[listBoxLevels.SelectedIndex] + ship;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var ship = pier[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
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

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
