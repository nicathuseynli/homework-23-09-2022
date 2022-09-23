using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Register_Homework_23._09._2022.FilterContact
{
    public class Contact
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public Contact(string number, string name)
        {
             Number = number;
             Name = name;
        }
        public override string ToString()
        {
            return Name + " " + Number;
        }
       
    }
}
