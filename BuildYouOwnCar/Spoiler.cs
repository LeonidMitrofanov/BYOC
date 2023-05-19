using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BuildYouOwnCar
{
    public partial class Spoiler : Form
    {
        Car currentCar;
        List<Model.Spoiler> availableSpoilers;
        public Spoiler(Model.Car currentCar)
        {
            this.currentCar = currentCar;
            availableSpoilers = currentCar.GetAvailableSpoilers();
            InitializeComponent();
            InitializeCar(currentCar);
            InitializeSpoilers(availableSpoilers);
        }

        private void InitializeCar(Car car)
        {
            pictureBoxCar.ImageLocation = $@"..\..\Images\{car.Images.Back}";
            pictureBoxCar.ErrorImage = Properties.Resources.NoFound404;
            pictureBoxCar.InitialImage = Properties.Resources.CarLoading_Orange;
        }
        private void InitializeSpoilers(List<Model.Spoiler> Spoilers)
        {
            this.flowLayoutPanelSpoilers.Controls.Clear();
            foreach (Model.Spoiler spoiler in Spoilers)
            {
                //panelSpoilers
                Panel panelSpoilers = new Panel();
                panelSpoilers.BackColor = System.Drawing.SystemColors.ControlDark;
                panelSpoilers.Cursor = System.Windows.Forms.Cursors.Hand;
                panelSpoilers.Margin = new System.Windows.Forms.Padding(2);
                panelSpoilers.Name = $"panelSpoiler_{spoiler.Id}";
                panelSpoilers.Size = new System.Drawing.Size(150, 206);
                panelSpoilers.TabIndex = 0;

                //labelSpoilerPrice
                Label labelSpoilerPrice = new Label();
                labelSpoilerPrice.AutoSize = true;
                labelSpoilerPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
                labelSpoilerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelSpoilerPrice.Location = new System.Drawing.Point(0, 190);
                labelSpoilerPrice.Size = new System.Drawing.Size(25, 16);
                labelSpoilerPrice.TabIndex = 3;
                labelSpoilerPrice.Text = $"{spoiler.Price} р";

                // labelSpoilerName
                Label labelSpoilerName = new Label();
                labelSpoilerName.AutoSize = true;
                labelSpoilerName.Dock = System.Windows.Forms.DockStyle.Top;
                labelSpoilerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelSpoilerName.Location = new System.Drawing.Point(0, 156);
                labelSpoilerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                labelSpoilerName.Size = new System.Drawing.Size(148, 20);
                labelSpoilerName.TabIndex = 1;
                labelSpoilerName.Text = spoiler.Name;

                // pictureBoxStatus
                PictureBox pictureBoxStatus = new PictureBox();
                pictureBoxStatus.Dock = System.Windows.Forms.DockStyle.Right;
                pictureBoxStatus.Image = global::BuildYouOwnCar.Properties.Resources.BlackCheckMark;
                if (currentCar.spoiler.Id == spoiler.Id)
                    pictureBoxStatus.Visible = true;
                else
                    pictureBoxStatus.Visible = false;
                pictureBoxStatus.Location = new System.Drawing.Point(124, 176);
                pictureBoxStatus.Margin = new System.Windows.Forms.Padding(2);
                pictureBoxStatus.Name = $"pictureBoxStatus_{spoiler.Id}";
                pictureBoxStatus.Size = new System.Drawing.Size(26, 30);
                pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxStatus.TabIndex = 2;
                pictureBoxStatus.TabStop = false;

                // pictureBoxSpoiler
                PictureBox pictureBoxSpoiler = new PictureBox();
                pictureBoxSpoiler.Dock = System.Windows.Forms.DockStyle.Top;
                pictureBoxSpoiler.ImageLocation = $@"..\..\Images\{spoiler.Image}";
                pictureBoxSpoiler.ErrorImage = Properties.Resources.NoFound404;
                pictureBoxSpoiler.InitialImage = Properties.Resources.CarLoading_Orange;
                pictureBoxSpoiler.Location = new System.Drawing.Point(0, 0);
                pictureBoxSpoiler.Margin = new System.Windows.Forms.Padding(5);
                pictureBoxSpoiler.Size = new System.Drawing.Size(150, 156);
                pictureBoxSpoiler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBoxSpoiler.TabIndex = 0;
                pictureBoxSpoiler.TabStop = false;
                pictureBoxSpoiler.Click += (object sender, EventArgs e) => SetSpoiler(spoiler);

                //Добавление элементов на панель
                panelSpoilers.Controls.Add(labelSpoilerPrice);
                panelSpoilers.Controls.Add(pictureBoxStatus);
                panelSpoilers.Controls.Add(labelSpoilerName);
                panelSpoilers.Controls.Add(pictureBoxSpoiler);
                this.flowLayoutPanelSpoilers.Controls.Add(panelSpoilers);
            }
        }

        private void SetSpoiler(Model.Spoiler newSpoiler)
        {
            currentCar.SetSpoiler(newSpoiler);
            foreach (Panel wheelsPanel in flowLayoutPanelSpoilers.Controls)
            {
                foreach (var el in wheelsPanel.Controls)
                {
                    if (el is PictureBox mark)
                    {
                        if (mark.Name == $"pictureBoxStatus_{newSpoiler.Id}")
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
            currentCar.ResetSpoiler();

            BuildYouOwnCar.Wheels WheelsForm = new BuildYouOwnCar.Wheels(currentCar);
            WheelsForm.StartPosition = this.StartPosition;
            WheelsForm.Location = this.Location;
            WheelsForm.WindowState = this.WindowState;

            this.Hide();
            WheelsForm.Show();
        }

        private void buttonGoNext_Click(object sender, EventArgs e)
        {
            BuildYouOwnCar.Summary SummaryForm = new BuildYouOwnCar.Summary(currentCar);
            SummaryForm.StartPosition = this.StartPosition;
            SummaryForm.Location = this.Location;
            SummaryForm.WindowState = this.WindowState;

            this.Hide();
            SummaryForm.Show();
        }
    }
    
}
