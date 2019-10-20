using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    class Turner : Working, IDo
    {
        private int discharge; // разряд

        public Turner() : base()
        {
        }

        public Turner(string firstName, string lastName, int age, string placeOfWork, int discharge) : base(firstName, lastName, age, placeOfWork)
        {
            this.discharge = discharge;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}\nPlace of Work: {this.PlaceOfWork}\nDischarge: {this.discharge}";
        }

        public override void Sleep()
        {
            Console.WriteLine("Сплю 8 часов в сутки...");
        }

        void IDo.Sleep()
        {
            Console.WriteLine("Явная реализация IDo.Sleep()");
        }

        public void Go()
        {
            Console.WriteLine("Иду как токарь!");
        }
    }
}
