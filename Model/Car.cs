using System;
using System.Collections.Generic;

namespace Model
{
    public class Car
    {
        static public Car GetById(Int16 id)
        {
            (string Name, float Price) CarInfo = DB.GetCarInfoById(id);

            Int16 StandartConfigurationId = DB.GetStandartConfigurationIdsByCarId(id)[0];
            (Int16 ConfigurationId, Int16 CarId, Int16 ColorId, Int16 WheelsId, Int16 SpoilerId) StandartConfiguration = DB.GetConfigurationById(StandartConfigurationId);
            (Int16 ConfigurationId, Int16 CarId, Color color, Wheels wheels, Spoiler spoiler) configuration = (
                StandartConfiguration.ConfigurationId,
                StandartConfiguration.CarId,
                Color.GetById(StandartConfiguration.ColorId),
                Wheels.GetById(StandartConfiguration.WheelsId),
                Spoiler.GetById(StandartConfiguration.SpoilerId));

            (string Front, string Side, string Back) CarImages = DB.GetCarImagesByConfigurationId(StandartConfigurationId);

            return new Car(id, CarInfo.Name, CarInfo.Price, CarImages, configuration);
        }
        static public List<Car> GetAll()
        {
            List<Car> carList = new List<Car>();
            foreach (Int16 carId in DB.GetAllCarIds())
            {
                carList.Add(GetById(carId));
            }
            return carList;
        }

        public Int16 Id { get => _id; }
        public string Name { get => _name; }
        public float Price { get => _price; }
        public (string Front, string Side, string Back) Images { get => _images; }
        public (Int16 ConfigurationId, Int16 CarId, Color Color, Wheels Wheels, Spoiler Spoiler) standartConfiguration { get => _standartConfiguration; }
        public Color color { get => _color; }
        public Wheels wheels { get => _wheels; }
        public Spoiler spoiler { get => _spoiler; }

        private Int16 _id;
        private string _name;
        private float _price;
        private (string Front, string Side, string Back) _images = (null, null, null);
        private (Int16 ConfigurationId, Int16 CarId, Color color, Wheels wheels, Spoiler spoiler) _standartConfiguration;
        private Color _color;
        private Wheels _wheels;
        private Spoiler _spoiler;

        private Car(Int16 id, string name, float price, (string Front, string Side, string Back) images, (Int16 ConfigurationId, Int16 CarId, Color Color, Wheels Wheels, Spoiler Spoiler) configuration)
        {
            _id = id;
            _name = name;
            _price = price;
            _images = images;
            _standartConfiguration = configuration;
            _color = configuration.Color;
            _wheels = configuration.Wheels;
            _spoiler = configuration.Spoiler;
        }

        public void SetColor(Color newColor)
        {
            this._color = newColor;
            this._wheels = standartConfiguration.Wheels;
            this._spoiler = standartConfiguration.Spoiler;
            UpdateImages();
        }
        public void SetWheels(Wheels newWheels)
        {
            this._wheels = newWheels;
            this._spoiler = standartConfiguration.Spoiler;
            UpdateImages();
        }
        public void SetSpoiler(Spoiler newspoiler)
        {
            this._spoiler = newspoiler;
            UpdateImages();
        }
        public void ResetColor()
        {
            this._color = standartConfiguration.Color;
            this._wheels = standartConfiguration.Wheels;
            this._spoiler = standartConfiguration.Spoiler;
            UpdateImages();
        }
        public void ResetWheels()
        {
            this._wheels = standartConfiguration.Wheels;
            this._spoiler = standartConfiguration.Spoiler;
            UpdateImages();
        }
        public void ResetSpoiler()
        {
            this._spoiler = standartConfiguration.Spoiler;
            UpdateImages();
        }
        private void UpdateImages()
        {
            _images = DB.GetCarImagesByCarAttributes(this.Id, this.color.Id, this.wheels.Id, this.spoiler.Id);
        }

        public void availableColors()
        {

        }
    }
}