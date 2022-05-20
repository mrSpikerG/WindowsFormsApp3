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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text != String.Empty && this.richTextBox2.Text != String.Empty && this.richTextBox3.Text != String.Empty && this.richTextBox8.Text != String.Empty)
            {
                phones = new List<string>();

                phones.Add(this.richTextBox3.Text);
                if (this.richTextBox4.Text != String.Empty) { phones.Add(this.richTextBox4.Text); };
                if (this.richTextBox5.Text != String.Empty) { phones.Add(this.richTextBox5.Text); };
                if (this.richTextBox6.Text != String.Empty) { phones.Add(this.richTextBox6.Text); };
                if (this.richTextBox7.Text != String.Empty) { phones.Add(this.richTextBox7.Text); };

                ContactControllers.addContacts(new ContactUserControl(this.richTextBox1.Text, this.richTextBox2.Text, phones, this.richTextBox8.Text));
                SaveDataControllers.saveData();
                this.Close();
            }
        }
        private List<string> phones;
    }
}
