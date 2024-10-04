using System;

namespace StudentGradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int maths;
            int physics;
            int chemistry;
            int computerScience;
            double average;
            char grade;

            // Create an instance of GradeCalculator
            GradeCalculator studentGrades = new GradeCalculator();

            try
            {
                //Prompt the user for their marks

                Console.Write("Enter the marks for maths: ");
                maths = int.Parse(Console.ReadLine());
                if (maths < 0 || maths > 100) throw new ArgumentOutOfRangeException();

                Console.Write("Enter the marks for physics: ");
                physics = int.Parse(Console.ReadLine());
                if (physics < 0 || physics > 100) throw new ArgumentOutOfRangeException();

                Console.Write("Enter the marks for chemistry: ");
                chemistry = int.Parse(Console.ReadLine());
                if (chemistry < 0 || chemistry > 100) throw new ArgumentOutOfRangeException();

                Console.Write("Enter the marks for computer science: ");
                computerScience = int.Parse(Console.ReadLine());
                if (computerScience < 0 || computerScience > 100) throw new ArgumentOutOfRangeException();

                average = studentGrades.CalculateAverage(maths, physics, chemistry, computerScience);

                grade = studentGrades.GetGrade(average);

                // Display the appropriate remark
                switch (grade)
                {
                    case 'A':
                        Console.WriteLine("Excellent! Your grade is A");
                        break;
                    case 'B':
                        Console.WriteLine("Good! Your grade is B");
                        break;
                    case 'C':
                        Console.WriteLine("Satisfactory. Your grade is C");
                        break;
                    case 'D':
                        Console.WriteLine("Pass. Your grade is D");
                        break;
                    case 'F':
                        Console.WriteLine("Fail. Your grade is F");
                        break;
                    default:
                        Console.WriteLine("Invalid grade.");
                        break;
                }
            }
            // Error messages for exceptions
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a number.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your marks must be between 0 and 100");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message + ".");
            }
        }
    }

    // Create a class to hold the functions.
    class GradeCalculator
    {
        // Method to calculate average marks
        public double CalculateAverage(int maths, int physics, int chemistry, int computerScience)
        {
            double average = (maths + physics + chemistry + computerScience) / 4.0;
            return average;
        }

        // Calculate the average of the student's marks
        public char GetGrade(double average)
        {
            if (average >= 80)
                return 'A';
            else if (average >= 70)
                return 'B';
            else if (average >= 60)
                return 'C';
            else if (average >= 50)
                return 'D';
            else
                return 'F';
        }
    }
}
