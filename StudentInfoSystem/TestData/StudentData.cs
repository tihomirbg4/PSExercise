using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {

        private static List<Student> students;
        public static List<Student> TestStudents
        {
            get
            {
                fillStudentsData();
                return students;
            }
            set { }
        }

        public static void fillStudentsData()
        {
            if (students == null)
            {
                students = new List<Student>
                {
                    new Student
                    {
                        firstName = "Pesho",
                        middleName = "Petrov",
                        lastName = "Ivanov",
                        faculty = "FCST",
                        major = "KSI",
                        qualificationDegree = "Bachelor",
                        status = "zaveril",
                        facultyNumber = "121219096",
                        course = 3,
                        stream = 9,
                        group = 31,
                    },
                     new Student
                     {
                         firstName = "Ivan",
                         middleName = "Petrov",
                         lastName = "Georgiev",
                         faculty = "FCST",
                         major = "KSI",
                         qualificationDegree = "Master",
                         status = "redoven",
                         facultyNumber = "121219200",
                         course = 5,
                         stream = 12,
                         group = 55,
                     },
                 };
            }
            }
        }
}
