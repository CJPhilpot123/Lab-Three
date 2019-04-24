using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wave = 0;
            Console.WriteLine("Good Day! What Is Your Name?");
            String Name = Console.ReadLine();
            Console.WriteLine($"Hello {Name}");
            Wave++;


            while (Wave == 1)
            {
                Console.WriteLine("Enter a Number Between 1 and 100:");
                String SNum = Console.ReadLine();
                int Numb = int.Parse(SNum);
                if (Numb < 1 || Numb > 100)
                {
                    Console.WriteLine("Not a Valid Number {0}", Name);
                }
                if (Numb % 2 == 0 && Numb > 60 && Numb < 101)
                {
                    Console.WriteLine($"{Numb} and Even" + " {0}", Name);
                }
                if (Numb % 2 == 1 && Numb > 1)
                {
                    Console.WriteLine($"{Numb} and Odd" + " {0}", Name);
                }
                if (Numb % 2 == 0 && Numb < 25 && Numb > 1)
                {
                    Console.WriteLine("Even and less than 25 {0}", Name);
                }
                if (Numb % 2 == 0 && Numb > 25 && Numb < 60)
                {
                    Console.WriteLine("Even {0}", Name);

                }


                Console.WriteLine("Continue? Yes or No");
                Wave++;
                string yes = null;
                yes = Console.ReadLine();
                if (yes == "Yes")
                {
                    Wave--;
                }
                if (yes == "No")
                {
                    Console.WriteLine("Hope You Have A Good Day {0}!", Name);
                }




            }
        }

    }
}

