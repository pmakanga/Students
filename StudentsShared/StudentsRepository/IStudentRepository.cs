﻿using Students.StudentsShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsShared.StudentsRepository
{
    public interface IStudentRepository
    {
        Task<Student>AddStudentAsync(Student student);
        Task<Student>UpdateStudentAsync(Student student);
        Task<Student>DeleteStudentAsync(Guid studentId);
        Task<List<Student>> GetAllStudentsAsync();
        Task<Student>GetStudentByIdAsync(Guid studentId);
    }
}
