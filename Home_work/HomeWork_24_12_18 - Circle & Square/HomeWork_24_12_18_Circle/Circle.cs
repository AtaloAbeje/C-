using System;
namespace HomeWork_24_12_18_Circle
{
    class Circle
    {
        static double Pi = 3.14159;

        public int X { get; set; }
        public int Y { get; set; }

        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int radius;
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
            }
        }

        public Circle(int x, int y, int radius, string color)
        {
            X = x;
            Y = y;
            Radius = radius;
            Color = color;
        }

        public string Ctor()
        {
            return $"Circle has created:\nX: {X}, Y: {Y},Radius: {Radius}, Color: {Color}";
        }

        public string area_circle()
        {
            return $"Area circle: {Pi * Math.Pow(radius, 2)}";
        }

        public string scope_circel()
        {
            return $"Scope circle: {2 * Pi * Radius}";

        }
    }
}
