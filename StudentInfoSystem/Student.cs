﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Student
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string faculty { get; set; }
        public string specialty { get; set; }
        public string qualificationDegree { get; set; }
        public string status { get; set; }
        public string facultyNumber { get; set; }
        public int course { get; set; }
        public int flow { get; set; }
        public int group { get; set; }

        public Student() { 
        }

        public Student(string firstName, string middleName, string lastName, string faculty, string speciality, string degree, string status, string facultyNumber, int course, int flow, int group)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.faculty = faculty;
            this.specialty = speciality;
            this.qualificationDegree = degree;
            this.status = status;
            this.facultyNumber = facultyNumber;
            this.course = course;
            this.flow = flow;
            this.group = group;
        }
    }
}
