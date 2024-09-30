using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Person
    {
        private int age = 1;
        public int Age
        {
            set
            {
                if (value < 1 || value > 120)
                    Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
                else
                    age = value;
            }
            get { return age; }
        }
    }
}
