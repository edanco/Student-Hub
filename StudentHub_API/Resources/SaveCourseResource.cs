﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHub_API.Resources
{
    public class SaveCourseResource
    {
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
    }
}
