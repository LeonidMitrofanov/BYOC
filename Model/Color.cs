using System;

namespace Model
{
    public class Color
    {
        public static Color GetById(Int16 id)
        {
            var colorInfo = DB.GetColorsById(id);
            return new Color(id, colorInfo.Name, colorInfo.Price, colorInfo.RGB);
        }

        public Int16 Id { get => _id; }
        public string Name { get => _name; }
        public float Price { get => _price; }
        public string RGB { get => _RGB; }

        private Color(Int16 id, string name, float price, string RGB)
        {
            _id = id;
            _name = name;
            _price = price;
            _RGB = RGB;
        }

        private Int16 _id;
        private string _name;
        private float _price;
        private string _RGB;
    }
}