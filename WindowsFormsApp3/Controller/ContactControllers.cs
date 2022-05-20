using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Controller
{
    public static class ContactControllers
    {
        public static  List<ContactUserControl> contacts = new List<ContactUserControl>() { 
          /*  new ContactUserControl("name", "surname", new List<string> { "number1", "number2" }, "adress"),
            new ContactUserControl("Vasya", "Petrov", new List<string> { "number1", "number2" }, "Dnipro"),
            new ContactUserControl("Petyua", "vasilyev", new List<string> { "number1", "number2" }, "Kyiv")*/
        };
      

        public static List<ContactUserControl> getContacts()
        {
          //  SaveDataControllers.getData();
            return contacts;
        }
        public static void addContacts(ContactUserControl newContact)
        {
            contacts.Add(newContact);
        }
        public static void removeContacts(ContactUserControl removedContact)
        {
            contacts.Remove(removedContact);
        }

    }
}
