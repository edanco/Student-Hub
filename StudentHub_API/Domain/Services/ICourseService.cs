﻿using StudentHub_API.Domain.Models;
using StudentHub_API.Domain.Services.Comunications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHub_API.Domain.Services
{
    public interface ICourseService
    {
        Task<CourseResponse> GetByIdAsync(int id);
        Task<CourseResponse> SaveAsync(Course course);
        Task<CourseResponse> UpdateAsync(int id, Course course);
        Task<CourseResponse> DeleteAsync(int id);
    }
}
