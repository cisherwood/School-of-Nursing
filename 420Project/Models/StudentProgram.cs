﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _420Project.Models
{
    public class StudentProgram
    {
        public int StudentProgramId { get; set; }
        public int StudentId { get; set; }
        public int ProgramId { get; set; }
        public string Status { get; set; }
        public double GPA { get; set; }



        public virtual Student Student { get; set; }
        public virtual Program Program { get; set; }

    }
}