﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHub_API.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Relación con Tutor
        public List<Tutor> Tutors { get; set; }
    }
}
