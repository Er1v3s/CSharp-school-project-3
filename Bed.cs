using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    internal class Bed : Sculpture
    {
        internal Bed(int getWidth, int getfootersHeight, int getUniqueThing) : base(getWidth, getfootersHeight, getUniqueThing) { }

        protected internal void drawBed()
        {
            Console.WriteLine("\n#####");
            for (int x = 1; x <= uniqueThing; x++)
            {
                drawMatters(x);   
            }
            drawfooters();
        }
        private void drawMatters(int x)
        {
            for (int i = 1; i <= width; i++)
            {
                Console.Write("#");
            }
            if (x < uniqueThing)
            {
                Console.WriteLine(" ");
            }
        }
    }
}
