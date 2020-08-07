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
            Console.WriteLine("Welcome to the grading machine.\nThis program is designed to convert your grades (in numbers) to their letter version counter parts.\nThe program will continue to read in grades until you enter -1.\nEnjoy!\n");
        }
        public static int getInt()
        {
            int num = 0;
            string input = "";
            Console.WriteLine("\nPlease enter an integer: \n");
            input = Console.ReadLine();
            num = Convert.ToInt32(input);
            return num;
        }
        public static void grading()
        {
            int grade = 0;
            int gradeCount = 0;
            int gradeSum = 0;
            double gradeAverage = 0.0;
            char gradeValue = 'A';
            printDirections();
            grade = getInt();
            switch (grade)
            {
                case -1:
                    break;  
            }
            while (grade != -1)
            {
                if ((grade <= 100) && (grade >= 90))
                {
                    gradeCount++;
                    gradeSum += grade;
                    Console.WriteLine("\nThe grade you entered is an A!\n");
                    grade = getInt();
                }
                else if ((grade < 90) && (grade >= 80))
                {
                    gradeCount++;
                    gradeSum += grade;
                    Console.WriteLine("\nThe grade you entered is a B!\n");
                    grade = getInt();
                }
                else if ((grade < 80) && (grade >= 70))
                {
                    gradeCount++;
                    gradeSum += grade;
                    Console.WriteLine("\nThe grade you entered is a C.\n");
                    grade = getInt();
                }
                else if ((grade < 70) && (grade >= 60))
                {
                    gradeCount++;
                    gradeSum += grade;
                    Console.WriteLine("\nThe grade you entered is a D.\n");
                    grade = getInt();
                }
                else if ((grade < 70) && (grade >= 1))
                {
                    gradeCount++;
                    gradeSum += grade;
                    Console.WriteLine("\nThe grade you entered is an F.\n");
                    grade = getInt();
                }
                else
                {
                    Console.WriteLine("\nYou have entered an invalid grade, please try again\n");
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
            Console.WriteLine("\nThe average of the grades you entered (in numerical form) is " + gradeAverage + ".\n");
            if ((gradeValue == 'A') || (gradeValue == 'F'))
            {
                Console.WriteLine("\nThe letter grade equivalent to " + gradeAverage + " is an " + gradeValue + ".\n");
            }
            else
            {
                Console.WriteLine("\nThe letter grade equivalent to " + gradeAverage + " is a " + gradeValue + ".\n");
            }
        }
        static void Main(string[] args)
        {
            grading();
        }
    }
}
