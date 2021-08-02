using System;
using System.Collections.Generic;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {

            Fruit fruit = new Orange();
            string color = fruit.GetColor();
            Console.WriteLine(color);

            fruit = new Apple();
            string applecolor = fruit.GetColor();
            Console.WriteLine(applecolor);

            List<MemeberShip> memeberShips = new List<MemeberShip>();

            memeberShips.Add(new ProMembership());
            memeberShips.Add(new PlusMembership());
            //memeberShips.Add(new TrailMember());

            foreach (var item in memeberShips)
            {
                item.add();
            }

            Console.ReadLine();

        }
    }
}
