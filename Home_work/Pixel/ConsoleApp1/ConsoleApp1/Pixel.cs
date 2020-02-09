using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pixel
    {
        private int r;
        public int R
        {
            get { return r; }
            set { r = checkValue(value); }

        }

        private int g;
        public int G
        {
            get { return g; }
            set { g = checkValue(value); }
        }

        private int b;
        public int B
        {
            get { return b; }
            set { b = checkValue(value); }
        }

        // access only from here
        private int checkValue(int value)
        {
            if (value > 0 && value <= 255)
                return value;
            return 0;

        }

        // empty ctor
        //public Pixel() { }

        // ctor
        public Pixel(int r, int g, int b)
        {
            R = r; G = g; B = b;
        }

        public string getDescription()
        {
            return $"{R}, {G}, {B}";
        }
    }
}
