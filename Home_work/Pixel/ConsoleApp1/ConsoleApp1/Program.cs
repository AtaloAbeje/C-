using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 0, k = 0, firstGenerations = 2, secondGenerations = 5;
            bool startSlip = false;

            Random rnd = new Random();

            // random numbers between 0 and 255
            Pixel p1 = new Pixel(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            Pixel p2 = new Pixel(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

            List<Pixel> pixels = new List<Pixel>();
            List<Pixel> newPixels = new List<Pixel>();

            pixels.Add(p1);
            pixels.Add(p2);

            while (true)
            {
                int count = pixels.Count;
                for (i = 0; i < count; i++)
                {
                    Pixel son = new Pixel((pixels[i].R + pixels[i + 1].R) / 2,
                                           (pixels[i].B + pixels[i + 1].B) / 2,
                                           (pixels[i].G + pixels[i + 1].G) / 2);
                    pixels.Add(son);

                    if (i > 6) // for 6 generations
                    {
                        // pixel 0 with 3 and pixel 0 with pixel 6 
                        newPixels.Add(createNewPixel(pixels[k], pixels[firstGenerations++]));    // 3 generations
                        newPixels.Add(createNewPixel(pixels[k++], pixels[secondGenerations++])); // 6 generations
                        startSlip = true;

                        deleterOldPixel(newPixels);
                        printInfo(newPixels);
                    }

                }

                if (startSlip) // start only the start create new list of pixels
                    Thread.Sleep(5000); // 5 seconds
            }
        }

        // create new pixels with 3 and 6 generations
        private static Pixel createNewPixel(Pixel pixel1, Pixel pixel2)
        {
            int min, max, avg = (pixel1.R + pixel2.R) / 2;
            Pixel newSon = new Pixel();

            // between R1 and R2
            max = (pixel1.R > pixel2.R) ? pixel1.R : pixel2.R;
            min = (pixel1.R < pixel2.R) ? pixel1.R : pixel2.R;

            if (avg < max && avg > min)
            {
                newSon = new Pixel((pixel1.R + pixel2.R) / 2,
                                     (pixel1.B + pixel2.B) / 2,
                                     (pixel1.G + pixel2.G) / 2);
            }
            return newSon;
        }

        private static void deleterOldPixel(List<Pixel> newPixels)
        {
            int i, j = 0, index = 7, cnt = newPixels.Count;

            for (i = 0; i < cnt; i++)
            {
                if(index == i)
                {
                    //Console.WriteLine("deleted");
                    newPixels.RemoveAt(j++);
                    index *= 2; // index 7, 15, 31..
                }
            }
        }

        private static void printInfo(List<Pixel> list)
        {
            int i, cnt = list.Count;

            for (i = 0; i < cnt; i++)
            {
                Console.WriteLine($"{list[i].R}, {list[i].B}, {list[i].G}");
            }
        }
    }
}
