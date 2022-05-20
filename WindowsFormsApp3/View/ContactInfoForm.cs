using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Controller;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.View
{
    public partial class ContactInfoForm : Form
    {
        private ContactUserControl currentUser;
        public ContactInfoForm(ContactUserControl user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.label1.Text = $"{user.Name} {user.Surname}";
            this.label2.Text = user.PhoneString;
            this.label3.Text = user.Adress;
            this.AutoSize = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContactControllers.removeContacts(this.currentUser);
            SaveDataControllers.saveData();
            this.Close();
        }
    }
}
