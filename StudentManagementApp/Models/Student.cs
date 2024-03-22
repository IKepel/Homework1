namespace StudentManagementApp.Models
{
    internal class Student : Person
    {
        private double _average;

        private string _numberOfGroup;

        public double Average { get { return _average; } set { _average = value; } }

        public string NumberOfGroup { get { return _numberOfGroup; } set { _numberOfGroup = value; } }

        public Student(string name, string surname, int age, string phone, double average, string numberOfGroup) : base(name, surname, age, phone)
        {
            Average = average;
            NumberOfGroup = numberOfGroup;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Average: {Average}, Group: {NumberOfGroup}");
        }
    }
}
