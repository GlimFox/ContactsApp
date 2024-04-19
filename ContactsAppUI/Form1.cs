using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactsAppUI
{
    public partial class Form1 : Form
    {
        private Project project;
        private Contact selectedContact;

        public Form1()
        {
            InitializeComponent();

            // Создание экземпляра проекта и контакта
            project = new Project();
            selectedContact = new Contact(
                "Хайбулин",
                "Никита",
                new PhoneNumber("78005553535"),
                new DateTime(2004, 2, 14),
                "ivanov@example.ru",
                "172883764"
            );

            // Добавление контакта в проект
            project.Contacts.Add(selectedContact);

            label1.Text = selectedContact.Surname;
            label2.Text = selectedContact.Name;
            label3.Text = selectedContact.PhoneNumber.ToString();
            label4.Text = selectedContact.Birthdate.ToShortDateString();
            label5.Text = selectedContact.Email;
            label6.Text = selectedContact.VkId;

        }
    }
}
