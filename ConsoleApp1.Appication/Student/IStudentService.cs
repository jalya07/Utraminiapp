using System;
using ConsoleApp1.Domain.Entities;

namespace ConsoleApp1.Appication
{
	public interface IStudentService
	{
		public void AddStudent(Student student);
		Student GetStudentById(int id);
		List<Student> GetAllStudents();
	}
}

