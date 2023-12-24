using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_managment
{


        class Program
        {

            class Student 
            {
                // Properties of a student (e.g., Id, Name, Age, Grade)
                public int Id { get; set; }
                public string Name { get; set; }
                public int Age { get; set; }
                public string Grade { get; set; }
            }

            class Teacher
            {
                // Properties of a teacher (e.g., Id, Name, Subject)
                public int Id { get; set; }
                public string Name { get; set; }
                public string Subject { get; set; }
            }

            class Course
            {
                // Properties of a course (e.g., Id, Name, Teacher, Students)
                public int Id { get; set; }
                public string Name { get; set; }
                public Teacher Teacher { get; set; }
                public List<Student> Students { get; set; }




            static List<Student> students = new List<Student>();
            static List<Teacher> teachers = new List<Teacher>();
            static List<Course> courses = new List<Course>();

            static void Main(string[] args)
            {
                while (true)
                {
                    // Display main menu
                    Console.WriteLine("\nSchool Management System");
                    Console.WriteLine("1. Student Management");
                    Console.WriteLine("2. Teacher Management");
                    Console.WriteLine("3. Course Management");
                    Console.WriteLine("4. Exit");

                    // Get user choice
                    int choice;
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                StudentManagement();
                                break;
                            case 2:
                                TeacherManagement();
                                break;
                            case 3:
                                CourseManagement();
                                break;
                            case 4:
                                Console.WriteLine("Exiting...");
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
            }

            // Implement StudentManagement, TeacherManagement, and CourseManagement methods here

            static void StudentManagement()
            {
                // Add code for student management functionality
                int id; string name; int age; int grade;

                    while (true)
    {
        Console.WriteLine("\nStudent Management");
        Console.WriteLine("1. ID ");
        Console.WriteLine("2. Name");
        Console.WriteLine("3. Age");
        Console.WriteLine("4. Grade");
        
        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    id();
                    break;
                case 2:
                    Name();
                    break;
                case 3:
                    Age();
                    break;
                case 4:
                    Grade();
                    break;
                   default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}


            }

            static void TeacherManagement()
            {
                // Add code for teacher management functionality
            }

            static void CourseManagement()
            {
                // Add code for course management functionality
            }
        }
    }
}

