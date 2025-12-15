using System;
using ConsoleApp1.Domain.Entities;

namespace ConsoleApp1.Appication
{
	public class AssigmentService:IAssignmentService
	{
        private readonly IStudentService _studentService;

        public AssigmentService(IStudentService studentService)
        {
            _studentService = studentService;
        }
        List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public void AddTask(int studentId, Assignment assignment)
        {
            Student student = _studentService.GetStudentById(studentId);
            if (studentId == null)
            {
                Console.WriteLine("student not found");
                return;
            }
            student.Assigments.Add(assignment);
        }

        public void CompleteTask(int studentId, int assignmentId)
        {
            Student student = _studentService.GetStudentById(studentId);
            if (studentId == null)
            {
                Console.WriteLine("student not found");
                return;
            }
            foreach(Assignment assignment in student.Assigments)
            {
                if (assignment.Id == assignmentId)
                {
                    assignment.IsCompleted = true;
                    return;
                }
            }
            Console.WriteLine("assigment not found!");
        }

        public List<Assignment> GetAssignmentByStudent(int studentId)
        {
            Student student = _studentService.GetStudentById(studentId);
            if (studentId == null)
            {
                return new List<Assignment>();
            }
            return student.Assigments;
        }
    }
}

