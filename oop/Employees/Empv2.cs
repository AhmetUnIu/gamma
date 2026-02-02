using System;

namespace emp
{   
    public class Employee
    {
        private string name;
        private string position;
        private double salary;
        private int age;
        
        static int getNum()
        {
           Random random = new Random();
           int num;
           num = random.Next(18, 78);
           return num;
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public Employee(string nm, string pos, double sr)
        {
            
            name = nm;
            position = pos;
            salary = sr;
            age = getNum();
        }
    }
    
    class Program
    {   
        
        public static void Main(string[] args)
        {
            
            Employee emp1 = new Employee("Ahmet", "Student", 2345);
            Console.WriteLine("{0} {1} {2} {3}", emp1.Name, emp1.Position, emp1.Salary, emp1.Age);
        }
    }
}
