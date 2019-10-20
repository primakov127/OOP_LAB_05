using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    class Student : Training, IDo
    {
        private string faculty;

        protected string Faculty
        {
            get { return faculty; }
            set
            {
                if (value == "FIT")
                    throw new FacultyException("Неверный факультет!");
                else
                    faculty = value;
            }
        }

        public Student() : base()
        {

        }

        public Student(string firstName, string lastName, int age, string placeOfStudy, string faculty) : base(firstName, lastName, age, placeOfStudy)
        {
            this.Faculty = faculty;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}\nPlace of Study: {this.PlaceOfStudy}\nFaculty: {this.Faculty}";
        }

        public override void Learn()
        {
            Console.WriteLine("Хожу на все пары и пишу конспекты!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Сплю на парах!!!");
        }

        public void Go()
        {
            Console.WriteLine("Иду как студент!");
        }
    }
}
