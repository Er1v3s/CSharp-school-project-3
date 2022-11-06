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
                        int width, footerheight, matterss;
                        Console.Write("bed width: ");
                        width = Convert.ToInt32(Console.ReadLine());
                        Console.Write("footers height: ");
                        footerheight = Convert.ToInt32(Console.ReadLine());
                        Console.Write("matters count: ");
                        matterss = Convert.ToInt32(Console.ReadLine());

                        Bed createdItem = new Bed(width, footerheight, matterss);
                        createdItem.drawBed();
                    }
                    else if (item == "bookshelf")
                    {
                        Bookshelf createdItem = new Bookshelf();
                    }
                    else if (item == "chair")
                    {
                        Chair createdItem = new Chair();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry but I can't sculpt this for you");
                        boolflag = false;
                    }
            }
            while (boolflag == false);


            Console.ReadLine();
        }
    }
}