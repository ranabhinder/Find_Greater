using System;

namespace Find_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_1, number_2;



            // Asks the user to enter a number
            Console.WriteLine("Please enter first number");
            //Below line converts the input from a string to an integer
            number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            number_2 = Convert.ToInt32(Console.ReadLine());



            if (number_1 > number_2)
            {
                Console.WriteLine(number_1.ToString() + " is greater than " + number_2.ToString());
            }



            if (number_1 == number_2)
            {
                Console.WriteLine(number_1.ToString() + " is equal to " + number_2.ToString());
            }



            if (number_1 < number_2)
            {
                Console.WriteLine("Number 2 is greater than number 1");
            }
        }
    }
}
