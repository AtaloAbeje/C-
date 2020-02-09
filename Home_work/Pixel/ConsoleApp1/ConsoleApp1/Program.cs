using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // random numbers between 0 and 255
            Pixel p1 = new Pixel(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            Pixel p2 = new Pixel(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

            Console.WriteLine(p1.getDescription());
            Console.WriteLine(p2.getDescription());

            List<Pixel> pixels = new List<Pixel>();
            pixels.Add(p1);
            pixels.Add(p2);

            while (true)
            {
                int count = pixels.Count;
                for (int i = 0; i < count; i += 2) 
                {
                    Pixel son = createPixel(pixels[i], pixels[i + 1]);
                    Console.WriteLine(son.getDescription());
                    Console.WriteLine();

                    // add new pixel to stack
                    pixels.Add(son);

                }
                Thread.Sleep(5000); // 5 seconds
            }
      
        }

        private static Pixel createPixel(Pixel p1, Pixel p2)
        {
            // way 1
            // 50 % from p1 and 50% from p2
            Pixel c = new Pixel(
                                (p1.R * 50 / 100) + (p2.R * 50 / 100),
                                (p1.B * 50 / 100) + (p2.B * 50 / 100),
                                (p1.G * 50 / 100) + (p2.G * 50 / 100));
            return c;

        /*
            // way 2
            int i, j = 0, k = 0;

            int[] arr = { p1.R, p1.B, p1.G };
            int[] brr = { p2.R, p2.B, p2.G };
            int[] crr = new int[3];

            
            for (i = 0; i < 3; i++)
            {
                // 50% from p1 and 50% p2
                crr[k++] = (((arr[i] * 50) / 100) + ((brr[j++] * 50) / 100));
               // Console.Write($"{crr[i]}, ");

                if (i == 2) // new after created new pixel
                    Console.WriteLine();

            }
            return new Pixel(crr[0], crr[1], crr[2]);
        */

        }
    }
}
