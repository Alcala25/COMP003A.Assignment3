/*
    * Author: Eduardo Alcala
    * Course: COMP-003A
    * Purpose: Lecture Assignment 3 
   */

namespace COMPA.LectureAssigment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Numeric to letter grade using an if-else statement. ");
            Console.Write("\nEnter a numeric grade (0-100): ");
            int NumericGrade = Convert.ToInt32(Console.ReadLine());

            if (NumericGrade >= 0 && NumericGrade <= 100 )
            {
                if (NumericGrade >= 90)
                {
                    Console.WriteLine("\tLetter Grade: A");
                }

                else if (NumericGrade >= 80)
                {
                    Console.WriteLine("\tLetter Grade: B");
                }
                else if (NumericGrade >= 70)
                {
                    Console.WriteLine("\tLetter Grade: C");

                }
                else if (NumericGrade >= 60)
                {
                    Console.WriteLine("\tLetter Grade: D");

                }
                else { Console.WriteLine("\tLetter Grade: F"); }
            }

            /************************************************************/

            Console.WriteLine("Integer to string day using an switch statement");
            Console.WriteLine("\nEnter and integer day of the week (1-7)");
            int NumericDay = Convert.ToInt32(Console.ReadLine());    
            
            switch(NumericDay)
            {
                case 1:
                    Console.WriteLine("\tString Day: Monday");
                    break;

                case 2:
                    Console.WriteLine("\tString Day: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("\tString Day: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("\tString Day: Thursday");
                    break;
                case 5:
                    Console.WriteLine("\tString Day: Friday");
                    break;
                case 6:
                    Console.WriteLine("\tString Day: Saturday");
                    break;
                case 7:
                    Console.WriteLine("\tString Day: Sunday");
                    break;
                case 8:
                    Console.WriteLine("\tInvalid Day!");
                    break;



            }












        }



    }




}
