using System;

namespace Artisan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item;
            bool boolflag;

            do
            {
                boolflag = true;
                Console.Write("What would you like to sculpt? bed | bookshelf | chair : ");
                item = Console.ReadLine();
                item = item.ToLower();

                if (item != null)
                    if (item == "bed")
                    {
                        Bed createdItem = new Bed();
                    }
                    else if (item == "bookshelf")
                    {
                        Bookshelf createdItem = new Bookshelf();
                    }
                    else if (item == "chair")
                    {
                        Chair createdElement = new Chair();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry but I can't make sculpt this for you");
                        boolflag = false;
                    }
            }
            while (boolflag == false);

            Console.WriteLine("Out of loop");




            Console.ReadLine();
        }
    }
}