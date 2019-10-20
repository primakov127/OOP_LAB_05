using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    partial class Programmer
    {
        public override void GetMoney()
        {
            Console.WriteLine("Получаю все деньги мира!!!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Сплю 5 минут...");
        }

        public void Go()
        {
            Console.WriteLine("Иду как программист!");
        }
    }
}
