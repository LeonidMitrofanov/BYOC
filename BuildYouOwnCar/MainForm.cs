using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BuildYouOwnCar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InizializeCars(Car.GetAll());
        }
        private void InizializeCars(List<Car> Cars)
        {
            this.flowLayoutPanelAllCars.Controls.Clear();
            foreach (var car in Cars)
            {
                //panelCar
                Panel panelCar = new Panel();
                panelCar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                panelCar.BackColor = System.Drawing.Color.Maroon;
                panelCar.Cursor = System.Windows.Forms.Cursors.Hand;
                panelCar.Location = new System.Drawing.Point(5, 5);
                panelCar.Margin = new System.Windows.Forms.Padding(5);
                //panelCar.Name = "panelCar";
                panelCar.Size = new System.Drawing.Size(310, 218);
                panelCar.TabIndex = 0;

                //labelCarName
                Label labelCar = new Label();
                labelCar.AutoSize = true;
                labelCar.Dock = System.Windows.Forms.DockStyle.Fill;
                labelCar.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelCar.ForeColor = System.Drawing.Color.White;
                labelCar.Location = new System.Drawing.Point(0, 187);
                labelCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                //labelCar.Name = "labelCarName";
                labelCar.Size = new System.Drawing.Size(104, 25);
                labelCar.TabIndex = 1;
                labelCar.Text = car.Name;

                //pictureBoxCar
                PictureBox pictureBoxCar = new PictureBox();
                pictureBoxCar.Cursor = System.Windows.Forms.Cursors.Hand;
                pictureBoxCar.Dock = System.Windows.Forms.DockStyle.Top;
                if (car.Images.Side is null)
                    pictureBoxCar.Image = Properties.Resources.NoFound404;
                else
                {
                    try
                    {
                        pictureBoxCar.ImageLocation = $@"..\..\Images\Cars\{car.Images.Side}";
                    }
                    catch
                    {
                        pictureBoxCar.Image = Properties.Resources.NoFound404;
                    }
                }
                pictureBoxCar.Location = new System.Drawing.Point(0, 0);
                pictureBoxCar.Margin = new System.Windows.Forms.Padding(2);
                //pictureBoxCar.Name = "pictureBoxCar";
                pictureBoxCar.Size = new System.Drawing.Size(310, 187);
                pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBoxCar.TabIndex = 0;
                pictureBoxCar.TabStop = false;
                pictureBoxCar.Click += (object sender, EventArgs e) => OpenColorForm(car);

                //Add Component
                panelCar.Controls.Add(labelCar);
                panelCar.Controls.Add(pictureBoxCar);
                this.flowLayoutPanelAllCars.Controls.Add(panelCar);
            }
        }
        private void OpenColorForm(Car car)
        {
            BuildYouOwnCar.Color ColorForm = new BuildYouOwnCar.Color(car);
            ColorForm.StartPosition = this.StartPosition;
            ColorForm.Location = this.Location;

            this.Hide();
            ColorForm.Show();
        }
        private void pictureBoxCar_Click(object sender, EventArgs e)
        {

        }
    }
}
