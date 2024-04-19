using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ContactsApp
{
    /// <summary>
    /// Класс для сериализации и десериализации данных проекта.
    /// </summary>
    public static class ProjectManager
    {
        private const string Filename = @"..\My Documents\ContactsApp.notes";

        /// <summary>
        /// Сохраняет объект проекта в файл в формате JSON.
        /// </summary>
        /// <param name="project">Проект для сохранения.</param>
        public static void SaveToFile(Project project)
        {
            string json = JsonConvert.SerializeObject(project);
            File.WriteAllText(Filename, json);
        }

        /// <summary>
        /// Загружает проект из файла.
        /// </summary>
        /// <returns>Загруженный проект.</returns>
        public static Project LoadFromFile()
        {
            string json = File.ReadAllText(Filename);
            return JsonConvert.DeserializeObject<Project>(json);
        }
    }

}
