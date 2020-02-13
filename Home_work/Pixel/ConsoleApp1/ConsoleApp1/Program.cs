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
            //Pixel p1 = new Pixel(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            //Pixel p2 = new Pixel(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

            Pixel p1 = new Pixel(2, 3, 18);
            Pixel p2 = new Pixel(6, 9, 2);

            Console.WriteLine(p1.getDescription());
            Console.WriteLine(p2.getDescription());

            List<Pixel> pixels = new List<Pixel>();
            pixels.Add(p1);
            pixels.Add(p2);

            while (true)
            {
                int count = pixels.Count;
                for (int i = 0; i < count; i++)
                {
                    // Pixel son = createPixel(pixels[i], pixels[i + 1]);      
                    Pixel son = new Pixel(
                                            (pixels[i].R + pixels[i + 1].R) / 2,
                                            (pixels[i].B + pixels[i + 1].B) / 2,
                                            (pixels[i].G + pixels[i + 1].G) / 2
                                         );

                    Console.WriteLine(son.getDescription());
                    pixels.Add(son);

                }
                Thread.Sleep(999999999);   //    999999999     3000
            }
        }
    }
}

    /*
      private static Pixel createPixel(Pixel p1, Pixel p2)
    {

        Pixel c = new Pixel((p1.R + p2.R) / 2, (p1.B + p2.B) / 2, (p1.G + p2.G) / 2);
        return c;

    }

    // way 2
    int i, j = 0, k = 0;

    int[] arr = { p1.R, p1.B, p1.G };
    int[] brr = { p2.R, p2.B, p2.G };
    int[] crr = new int[3];


    for (i = 0; i < 3; i++)
    {
        crr[k++] = (((arr[i] * 50) / 100) + ((brr[j++] * 50) / 100));

    }
    return new Pixel(crr[0], crr[1], crr[2]);
*/
