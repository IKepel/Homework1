namespace StudentManagementApp.Models
{
    internal class Person
    {
        private string _name;

        private string _surname;

        private int _age;

        private string _phone;

        public string Name { get { return _name; } set { _name = value; } }

        public string Surname { get { return _surname; } set { _surname = value; } }

        public int Age { get { return _age; } set { _age = value; } }

        public string Phone { get { return _phone; } set { _phone = value; } }

        public Person(string name, string surname, int age, string phone)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
        }

        public void Print()
        {
            Console.Write($"Name: {Name}, Surname: {Surname}, Age: {Age}, Phone: {Phone}, ");
        }

    }
}
