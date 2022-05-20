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
using WindowsFormsApp3.View;

namespace WindowsFormsApp3.Model
{
    public partial class ContactListUserControl : UserControl
    {
        public ContactListUserControl()
        {
            InitializeComponent();
            this.AutoScroll = true;

            list = ContactControllers.getContacts();
            for(int i = 0; i < list.Count; i++)
            {
                ContactUserControl temp = list[i];
                temp.Click += showMoreInfoEvent;
                temp.Location = new Point(0, (temp.Size.Height+2) * i);
                this.Controls.Add(temp);
            }
        }
        

        private void showMoreInfoEvent(object sender, EventArgs e)
        {
            form = new ContactInfoForm(sender as ContactUserControl);
            form.Show();
            
        }

        ContactInfoForm form;
        List<ContactUserControl> list;
    }
}
