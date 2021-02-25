using System;

namespace การบ้าน
{
    class Program
    {
        static void Main(string[] args)
        {
            int Password;
            string agency;

            Console.WriteLine("What is your pass?");
            Password = int.Parse(Console.ReadLine);

            Console.WriteLine("You are");
            agency = Console.ReadLine();

            int sixth = Password / 100000;
            int fifth = (Password / 10000) % 10;
            int fourth = (Password / 1000) % 10;
            int third = (Password / 100) % 10;
            int second = (Password / 10) % 10;
            int first = (Password / 1) % 10;

            if (first % 3 == 0) && (second != 1 && second != 3 && second != 5) && (third >= 6 && !=8)
            agency = "CIA";
            else 
                Console.WriteLine("false");
            if (sixth >= 4 && <=7) && (second % 2 == 0 && !=6) && (fifth % 2 == 1)
            agency = "FBI";
            else 
                Console.WriteLine("false");
            if (30 % first == 0) && (second % 3 == 0 && second % 2 != 0) && (first == 7 && second == 7 && third == 7 && fourth == 7 && fifth == 7 && sixth == 7)
            agency = "NSA";
            else 
                Console.WriteLine("false");
            Console.ReadLine();

           


        }
}
