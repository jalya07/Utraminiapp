using System;
namespace ConsoleApp1.Domain.Entities
{
	public class Student
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Assignment> Assigments { get; set; }
    }
}

