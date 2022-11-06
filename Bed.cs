using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    class Bed
    {
        private int width;
        private int footersHeight;
        private int mattress;

        public Bed(int getWidth, int getfootersHeight, int getMattress)
        {
            width = getWidth;
            footersHeight = getfootersHeight;
            mattress = getMattress;
        }

        public void drawBed()
        {
            Console.WriteLine("\n#####");
            for (int x = 1; x <= mattress; x++)
            {
                for (int i = 1; i <= width; i++)
                {
                    Console.Write("#");
                }
                if(x < mattress)
                {
                Console.WriteLine(" ");
                }
            }

            for (int z = 1; z <= footersHeight; z++)
            {
                Console.Write("\n");
                Console.Write("#");
                Console.Write(" ");
                Console.Write(" ");
                if (z <= (footersHeight / 2))
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
                
                for (int y = 1; y <= (width - 8); y++)
                {
                    Console.Write(" ");
                }
                Console.Write("#");
                Console.Write(" ");
                Console.Write(" ");
                if (z <= (footersHeight / 2))
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }                  
}
