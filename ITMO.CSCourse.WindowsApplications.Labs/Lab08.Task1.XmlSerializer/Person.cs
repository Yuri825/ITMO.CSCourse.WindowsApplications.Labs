﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab04.Task2.EditPerson
{
    [Serializable, XmlRoot(Namespace = "http://www.MyCompany.com")]

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NonSerialized]
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        //public int Age { get; set; }

        public override string ToString()
        {
            return LastName + " " + FirstName + "\n Возраст: " + Age + "\n";
        }
    }
}
