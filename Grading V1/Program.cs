using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Again_Lol
{
    class Program
    {
        public static void printDirections()
        {
            Console.WriteLine("Welcome to the grading machine.");
            Console.WriteLine("");
            Console.WriteLine("This program is designed to convert your grades (in numbers) to their letter version counter parts.");
            Console.WriteLine("");
            Console.WriteLine("The program will continue to read in grades until you enter -1.");
            Console.WriteLine("");
            Console.WriteLine("Enjoy!");
            Console.WriteLine("");
        }
        public static int getInt()
        {
            int num = 0;
            string input = "";

            Console.WriteLine("");
            Console.WriteLine("Please enter an integer: ");
            Console.WriteLine("");

            input = Console.ReadLine();
            num = Convert.ToInt32(input);
            return num;

        }
        public static void grading()
        {
            int grade = 0;
            int gradeCount = 0;
            int gradeSum = 0;
            //int highestGrade = 0;
           // int lowestGrade = 0;
            double gradeAverage = 0.0;
            char gradeValue = 'A';

            printDirections();

            grade = getInt();

            switch (grade)
            {
                case -1:
                    break;  
            }

            //lowestGrade = grade;

            while (grade != -1)
            {
                if ((grade <= 100) && (grade >= 90))
                {
                    gradeCount++;
                    gradeSum += grade;

                    Console.WriteLine("");
                    Console.WriteLine("The grade you entered is an A!");
                    Console.WriteLine("");

                    /*if(grade < lowestGrade)
                    {
                        lowestGrade = grade;
                    }

                    if(grade > highestGrade)
                    {
                        highestGrade = grade;
                    }
                    */
                    grade = getInt();
                }
                else if ((grade < 90) && (grade >= 80))
                {
                    gradeCount++;
                    gradeSum += grade;

                    Console.WriteLine("");
                    Console.WriteLine("The grade you entered is a B!");
                    Console.WriteLine("");
                    
                    /*if(grade < lowestGrade)
                    {
                        lowestGrade = grade;
                    }

                    if(grade > highestGrade)
                    {
                        highestGrade = grade;
                    }
                    */
                    grade = getInt();

                }
                else if ((grade < 80) && (grade >= 70))
                {
                    gradeCount++;
                    gradeSum += grade;

                    Console.WriteLine("");
                    Console.WriteLine("The grade you entered is a C.");
                    Console.WriteLine("");
                    
                    /*if(grade < lowestGrade)
                    {
                        lowestGrade = grade;
                    }

                    if(grade > highestGrade)
                    {
                        highestGrade = grade;
                    }
                    */
                    grade = getInt();
                }
                else if ((grade < 70) && (grade >= 60))
                {
                    gradeCount++;
                    gradeSum += grade;

                    Console.WriteLine("");
                    Console.WriteLine("The grade you entered is a D.");
                    Console.WriteLine("");
                    
                    /*if(grade < lowestGrade)
                    {
                        lowestGrade = grade;
                    }

                    if(grade > highestGrade)
                    {
                        highestGrade = grade;
                    }
                    */
                    grade = getInt();
                }
                else if ((grade < 70) && (grade >= 1))
                {
                    gradeCount++;
                    gradeSum += grade;

                    Console.WriteLine("");
                    Console.WriteLine("The grade you entered is an F.");
                    Console.WriteLine("");
                    
                    /*if(grade < lowestGrade)
                    {
                        lowestGrade = grade;
                    }

                    if(grade > highestGrade)
                    {
                        highestGrade = grade;
                    }
                    */
                    grade = getInt();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have entered an invalid grade, please try again");
                    Console.WriteLine("");

                    grade = getInt();
                }
            }

            gradeAverage = (double)gradeSum / gradeCount;

            if ((gradeAverage <= 100) && (gradeAverage >= 90))
            {
                gradeValue = 'A';
            }
            else if ((gradeAverage < 90) && (gradeAverage >= 80))
            {
                gradeValue = 'B';
            }
            else if ((gradeAverage < 80) && (gradeAverage >= 70))
            {
                gradeValue = 'C';
            }
            else if ((gradeAverage < 70) && (gradeAverage >= 60))
            {
                gradeValue = 'D';
            }
            else if ((gradeAverage < 60) && (gradeAverage >= 1))
            {
                gradeValue = 'F';
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Error in average ifs.");
                Console.WriteLine("");
            }
            
            Console.WriteLine("");
            Console.WriteLine("The average of the grades you entered (in numerical form) is " + gradeAverage + ".");
            Console.WriteLine("");
            
            if ((gradeValue == 'A') || (gradeValue == 'F'))
            {
                Console.WriteLine("The letter grade equivalent to " + gradeAverage + " is an " + gradeValue + ".");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("The letter grade equivalent to " + gradeAverage + " is a " + gradeValue + ".");
                Console.WriteLine("");
            }
            
        }
        static void Main(string[] args)
        {
            grading();
        }
    }
}