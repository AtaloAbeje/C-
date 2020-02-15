using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pixel
    {
        // R B G
        // int[] arr;

        private int r;
        public int R
        {
            get { return r; }
            set { r = checkValue(value); }
        }

        private int b;
        public int B
        {
            get { return b; }
            set { b = checkValue(value); }
        }

        private int g;
        public int G
        {
            get { return g; }
            set { g = checkValue(value); }
        }

        // access only from here
        private int checkValue(int value)
        {
            if (value > 0 && value <= 255)
                return value;
            return 0;
        }

        // ctor
        public Pixel(int r, int b, int g)
        {
            R = r;
            B = b;
            G = g;
        }

        // empty ctor
        public Pixel() { }

        // 
        /*
        public string getInfo()
        {
            return $"{R}, {B}, {G}";
        }
        */
    }
}
