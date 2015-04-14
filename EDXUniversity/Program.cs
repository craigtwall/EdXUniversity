using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDXUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            /*      Module 1 Assignment
             *      Creating Variables for Student, Professor and University info.
             *      Object-Oriented classes aren't implemented yet, so 
             *      these are created as just a long list of variables.
             
             */

            // Student variables
            string student_firstname, student_lastname;
            DateTime student_birthdate;
            
            string student_addressone, student_addresstwo;

            string student_city, student_state, student_country;
            string student_zip;         //Declaring as an INT truncates the leading zero

            // Professor variables
            string professor_firstname, professor_lastname;
            string professor_dept;

            // Degree variables
            string program, degree;
            string dept_head;

            // Course variables
            string course_name, course_code; 
            int credits;
            string course_term;        //ex: Spring 2015 


            // Student Assignments
            student_lastname = "Wall"; student_firstname = "Craig";
            student_birthdate = new DateTime(1981, 09, 07);
            student_addressone = "1 Main Street";
            student_city = "Paramus"; student_state = "NJ"; student_zip = "07652";

            // Professor Assignments
            professor_lastname = "Snarf"; professor_firstname = "Randall";
            professor_dept = "Computer Science";

            // Degree Assignments
            program = "Computer Science";
            degree = "Bachelor's";
            dept_head = "Snarf, Randall";

            // Course Assignments
            course_name = "Intro to CS";
            course_code = "CS-101"; credits = 3;
            course_term = "Summer 2015";


            // Output
            Console.WriteLine("Student Name: " + student_firstname + " " + student_lastname);
            Console.WriteLine("Birthdate: " + student_birthdate.Month + "/" + student_birthdate.Day + "/" + student_birthdate.Year + "\n");

            Console.WriteLine("Address: " + student_addressone);
            Console.WriteLine(student_city + ", " + student_state + "  " + student_zip + "\n");

            Console.WriteLine("Professor: " + professor_lastname + ", " + professor_firstname + "\n" +
                "Department: " + professor_dept + "\n");

            Console.WriteLine("Program: " + degree + " of " + program + "\n" + 
                "Department Head: " + dept_head + "\n");
            
            Console.WriteLine("Course: " + course_code + " -- " + course_name + "\n" + 
                "Credits: " + credits + "\n" +
                "Term: " + course_term);

            Console.ReadLine();


        }
    }
}
