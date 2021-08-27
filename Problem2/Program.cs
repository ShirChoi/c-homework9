using System;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            Employee employee1 = new Employee("Eshmatov", "Toshmat", EmployeePosition.Junior);
            employee1.PrintInfo();

            System.Console.WriteLine();

            Employee employee2 = new Employee("Aminov", "Khusrav", EmployeePosition.Middle);
            employee2.PrintInfo();

            System.Console.WriteLine();

            Employee employee3 = new Employee("Jeff", "Bezos", EmployeePosition.TeamLead);
            employee3.PrintInfo();
        }
    }

    public enum EmployeePosition {
        Junior,
        Middle,
        TeamLead,
    }

    class Employee {
        public string Name {get; private set;}
        public string Surname {get; private set;}
        public EmployeePosition Position {get; private set;}

        public Employee(string name, string surname, EmployeePosition position) {
            Name = name;
            Surname = surname;
            Position = position;
        }

        public void PrintInfo() {
            Console.WriteLine($"name:\t\t{Name}");            
            Console.WriteLine($"surname:\t{Surname}");   
            PrintPositionInfo();
            PrintSalaryInfo();     
        }

        private void PrintPositionInfo() {
            string position = Position switch {
                EmployeePosition.Junior => "Junior",
                EmployeePosition.Middle => "Middle",
                EmployeePosition.TeamLead => "TeamLead",
                _ => "",
            };

            Console.WriteLine($"position:\t{position}");
        }

        private void PrintSalaryInfo() {
            double salary = Position switch {
                EmployeePosition.Junior => 1000,
                EmployeePosition.Middle => 2500,
                EmployeePosition.TeamLead => 3200,
                _ => 0,
            };

            double tax = salary * (13 + 1) / 100;

            Console.WriteLine($"slary:\t\t{salary}");
            Console.WriteLine($"tax from slary:\t{tax}");

        }
    }
}
