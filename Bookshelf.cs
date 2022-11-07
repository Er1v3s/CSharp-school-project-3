using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan
{
    internal class Bookshelf : Sculpture
    {
        internal Bookshelf(int getWidth, int getfootersHeight, int getUniqueThing) : base(getWidth, getfootersHeight, getUniqueThing) { }

        protected internal void drawBookshelf()
        {
            Console.WriteLine("\n");

            for(int j = 0; j <= footersHeight; j++)
            {
                Console.Write("#");
                for (int i = 1; i <= width; i++)
                {
                    shelfDrawRequierment(j);
                }
                Console.WriteLine("#");
            }
        }
        private void shelfDrawRequierment(int j)
        {
            if (j % uniqueThing == 0 || j == 0)
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
