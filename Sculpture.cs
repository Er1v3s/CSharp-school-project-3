using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    public class Sculpture
    {
        private protected int width;
        private protected int footersHeight;
        private protected int uniqueThing;

        private protected Sculpture(int getWidth, int getfootersHeight, int getUniqueThing)
        {
            width = getWidth;
            footersHeight = getfootersHeight;
            uniqueThing = getUniqueThing;
        }

        protected void drawfooters()
        {
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
