using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildYouOwnCar
{
    public partial class Color : Form
    {
        Car currentCar;
        public Color(Car currentCar)
        {
            this.currentCar = currentCar;
            InitializeComponent();
        }

        private void InizializeColor(List<Color> Colors)
        {

            foreach (Color color in Colors)
            {
                //panelColor
                Panel panelColor = new Panel();
                panelColor.BackColor = System.Drawing.Color.SteelBlue;
                panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panelColor.Cursor = System.Windows.Forms.Cursors.Hand;
                panelColor.Location = new System.Drawing.Point(5, 145);
                panelColor.Margin = new System.Windows.Forms.Padding(5);
                panelColor.Size = new System.Drawing.Size(140, 60);
                panelColor.TabIndex = 4;
                panelColor.Visible = false;

                //pictureBoxColorMark
                PictureBox pictureBoxColorMark = new PictureBox();
                pictureBoxColorMark.Dock = System.Windows.Forms.DockStyle.Left;
                if (Convert.ToInt16(color.Name.Substring(0, 2),16) < 128 && Convert.ToInt16(color.Name.Substring(2, 2),16) < 128 && Convert.ToInt16(color.Name.Substring(4, 2),16) < 128)
                    pictureBoxColorMark.Image = Properties.Resources.BlackCheckMark;
                else
                    pictureBoxColorMark.Image = Properties.Resources.WhiteCheckMark;
                pictureBoxColorMark.Location = new System.Drawing.Point(0, 0);
                pictureBoxColorMark.Margin = new System.Windows.Forms.Padding(2);
                pictureBoxColorMark.Size = new System.Drawing.Size(37, 37);
                pictureBoxColorMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxColorMark.TabIndex = 1;
                pictureBoxColorMark.TabStop = false;

                //labelColorName
                Label labelColorName = new Label();
                labelColorName.AutoSize = true;
                labelColorName.BackColor = System.Drawing.Color.White;
                labelColorName.Dock = System.Windows.Forms.DockStyle.Bottom;
                labelColorName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelColorName.Location = new System.Drawing.Point(0, 37);
                labelColorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                labelColorName.Size = new System.Drawing.Size(61, 21);
                labelColorName.TabIndex = 0;
                labelColorName.Text = color.Name;

                //Добавление элементов на панель
                panelColor.Controls.Add(pictureBoxColorMark);
                panelColor.Controls.Add(labelColorName);
                this.flowLayoutPanelColors.Controls.Add(panelColor);
            }
        }
    }
}
