using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace StudentManagementApp.Models
{
    internal class AcademyGroup
    {
        private List<Student> _students = new();

        private int _count;

        public void Add(Student student)
        {
            _students.Add(student);
            _count++;
        }

        public void Remove(string surname) 
        {
            _students.RemoveAll(s => s.Surname == surname);
            _count--;
        }

        public void Print()
        {
            foreach (var student in _students)
            {
                student.Print();
            }
        }

        public void Edit(string surname, string newPhone)
        {
            if (string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(newPhone))
            {
                Console.WriteLine("Surname and new phone cannot be null or empty.");
                return;
            }

            var student = _students.FirstOrDefault(s => s.Surname == surname);

            if (student is not null) 
            {
                student.Phone = newPhone;
            }
            else Console.WriteLine($"Student with surname {surname} not found."); 
        }

        public void Save(string fileName)
        {
            string jsonData = JsonConvert.SerializeObject(_students);
            File.WriteAllText(fileName, jsonData);
        }

        public void Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                string jsonData = File.ReadAllText(fileName);

                var students = JsonConvert.DeserializeObject<List<Student>>(jsonData);
                if (students != null) 
                {
                    _students = students;
                }
                else
                {
                    Console.WriteLine("Failed to deserialize JSON data from the file: " + fileName);
                }
            }
            else
            {
                Console.WriteLine("File not found: " + fileName);
            }
        }

        public void Search(string surname)
        {
            if (string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Surname cannot be null or empty.");
                return;
            }

            var student = _students.FirstOrDefault(s => s.Surname == surname);

            if (student is not null)
            {
                student.Print();
            }
            else Console.WriteLine($"Student with surname {surname} not found.");
        }
    }
}
