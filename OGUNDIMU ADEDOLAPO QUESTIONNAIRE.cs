using System;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("are you full time or part time?");
            string username = Convert.ToString(Console.ReadLine());

            if ( username == "full time")
            {
                Console.WriteLine("what is your course of study");
                string course = Convert.ToString(Console.ReadLine());
                Console.WriteLine(course + " is a good course");
            }
            else if (username =="part time")
            {
                Console.WriteLine("how many credits he or she is taking");
                int credit = Convert.ToInt32(Console.ReadLine());

                if (credit > 6)
                {
                Console.WriteLine("too much unit for a part time student");
                }

                else if(credit <= 6)
                {
                Console.WriteLine("proceed to screen");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
