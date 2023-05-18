using System;

namespace Model
{
    public class Wheels
    {
        public static Wheels GetById(Int16 id)
        {
            var wheelsInfo = DB.GetWheelsWithImageById(id);
            return new Wheels(id, wheelsInfo.Name, wheelsInfo.Price, wheelsInfo.Image);
        }

        public Int16 Id { get => _id; }
        public string Name { get => _name; }
        public float Price { get => _price; }
        public string Image { get => _image; }

        private Wheels(Int16 id, string name, float price, string image)
        {
            _id = id;
            _name = name;
            _price = price;
            _image = image;
        }

        private Int16 _id;
        private string _name;
        private float _price;
        private string _image;
    }
}