using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.Task2.EditPerson
{
   public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return LastName + " " + FirstName + "\n Возраст: " + Age + "\n";
        }
    }
}
