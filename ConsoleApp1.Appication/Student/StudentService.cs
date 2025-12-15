using ConsoleApp1.Domain.Entities;

namespace ConsoleApp1.Appication;

public class StudentService:IStudentService
{
    public List<Student> Students { get; set; } = new List<Student>();

    public void AddStudent(Student student)
    {
        student.Id = Students.Count + 1;
        Students.Add(student);
    }

    public List<Student> GetAllStudents()
    {
        return Students;
        
    }

    public Student GetStudentById(int id)
    {
        foreach (Student student in Students)
        {
            if (student.Id == id)
            {
                return student;
            }
        }
        return null;
    }
}

