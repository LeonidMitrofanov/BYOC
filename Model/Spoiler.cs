using System;

namespace Model
{
    public class Spoiler
    {
        public static Spoiler GetById(Int16 id)
        {
            var spoilerInfo = DB.GetSpoilerWithImageById(id);
            return new Spoiler(id, spoilerInfo.Name, spoilerInfo.Price, spoilerInfo.Image);
        }

        public Int16 Id { get => _id; }
        public string Name { get => _name; }
        public float Price { get => _price; }
        public string Image { get => _image; }

        private Spoiler(Int16 id, string name, float price, string image)
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