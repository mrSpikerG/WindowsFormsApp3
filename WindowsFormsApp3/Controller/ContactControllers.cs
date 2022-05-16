using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Controller
{
    public class ContactControllers
    {
        public  List<ContactUserControl> contacts;
        public ContactControllers()
        {
            contacts = new List<ContactUserControl>();

            addContacts(new ContactUserControl("name", "surname", new List<string> { "number1", "number2" }, "adress"));
            addContacts(new ContactUserControl("Vasya", "Petrov", new List<string> { "number1", "number2" }, "Dnipro"));
            addContacts(new ContactUserControl("Petyua", "vasilyev", new List<string> { "number1", "number2" }, "Kyiv"));
        }


        public  List<ContactUserControl> getContacts()
        {
            return contacts;
        }
        public  void addContacts(ContactUserControl newContact)
        {
            contacts.Add(newContact);
        }
        public void removeContacts(ContactUserControl removedContact)
        {
            contacts.Remove(removedContact);
        }

    }
}
