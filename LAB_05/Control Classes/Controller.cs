using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    static class Controller
    {
        public static int CountOfStudent(Person[] items)
        {
            int count = 0;
            foreach (Person i in items)
            {
                if (i is Student)
                    count++;
            }
            return count;
        }

        public static void SearchProgrammer(Person[] items)
        {
            Console.WriteLine("Programmers: ");
            foreach (Person i in items)
            {
                if (i is Programmer)
                    Console.WriteLine(i.ToString());
            }
        }

        public static Person[] AgeSort(Person[] items)
        {
            return QuickSort(items, 0, items.Length - 1);
        }

        private static Person[] QuickSort(Person[] a, int i, int j)
        {
            if (i < j)
            {
                int q = Partition(a, i, j);
                a = QuickSort(a, i, q);
                a = QuickSort(a, q + 1, j);
            }
            return a;
        }

        private static int Partition(Person[] a, int p, int r)
        {
            int x = a[p].Age;
            int i = p - 1;
            int j = r + 1;
            while (true)
            {
                do
                {
                    j--;
                }
                while (a[j].Age > x);
                do
                {
                    i++;
                }
                while (a[i].Age < x);
                if (i < j)
                {
                    Person tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                }
                else
                {
                    return j;
                }
            }

        }
    }
}
