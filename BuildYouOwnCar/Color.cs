using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildYouOwnCar
{
    public partial class Color : Form
    {
        Car currentCar;
        List<Model.Color> availableColors;
        public Color(Car currentCar)
        {
            this.currentCar = currentCar;
            this.availableColors = currentCar.GetAvailableColors();
            InitializeComponent();
            InitializeCar(currentCar);
            InitializeColor(availableColors);
        }
        private void InitializeCar(Car car)
        {
            pictureBoxCar.ImageLocation = $@"..\..\Images\{car.Images.Front}";
            pictureBoxCar.ErrorImage = Properties.Resources.NoFound404;
            pictureBoxCar.InitialImage = Properties.Resources.CarLoading_Orange;

            this.labelCarName.Text = $"Создай свою мечту {car.Name}";
        }
        private void InitializeColor(List<Model.Color> Colors)
        {
            this.flowLayoutPanelColors.Controls.Clear();
            foreach (var color in Colors)
            {
                //panelColor
                Panel panelColor = new Panel();
                panelColor.BackColor = System.Drawing.Color.FromArgb(
                    Convert.ToInt16(color.RGB.Substring(0, 2),16), 
                    Convert.ToInt16(color.RGB.Substring(2, 2), 16), 
                    Convert.ToInt16(color.RGB.Substring(4, 2),16));
                panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panelColor.Cursor = System.Windows.Forms.Cursors.Hand;
                panelColor.Margin = new System.Windows.Forms.Padding(5);
                panelColor.Size = new System.Drawing.Size(140, 60);
                panelColor.TabIndex = 4;
                panelColor.Click += (object sender, EventArgs e) => SetColor(color);
                panelColor.Name = $"panelColor_{color.Id}";

                //pictureBoxColorMark
                PictureBox pictureBoxColorMark = new PictureBox();
                pictureBoxColorMark.Dock = System.Windows.Forms.DockStyle.Left;
                if (Convert.ToInt16(color.RGB.Substring(0, 2),16) < 128 &&
                    Convert.ToInt16(color.RGB.Substring(2, 2),16) < 128 &&
                    Convert.ToInt16(color.RGB.Substring(4, 2),16) < 128)
                    pictureBoxColorMark.Image = Properties.Resources.WhiteCheckMark;
                else
                    pictureBoxColorMark.Image = Properties.Resources.BlackCheckMark;
                pictureBoxColorMark.Location = new System.Drawing.Point(0, 0);
                pictureBoxColorMark.Margin = new System.Windows.Forms.Padding(2);
                pictureBoxColorMark.Size = new System.Drawing.Size(37, 37);
                pictureBoxColorMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxColorMark.TabIndex = 1;
                pictureBoxColorMark.TabStop = false;
                if (currentCar.color.Id == color.Id)
                    pictureBoxColorMark.Visible = true;
                else
                    pictureBoxColorMark.Visible = false;
                pictureBoxColorMark.Name = $"colorMark_{color.Id}";

                //labelColorName
                Label labelColorName = new Label();
                labelColorName.AutoSize = true;
                labelColorName.BackColor = System.Drawing.Color.White;
                labelColorName.Dock = System.Windows.Forms.DockStyle.Bottom;
                labelColorName.Font = new System.Drawing.Font("Microsoft YaHei", 12F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                    ((byte)(204)));
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
        private void SetColor(Model.Color newColor)
        {
            currentCar.SetColor(newColor);
            foreach (Panel colorPanel in flowLayoutPanelColors.Controls)
            {
                foreach (var el in colorPanel.Controls)
                {
                    if (el is PictureBox mark)
                    {
                        if (mark.Name == $"colorMark_{newColor.Id}")
                            mark.Visible = true;
                        else
                            mark.Visible = false;
                    }
                }
            }
            InitializeCar(currentCar);
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            currentCar.ResetColor();

            BuildYouOwnCar.MainForm MainForm = new BuildYouOwnCar.MainForm();
            MainForm.StartPosition = this.StartPosition;
            MainForm.Location = this.Location;
            MainForm.WindowState = this.WindowState;

            this.Hide();
            MainForm.Show();
        }
        private void buttoGoNext_Click(object sender, EventArgs e)
        {
            BuildYouOwnCar.Wheels WheelsForm = new BuildYouOwnCar.Wheels(currentCar);
            WheelsForm.StartPosition = this.StartPosition;
            WheelsForm.Location = this.Location;
            WheelsForm.WindowState = this.WindowState;

            this.Hide();
            WheelsForm.Show();
        }
    }
}
