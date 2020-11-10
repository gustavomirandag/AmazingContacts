using AmazingContacts.DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazingContacts.DesktopApp
{
    public partial class Form1 : Form
    {
        //Represents our Database
        private static List<Contact> Contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegisterContact_Click(object sender, EventArgs e)
        {
            var contact = new Contact();
            contact.Name = textBoxName.Text;
            contact.Phone = textBoxPhone.Text;
            contact.Email = textBoxEmail.Text;
            contact.Address = textBoxAddress.Text;

            Contacts.Add(contact);

            ListAllContacts(Contacts);

            //Apagar Campos
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
        }

        private void ListAllContacts(List<Contact> contacts)
        {
            listBoxContacts.Items.Clear();

            foreach(var contact in contacts)
            {
                listBoxContacts.Items.Add($"{contact.Name} - {contact.Phone}");
            }
        }

        private void textBoxSearchByName_TextChanged(object sender, EventArgs e)
        {
            var name = ((TextBox)sender).Text;
            var searchResult = Contacts.Where(contact => contact.Name.ToLower().Contains(name.ToLower())).ToList();

            ListAllContacts(searchResult);
        }
    }
}
