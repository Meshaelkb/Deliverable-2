
using System;

namespace Deliverable_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            
                double grade = Convert.ToDouble(Console.ReadLine());

            if ((grade >= 90) && (grade < 101))
            {

                Console.WriteLine("you letter grade is A");
            }
            else if ((grade > +80) && (grade < 90))
            {
                Console.WriteLine("your letter grade is B");
            }
            else if ((grade > +70) && (grade < 80))
            {
                Console.WriteLine("your letter grade is C");
            }
            else if ((grade >= 60) && (grade < 70))
            {
                Console.WriteLine("your letter grade is D");
            }
            else Console.WriteLine("you failed the class");
                

        }  

                    

                
            
        
    }
}