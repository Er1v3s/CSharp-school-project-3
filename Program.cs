using System;
using System.Runtime.CompilerServices;

namespace Artisan
{
    class Program
    {
        static void Main(string[] args)
        {
            string item;
            bool boolflag;
            int width, footerheight, uniqueThing;

            do
            {
                boolflag = true;
                Console.Write("What would you like to sculpt? bed | bookshelf | chair : ");
                item = Console.ReadLine();
                item = item.ToLower();

                if (item != null)
                {
                    if (item == "bed")
                    {
                        getParametrs("bed", "footers", "matterss");
                        Bed createdItem = new Bed(width, footerheight, uniqueThing);
                        createdItem.drawBed();
                    }
                    else if (item == "bookshelf")
                    {
                        getParametrs("bookshelf", "bookshelf", "shelf count");
                        Bookshelf createdItem = new Bookshelf(width, footerheight, uniqueThing);
                        createdItem.drawBookshelf();
                    }
                    else if (item == "chair")
                    {
                        Console.WriteLine("If you enter 0 it will be replaced to the default value");
                        getParametrs("chair", "footers", "back");
                        Chair createdItem = new Chair(width, footerheight, uniqueThing);
                        createdItem.drawChair();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry but I can't sculpt this for you");
                        boolflag = false;
                    }
                }
            }
            while (boolflag == false);

            void getParametrs(string thingName, string thingHeight, string thingUnique)
            { 
                Console.Write(thingName + " width: ");
                width = Convert.ToInt32(Console.ReadLine());
                Console.Write(thingHeight + " height: ");
                footerheight = Convert.ToInt32(Console.ReadLine());
                Console.Write(thingUnique + " size: ");
                uniqueThing = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}