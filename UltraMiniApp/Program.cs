using ConsoleApp1.Appication;
using ConsoleApp1.Domain.Entities;

namespace UltraMiniApp;

class Program
{
    static void Main(string[] args)
    {
        IStudentService studentService = new StudentService();
        IAssignmentService assignmentService = new AssigmentService(studentService);
        while (true)
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("Add Task to Student");
            Console.WriteLine("Complete Task");
            Console.WriteLine("4.List Student Tasks");
            Console.WriteLine("0.Exit");
            string option = Console.ReadLine();
            try
            {
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Add new Student");
                        Console.WriteLine("Student Name:");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Student Id:");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Student email:");
                        string Email = Console.ReadLine();
                        studentService.AddStudent(new Student
                        {
                            Name=Name,
                            Email=Email,
                        });
                        Console.WriteLine("Student add successfully!");
                        break;
                    case "2":
                        //Console.WriteLine("Add task to student");
                        //Console.WriteLine("add id:");
                        //int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("add title:");
                        string Title = Console.ReadLine();
                        Console.WriteLine("add assignment");
                        string Assignment = Console.ReadLine();
                        //Console.WriteLine("add description:");
                        //string Description = Console.ReadLine();
                        Console.WriteLine("add DueData:");
                        DateOnly DueDate = DateOnly.Parse(Console.ReadLine());
                        assignmentService.AddTask(Id,new Assignment
                        {

                        });
                }
                
            }
        }

    }
}

