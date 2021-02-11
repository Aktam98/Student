using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPPWEB.Models
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students=null;
        public StudentRepository()
        {
           _students = new List<Student>()
           {
               new Student()
               {
                   Id=1,
                   FirstName="Aktam",
                   LastName="Abdunazarov",
                   Email="abdunazarov9798@gmail.com",
                   Univercity="UzMU"

               },
               new Student()
               {
                   Id=3,
                   FirstName="Kamol",
                   LastName="Hasanov",
                   Email="khasanov@gmail.com",
                   Univercity="UzMU"

               },
               new Student()
               {
                   Id=2,
                   FirstName="Fazliddin",
                   LastName="Safarov",
                   Email="safarovf@gmail.com",
                   Univercity="UzMU"

               },
               new Student()
               {
                   Id=4,
                   FirstName="Salim",
                   LastName="Egamov",
                   Email="segamov@gmail.com",
                   Univercity="UzMU"

               },
               new Student()
               {
                   Id=5,
                   FirstName="Diyor",
                   LastName="Choriyev",
                   Email="diyorf@gmail.com",
                   Univercity="TUIT"

               },
               new Student()
               {
                   Id=6,
                   FirstName="Doston",
                   LastName="Husanov",
                   Email="Hdoston@gmail.com",
                   Univercity="TATU"

               }
           };
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public Student Get(int id)
        {
            return _students.FirstOrDefault(Student => Student.Id.Equals(id));
        }

        public IEnumerable<Student> getUniverStudent(string univer)
        {
            var result = from s in _students
                         where s.Univercity.Equals(univer)
                         select s;
            return (IEnumerable<Student>)result;
            
        }
    }
}
