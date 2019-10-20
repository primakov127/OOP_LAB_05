using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    class FocusGroup
    {

        private Person[] items = new Person[0];
        public int Count { get; private set; }

        public FocusGroup()
        {
            Count = 0;
        }

        public Person[] Get()
        {
            return items;
        }

        public void Set(Person[] items)
        {
            this.items = items;
            this.Count = items.Length;
        }

        public void AddPerson(Person item)
        {
            Array.Resize(ref items, items.Count() + 1);
            items[items.Count() - 1] = item;
            Count++;
        }

        public void RemovePerson(Person item)
        {
            items[Array.IndexOf(items, item)] = items[items.Count() - 1];
            Array.Resize(ref items, items.Count() - 1);
            Count--;
        }

        public Person this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }


        public IEnumerable<Person> getItems()
        {
            return items;
        }

        public void printAll()
        {
            Console.WriteLine();
            foreach (var oneitem in getItems())
            {
                Console.WriteLine(oneitem.ToString());
            }
            Console.WriteLine();
        }

        private bool attend(Person item)
        {
            bool rc = false;
            foreach (var oneitem in getItems())
            {
                if (item.ToString() == oneitem.ToString())
                    rc = true;
            }
            return rc;
        }

        
    }
}
