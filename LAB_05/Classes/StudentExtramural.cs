using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    sealed class StudentExtramural : Student
    {
        private int numOfLectureWeeks;

        public StudentExtramural() : base()
        {

        }

        public StudentExtramural(string firstName, string lastName, int age, string placeOfStudy, string faculty, int numOfLectureWeeks) : base(firstName, lastName, age, placeOfStudy, faculty)
        {
            this.numOfLectureWeeks = numOfLectureWeeks;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}\nPlace of Study: {this.PlaceOfStudy}\nFaculty: {this.Faculty}\nNumber of Lecture weeks: {this.numOfLectureWeeks}";
        }

        public override void Learn()
        {
            Console.WriteLine("Приезжаю на лекционные недели и пишу конспекты!");
        }

        public override void GetMoney()
        {
            Console.WriteLine("Получаю зарплату");
        }
    }
}
