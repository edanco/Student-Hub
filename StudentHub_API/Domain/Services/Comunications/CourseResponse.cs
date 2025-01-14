﻿using StudentHub_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHub_API.Domain.Services.Comunications
{
    public class CourseResponse : BaseResponse<Course>
    {
        public CourseResponse(Course resource) : base(resource)
        {

        }

        public CourseResponse(string message) : base(message)
        {

        }
    }
}
