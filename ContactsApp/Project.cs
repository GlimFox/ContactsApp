using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, содержащий список всех контактов.
    /// </summary>
    public class Project
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }

}
