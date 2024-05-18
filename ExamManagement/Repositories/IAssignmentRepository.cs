﻿using ExamManagement.Models;

namespace ExamManagement.Repositories
{
    public interface IAssignmentRepository
    {
        Task<Assignment> CreateAssignmentAsync(Assignment assignment, List<Question> questions, string teacherId);
        Task<Assignment> GetAssignmentByIdAsync(int id); // Include Questions in ViewModel
    }
}
