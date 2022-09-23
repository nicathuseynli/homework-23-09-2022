using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login.Register_Homework_23._09._2022.FilterContact
{
    public class FilterContact
    {
        List<Contact> contacts = new List<Contact>();
        public Contact DisplayByNumber(string number) 
        {
            return contacts.Where(c => c.Number == number).FirstOrDefault();
        }
        public void AddNUmber(Contact contact) { contacts.Add(contact); }
        public void View()
        {
            if (contacts != null && contacts.Count != 0)
            {
                foreach (Contact item in contacts)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public List<Contact> FilterByName(string name) 
        { 
            return contacts.Where(c => c.Name == name).ToList(); 
        }

    }
}
