using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Controller;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.View;

namespace PhoneContacts.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SaveDataControllers.getData();
            InitializeComponent();
            this.ClientSize = new Size(300, 400);
            this.addContact_Button.Location = new Point(this.ClientSize.Width - this.addContact_Button.Size.Width, this.ClientSize.Height - this.addContact_Button.Size.Height);
            this.update_Button.Location = new Point(this.ClientSize.Width - this.update_Button.Size.Width - this.addContact_Button.Width, this.ClientSize.Height - this.update_Button.Size.Height);

            ContactListUserControl listUsers = new ContactListUserControl();


            this.Controls.Add(listUsers);
            this.Invalidate();



        }

        //  private ContactUserControl lastControl;
        private void addContact_Event(object sender, EventArgs e)
        {
            AddContact_Form = new AddContactForm();
            AddContact_Form.Show();
            // lastControl = AddContact_Form.contact;

        }
        private void updateListBox_Event(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            mainform.Show();
            // this.Contacts_ListBox = new ListBox();
            for (int i = 0; i < ContactControllers.getContacts().Count; i++)
            {
                //   Contacts_ListBox.Items.Add(ContactControllers.getContacts()[i]);
            }
        }

        private AddContactForm AddContact_Form;

        private void addContact_Button_Click(object sender, EventArgs e)
        {
            AddContact_Form = new AddContactForm();
            AddContact_Form.Show();
        }
    }
}
