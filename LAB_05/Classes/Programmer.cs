using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    partial class Programmer : Employee, IDo
    {
        private string programLanguage;

        public Programmer() : base()
        {

        }

        public Programmer(string firstName, string lastName, int age, string placeOfWork, string programLanguage) : base(firstName, lastName, age, placeOfWork)
        {
            this.programLanguage = programLanguage;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}\nPlace of Work: {this.PlaceOfWork}\nProgram Language: {this.programLanguage}";
        }

        public override void DoMentalWork()
        {
            Console.WriteLine("Думаю над кодом приложения...");
        }

        //public override void GetMoney()
        //{
        //    Console.WriteLine("Получаю все деньги мира!!!");
        //}

        //public override void Sleep()
        //{
        //    Console.WriteLine("Сплю 5 минут...");
        //}

        //public void Go()
        //{
        //    Console.WriteLine("Иду как программист!");
        //}
    }
}
