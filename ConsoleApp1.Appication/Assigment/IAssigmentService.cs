using System;
using ConsoleApp1.Domain.Entities;

namespace ConsoleApp1.Appication
{
	public interface IAssignmentService
	{
		public void AddTask(int studentId, Assignment assignment);
		public void CompleteTask(int studentId,int assignmentId);
		List<Assignment> GetAssignmentByStudent(int studentId);
	}
}

