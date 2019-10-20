using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LAB_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            try
            {
                Turner man1 = new Turner("Max", "Prymakou", 20, "BSTU", 5);
                ((IDo)man1).Sleep();
                man1.Sleep();

                Student man2 = new Student("Den", "Palchevskiu", 19, "BNTU", "GHaT");
                StudentExtramural man3 = new StudentExtramural("Katya", "Matskevich", 25, "BSU", "FaN", 4);
                Programmer man4 = new Programmer("Andrey", "Krotov", 21, "EPAM", "C#");

                if (man1 is Working)
                {
                    Working link1 = man1 as Working;
                    link1.GetMoney();
                }

                Console.WriteLine(5 + Person.num.three);
                man1.NameExample.FirstNmae = "rdfd";
                man1.NameExample.LastName = "dfsdf";

                FocusGroup group = new FocusGroup();
                group.AddPerson(man1);
                group.AddPerson(man2);
                group.AddPerson(man3);
                group.AddPerson(man4);
                group.printAll();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Count of Student: {Controller.CountOfStudent(group.Get())}");
                Controller.SearchProgrammer(group.Get());
                Controller.AgeSort(group.Get());
                group.printAll();
                //Person[] arr = { man1, man2, man3, man4 };
                //Printer obj = new Printer();
                //foreach (Person i in arr)
                //{
                //    obj.IAmPrinting(i);
                //}




                #region Error1
                //int g = 5;
                //int y = g / 0;
                #endregion Error1
                #region Error2
                //int[] mass = { 2, 4, 5 };
                //int y = mass[3];
                #endregion Error2
                #region Error3
                //Programmer man5 = new Programmer("Axel", "Gardienko", 15, "LeverX", "JavaScript");
                #endregion Error3
                #region Error4
                //Turner man6 = new Turner("James", "Tokinav", 18, "Zara", 5);
                #endregion Error4
                #region Error5
                //Student man7 = new Student("Tolik", "Rakovich", 17, "BNTU", "FIT");
                #endregion Error5

                //int[] aa = null;
                //Debug.Assert(aa != null, "values array cannot be null");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
                //throw;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            catch (WorkPlaceException ex) when(x == 0)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FacultyException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (PersonException ex)
            {
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }



        }
    }
}
