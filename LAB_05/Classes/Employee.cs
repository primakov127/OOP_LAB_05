using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    abstract class Employee : Working
    {


        protected Employee() : base()
        {

        }

        protected Employee(string firstName, string lastName, int age, string placeOfWork) : base(firstName, lastName, age, placeOfWork)
        {

        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}\nPlace of Work: {this.PlaceOfWork}";
        }

        public abstract void DoMentalWork();
    }
}
