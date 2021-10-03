﻿using StudentHub_API.Domain.Services.Comunications;
using StudentHub_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHub_API.Domain.Services
{
    public interface ITutorService
    {
        Task<TutorResponse> GetByIdAsync(int id);
        Task<TutorResponse> SaveAsync(Tutor tutor);
        Task<TutorResponse> UpdateAsync(int id, Tutor tutor);
        Task<TutorResponse> DeleteAsync(int id);
    }
}