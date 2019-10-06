using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2GuidedPractice3RichardBoyd
{
    class GradeBook
    {
        private string courseName; // course name for this GradeBook -- instance variable

        //property to get and set the course name
        public string CourseName
        {
            get
            {
                return courseName;
            } // end get
            set
            {
                courseName = value;
            } // end set
        } // end property CourseName

        // display a welcome message to GradeBook user
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for\n{0}!", CourseName);
        }

    } // end class GradeBook
}
