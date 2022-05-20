using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Controller
{
    public static class SaveDataControllers
    {

        public static void saveData()
        {
            if (checkForData())
            {
                File.WriteAllText("Data/Database.txt", "");
                for (int i = 0; i < ContactControllers.getContacts().Count; i++)
                {
                    if (i != 0)
                    {
                        File.AppendAllText("Data/Database.txt", "\n");
                    }
                    File.AppendAllText("Data/Database.txt", $"{ContactControllers.getContacts()[i].Name}|{ContactControllers.getContacts()[i].Surname}|{ContactControllers.getContacts()[i].Adress}|{ContactControllers.getContacts()[i].Phones.Count}|");
                    for (int j = 0; j < ContactControllers.getContacts()[i].Phones.Count; j++)
                    {
                        File.AppendAllText("Data/Database.txt", $"{ContactControllers.getContacts()[i].Phones[j]}=");
                    }
                }
            }
        }

        public static void getData()
        {
            if (checkForData())
            {
                string allText = File.ReadAllText("Data/Database.txt");
                string[] items = allText.Split('\n');

                for (int i = 0; i < items.Length; i++)
                {
                    string[] temp = items[i].Split('|');

                    int x = 0;
                    if (x == 2)
                    {
                        x++;
                    }

                    x++;

                    string[] numbers = new string[1];
                    try
                    {
                        numbers = temp[4].Split('=');
                    }
                    catch (Exception e)
                    {

                    }
                    List<string> phones = new List<string>();

                    for (int j = 0; j < Convert.ToInt32(temp[3]); j++)
                    {
                        phones.Add(numbers[j]);
                    }

                    ContactControllers.addContacts(new Model.ContactUserControl(
                        temp[0], temp[1], phones, temp[2]));
                }


            }
        }

        private static bool checkForData()
        {
            if (!Directory.Exists("Data")) { Directory.CreateDirectory("Data"); }
            if (!File.Exists("Data/Database.txt"))
            {
                File.Create("Data/Database.txt");
                return false;
            }
            return true;
        }
    }
}
