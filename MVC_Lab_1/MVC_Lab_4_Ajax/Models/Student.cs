﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Lab_4_Ajax.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Personnumber { get; set; }
        public string Address { get; set; }
        public List<Grade> Grades { get; set; }
    }
}