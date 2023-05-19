using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BuildYouOwnCar
{
    public partial class Wheels : Form
    {
        Car currentCar;
        List<Model.Wheels> availableWheels;
        public Wheels(Car currenCar)
        {
            this.currentCar = currenCar;
            availableWheels = currenCar.GetAvailableWheels();
            InitializeComponent();
            InitializeCar(currenCar);
            InitializeWheels(availableWheels);
        }

        private void InitializeCar(Car car)
        {
            pictureBoxCar.ImageLocation = $@"..\..\Images\{car.Images.Side}";
            pictureBoxCar.ErrorImage = Properties.Resources.NoFound404;
            pictureBoxCar.InitialImage = Properties.Resources.CarLoading_Orange;
        }
        private void InitializeWheels(List<Model.Wheels> Wheels)
        {
            this.flowLayoutPanelWheels.Controls.Clear();
            foreach (Model.Wheels wheels in Wheels)
            {
                //panelWheels
                Panel panelWheels = new Panel();
                panelWheels.BackColor = System.Drawing.SystemColors.ControlDark;
                panelWheels.Cursor = System.Windows.Forms.Cursors.Hand;
                panelWheels.Margin = new System.Windows.Forms.Padding(2);
                panelWheels.Name = $"panelWheels_{wheels.Id}";
                panelWheels.Size = new System.Drawing.Size(150, 206);
                panelWheels.TabIndex = 0;

                //labelWheelsPrice
                Label labelWheelsPrice = new Label();
                labelWheelsPrice.AutoSize = true;
                labelWheelsPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
                labelWheelsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelWheelsPrice.Location = new System.Drawing.Point(0, 190);
                labelWheelsPrice.Size = new System.Drawing.Size(25, 16);
                labelWheelsPrice.TabIndex = 3;
                labelWheelsPrice.Text = $"{wheels.Price} р";

                // labelWheelsName
                Label labelWheelsName = new Label();
                labelWheelsName.AutoSize = true;
                labelWheelsName.Dock = System.Windows.Forms.DockStyle.Top;
                labelWheelsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelWheelsName.Location = new System.Drawing.Point(0, 156);
                labelWheelsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                labelWheelsName.Size = new System.Drawing.Size(148, 20);
                labelWheelsName.TabIndex = 1;
                labelWheelsName.Text = wheels.Name;

                // pictureBoxStatus
                PictureBox pictureBoxStatus = new PictureBox();
                pictureBoxStatus.Dock = System.Windows.Forms.DockStyle.Right;
                pictureBoxStatus.Image = global::BuildYouOwnCar.Properties.Resources.BlackCheckMark;
                if (currentCar.wheels.Id == wheels.Id)
                    pictureBoxStatus.Visible = true;
                else
                    pictureBoxStatus.Visible = false;
                pictureBoxStatus.Location = new System.Drawing.Point(124, 176);
                pictureBoxStatus.Margin = new System.Windows.Forms.Padding(2);
                pictureBoxStatus.Name = $"pictureBoxStatus_{wheels.Id}";
                pictureBoxStatus.Size = new System.Drawing.Size(26, 30);
                pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxStatus.TabIndex = 2;
                pictureBoxStatus.TabStop = false;

                // pictureBoxWheels
                PictureBox pictureBoxWheels = new PictureBox();
                pictureBoxWheels.Dock = System.Windows.Forms.DockStyle.Top;
                pictureBoxWheels.ImageLocation = $@"..\..\Images\{wheels.Image}";
                pictureBoxWheels.ErrorImage = Properties.Resources.NoFound404;
                pictureBoxWheels.InitialImage = Properties.Resources.CarLoading_Orange;
                pictureBoxWheels.Location = new System.Drawing.Point(0, 0);
                pictureBoxWheels.Margin = new System.Windows.Forms.Padding(5);
                pictureBoxWheels.Size = new System.Drawing.Size(150, 156);
                pictureBoxWheels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxWheels.TabIndex = 0;
                pictureBoxWheels.TabStop = false;
                pictureBoxWheels.Click += (object sender, EventArgs e) => SetWheels(wheels);

                //Добавление элементов на панель
                panelWheels.Controls.Add(labelWheelsPrice);
                panelWheels.Controls.Add(pictureBoxStatus);
                panelWheels.Controls.Add(labelWheelsName);
                panelWheels.Controls.Add(pictureBoxWheels);
                this.flowLayoutPanelWheels.Controls.Add(panelWheels);
            }
        }

        private void SetWheels(Model.Wheels newWheels)
        {
            currentCar.SetWheels(newWheels);
            foreach (Panel wheelsPanel in flowLayoutPanelWheels.Controls)
            {
                foreach (var el in wheelsPanel.Controls)
                {
                    if (el is PictureBox mark)
                    {
                        if (mark.Name == $"pictureBoxStatus_{newWheels.Id}")
                            mark.Visible = true;
                        else if (mark.Name.Contains("pictureBoxStatus"))
                            mark.Visible = false;
                    }
                }
            }
            InitializeCar(currentCar);
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            currentCar.ResetWheels();

            BuildYouOwnCar.Color ColorForm = new BuildYouOwnCar.Color(currentCar);
            ColorForm.StartPosition = this.StartPosition;
            ColorForm.Location = this.Location;
            ColorForm.WindowState = this.WindowState;

            this.Hide();
            ColorForm.Show();
        }
        private void buttonGoNext_Click(object sender, EventArgs e)
        {
            BuildYouOwnCar.Spoiler SpoilerForm = new BuildYouOwnCar.Spoiler(currentCar);
            SpoilerForm.StartPosition = this.StartPosition;
            SpoilerForm.Location = this.Location;
            SpoilerForm.WindowState = this.WindowState;

            this.Hide();
            SpoilerForm.Show();
        }
    }
}
