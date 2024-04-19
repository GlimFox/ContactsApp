using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс для хранения номера телефона.
    /// Номер должен быть российским и содержать 11 цифр, начиная с '7'.
    /// </summary>
    public class PhoneNumber
    {
        private string _number;

        /// <summary>
        /// Получает или устанавливает номер телефона РФ.
        /// </summary>
        /// <exception cref="ArgumentException">Исключение возникает, если номер не начинается с '7' или не содержит ровно 11 цифр.</exception>
        public string Number
        {
            get { return _number; }
            set
            {
                if (value.Length != 11 || !value.StartsWith("7"))
                {
                    throw new ArgumentException($"Номер должен начинаться с '7' и содержать 11 цифр, а был '{value}'");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Конструктор для инициализации номера телефона.
        /// </summary>
        /// <param name="number">Номер телефона.</param>
        public PhoneNumber(string number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return '+' + Number;
        }
    }

}
