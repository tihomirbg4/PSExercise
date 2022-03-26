using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {

        private static List<Student> students = new List<Student>();
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
            students.Add(new Student());
            students[0].firstName = "Pesho";
            students[0].middleName = "Petrov";
            students[0].lastName = "Ivanov";
            students[0].faculty = "FCST";
            students[0].specialty = "KSI";
            students[0].qualificationDegree = "Bachelor's";
            students[0].status = "zaveril";
            students[0].facultyNumber = "121219096";
            students[0].course = 3;
            students[0].flow = 10;
            students[0].group = 31;
        }
    }
}
