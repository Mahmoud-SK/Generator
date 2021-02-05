using System;

namespace ReportGenerator
{
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("ZUB ZUB", 1000000000));
            db.AddEmployee(new Employee("Magnus", 2000));
            db.AddEmployee(new Employee("Lasse", 1000));

            var SalaryreportGenerator = new SalaryFirstRG(db);
            var NamereportGenerator = new NameFirstRG(db);

            // Create a Name-first salary report
            NamereportGenerator.CompileReport();

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a salary-first report
            SalaryreportGenerator.CompileReport();
        }
    }
}