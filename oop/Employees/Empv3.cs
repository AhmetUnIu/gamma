using System;

namespace oop
{   
    public class Employee
    {
        public string name;
        public string position;
        public double salary;
        public int age;
        public static int counter = 0;
        
        static int getNum()
        {
           Random random = new Random();
           int num;
           num = random.Next(18, 78);
           return num;
        }
        
        
        public Employee(string nm, string pos, double sr)
        {
            
            name = nm;
            position = pos;
            salary = sr;
            age = getNum();
            counter += 1;
        }
    }
    
    class Program
    {   
        
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("Ahmet", "Student", 2345);
            Console.WriteLine("{0} {1} {2} {3}", emp1.name, emp1.position, emp1.salary, emp1.age);
            
            Console.WriteLine("We have {0} Employee in our company." ,Employee.counter);
        }
        

        
    }
}
