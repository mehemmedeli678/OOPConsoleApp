namespace OOPConsoleApp.Inheritance
{
    internal class Employee
    {
        public Employee(int hour,int money)
        {
            this.Salary = hour * money;
        }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; private set; }
    }
}
