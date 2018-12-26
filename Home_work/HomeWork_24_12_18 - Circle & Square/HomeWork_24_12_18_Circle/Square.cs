using System;

namespace HomeWork_24_12_18_Circle
{
    class Square
    {
        public int X { get; set; }
        public int Y { get; set; }

        private int rib;
   
        public int Rib
        {
            get { return rib; }
            set
            {
                if (value > 0)
                {
                    rib = value;
                }
            }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Square(int rib,int x, int y, string color)
        {
            X = x;
            Y = y;
            Rib = rib;      
            Color = color;
        }

        public string Ctor()
        {
            return $"\nSquare has created:\nX: {X}, Y: {Y}, Rib: {Rib}, Color: {Color}";
        }

        public string area_square()
        {
            return $"Area Square: {Math.Pow(Rib, 2)}";
        }

        public string scope_square()
        {
            return $"Scope Square: {Rib * 4}";
        }
    }
}
