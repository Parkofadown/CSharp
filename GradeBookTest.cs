using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2GuidedPractice3RichardBoyd
{
    class GradeBookTest
    {
        public static void Main(string[] args)
        {
            // Creating GradeBook object assigned to myGradeBook
            GradeBook myGradeBook = new GradeBook();
           
            // displaying initial value of CourseName
            Console.WriteLine("Initial course name is '{0}'\n", myGradeBook.CourseName);
           
            // prompt for and reading course name
            Console.WriteLine("Please enter the course name: ");
            myGradeBook.CourseName = Console.ReadLine();
            Console.WriteLine();

            // display welcome message after specifying course name
            myGradeBook.DisplayMessage();

            // keep prompt open
            Console.ReadKey();
        } // end Main
    } // end class GradeBookTest
}
