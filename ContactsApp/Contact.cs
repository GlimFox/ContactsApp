using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс для хранения информации о контакте.
    /// </summary>
    public class Contact : ICloneable
    {
        private string _surname;
        private string _name;
        private string _email;
        private string _vkId;
        private DateTime _birthdate;
        public PhoneNumber PhoneNumber { get; set; }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("Фамилия не может быть длиннее 50 символов.");
                _surname = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("Имя не может быть длиннее 50 символов.");
                _name = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("E-mail не может быть длиннее 50 символов.");
                _email = value;
            }
        }

        public string VkId
        {
            get { return _vkId; }
            set
            {
                if (value.Length > 15)
                    throw new ArgumentException("ID ВКонтакте не может быть длиннее 15 символов.");
                _vkId = value;
            }
        }

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                if (value > DateTime.Now || value.Year < 1900)
                    throw new ArgumentException("Дата рождения не может быть в будущем или до 1900 года.");
                _birthdate = value;
            }
        }

        /// <summary>
        /// Конструктор для создания контакта.
        /// </summary>
        /// <param name="surname">Фамилия контакта.</param>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Телефонный номер.</param>
        /// <param name="birthdate">Дата рождения.</param>
        /// <param name="email">Электронная почта.</param>
        /// <param name="vkId">ID ВКонтакте.</param>
        public Contact(string surname, string name, PhoneNumber phoneNumber, DateTime birthdate, string email, string vkId)
        {
            Surname = surname;
            Name = name;
            PhoneNumber = phoneNumber;
            Birthdate = birthdate;
            Email = email;
            VkId = vkId;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
