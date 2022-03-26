using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        List<Student> students = StudentData.TestStudents;
        public Student GetStudentDataByUser(User user)
        {
            Student student = new Student();
            foreach (Student s in students)
            {
                if (user == null || !s.facultyNumber.Equals(user.FacNum))
                {
                    Console.WriteLine("Не е намерен такъв студент");
                    return null;
                }
            }

            return (from s in StudentData.TestStudents
                    where s.facultyNumber == user.FacNum
                    select s).First();
        }
    }
}
