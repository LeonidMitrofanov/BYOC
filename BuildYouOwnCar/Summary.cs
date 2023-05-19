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
    public partial class Summary : Form
    {
        Car currentCar;
        public Summary(Car currentCar)
        {
            this.currentCar = currentCar;
            InitializeComponent();
            InitializeCar(currentCar);
            InitializeCarAtributes(currentCar);
        }

        private void InitializeCar(Car car)
        {
            //labelCarName
            labelCarName.Text = car.Name;

            //labelFinalPrice
            labelFinalPrice.Text = $"{car.Price + car.color.Price + car.wheels.Price + car.spoiler.Price}р";

            //labelStartPrice
            labelStartPrice.Text = $"{car.Price}р";

            //pictureBoxCarFront
            pictureBoxCarFront.ImageLocation = $@"..\..\Images\{car.Images.Front}";
            pictureBoxCarFront.ErrorImage = Properties.Resources.NoFound404;
            pictureBoxCarFront.InitialImage = Properties.Resources.CarLoading_Orange;

            //pictureBoxCarSide
            pictureBoxCarSide.ImageLocation = $@"..\..\Images\{car.Images.Side}";
            pictureBoxCarSide.ErrorImage = Properties.Resources.NoFound404;
            pictureBoxCarSide.InitialImage = Properties.Resources.CarLoading_Orange;

            //pictureBoxCarBack
            pictureBoxCarBack.ImageLocation = $@"..\..\Images\{car.Images.Back}";
            pictureBoxCarBack.ErrorImage = Properties.Resources.NoFound404;
            pictureBoxCarBack.InitialImage = Properties.Resources.CarLoading_Orange;
        }
        private void InitializeCarAtributes(Car car)
        {
            // panelColor
            this.labelColorName.Text = car.color.Name;
            this.labelColorPrice.Text = $"{car.color.Price}р";

            //panelWheels
            this.labelWheelsName.Text = $"{car.wheels.Name}";
            this.labelWheelsPrice.Text = $"{car.wheels.Price}р";

            //panelSpoiler
            this.labelSpoilerName.Text = $"{car.spoiler.Name}";
            this.labelSpoilerPrice.Text = $"{car.spoiler.Price}р";
        }

        private void buttonBuildAnotherCar_Click(object sender, EventArgs e)
        {
            BuildYouOwnCar.MainForm MainForm = new BuildYouOwnCar.MainForm();
            MainForm.StartPosition = this.StartPosition;
            MainForm.Location = this.Location;
            MainForm.WindowState = this.WindowState;

            this.Hide();
            MainForm.Show();
        }
    }
}
