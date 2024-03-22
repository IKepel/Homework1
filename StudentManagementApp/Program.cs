using StudentManagementApp.Models;

namespace StudentManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var group = new AcademyGroup();
            group.Add(new Student("John", "Doe", 20, "123456789", 85.5, "E-84"));
            group.Add(new Student("John", "Smith", 21, "987654321", 88.2, "E-84"));
            group.Add(new Student("Alex", "Hard", 21, "0989202259", 100, "E-84"));

            Console.WriteLine("Initial group:");
            group.Print();

            group.Remove("Doe");

            Console.WriteLine("\nAfter removing Doe:");
            group.Print();

            Console.WriteLine("\nAfter editing Smith's phone:");
            group.Edit("Smith", "555-5555");
            group.Print();

            group.Save("students.json");

            var newGroup = new AcademyGroup();
            newGroup.Load("students.json");

            Console.WriteLine("\nLoaded group:");
            newGroup.Print();

            Console.WriteLine("\nSearch for Smith:");
            group.Search("Smith");
        }
    }
}
