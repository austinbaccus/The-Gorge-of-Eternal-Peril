using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace The_Gorge_of_Eternal_Peril
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What... is your Name?");
            Console.ReadLine();
            Thread.Sleep(1000);

            Console.WriteLine("What... is your Quest?");
            Console.ReadLine();
            Thread.Sleep(1000);

            Random random = new Random();
            int randomNumber = random.Next(1, 3);

            if (randomNumber == 1)
                Method1();
            if (randomNumber == 2)
                Method2();
            if (randomNumber == 3)
                Method3();

        }

        public static void Method1()
        {
            string MyString1;

            Console.WriteLine("What... is the air speed velocity of an unladen Swallow?");
            MyString1 = Console.ReadLine();
            if (MyString1 == "what do you mean, an african or european swallow?" || MyString1 == "What do you mean, an African or European Swallow?" || MyString1 == "a")
            {
                Console.WriteLine("Wh-, I don't know that");
                Thread.Sleep(300);
                Console.WriteLine("Aaagggghhhhh!");
                Thread.Sleep(400);
                Console.WriteLine("You have crossed the Bridge of Death, brave sir Knight");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aaagggghhhhh!");
                Thread.Sleep(500);
                Console.WriteLine("You have fallen into the Gorge of Eternal Peril");

                Thread.Sleep(800);
                Console.ReadLine();
            }
        }

        public static void Method2()
        {
            string MyString2;            //A countdown timer for this question (Color) would be nice

            Console.WriteLine("What... is your favorite Color?");
            MyString2 = Console.ReadLine();
            if (MyString2 == "Blue" || MyString2 == "Yellow" || MyString2 == "Red" || MyString2 == "Black" || MyString2 == "Green" || MyString2 == "White" || MyString2 == "Orange")
            {
                Console.WriteLine("You have crossed the Bridge of Death, brave sir Knight");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aaagggghhhhh!");
                Thread.Sleep(500);
                Console.WriteLine("You have fallen into the Gorge of Eternal Peril");

                Thread.Sleep(800);
                Console.ReadLine();
            }
        }

        public static void Method3()
        {
            string MyString3;

            Console.WriteLine("What... is the capital of Assyria?");
            MyString3 = Console.ReadLine();
            if (MyString3 == "Ur" || MyString3 == "Nineveh")
            {
                Console.WriteLine("You have crossed the Bridge of Death, brave sir Knight");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aaagggghhhhh!");
                Thread.Sleep(500);
                Console.WriteLine("You have fallen into the Gorge of Eternal Peril");

                Thread.Sleep(800);
                Console.ReadLine();
            }
        }
    }
}
