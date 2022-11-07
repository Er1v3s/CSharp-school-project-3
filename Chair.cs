using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    internal class Chair : Sculpture
    {
        internal Chair(int getWidth, int getfootersHeight, int getUniqueThing) : base(getWidth, getfootersHeight, getUniqueThing) { }
        protected internal void drawChair()
        {
            
            checkParams();
            Console.WriteLine("\n");
            for(int i = 1; i <= uniqueThing; i++)
            {
                Console.WriteLine("#");
            }
            for(int j = 1; j <= width; j++)
            {
                Console.Write("#");
                if (j > width)
                {
                    Console.WriteLine(" ");
                }
            }
            drawfooters();
        }
        private void checkParams()
        {
            if(width == 0)
            {
                width = 10;
            }
            if(footersHeight == 0)
            {
                footersHeight = 4;
            }
            if(uniqueThing == 0)
            {
                uniqueThing = 5;
            }
        }
    }
}
