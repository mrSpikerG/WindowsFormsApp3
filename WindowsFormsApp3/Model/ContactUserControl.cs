using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Model
{
    public partial class ContactUserControl : UserControl
    {

        public ulong id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public List<string> Phones { get; set; }
        public string PhoneString { get; set; }


        public ContactUserControl(string name, string surname, List<string> phonesNum, string adress)
        {
            InitializeComponent();
            this.Name = name;
            this.Surname = surname;
            this.Phones = phonesNum;
            this.Adress = adress;

            /*for (int i = 0; i < phonesNum.Count; i++)
            {
                phonesNum[i] = $"Phone {i + 1}: {phonesNum[i]}";
            }*/
            this.PhoneString = String.Join("\n", phonesNum);

            this.label1.Text = $"{name} {surname}";
            this.label2.Text = adress;


        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
