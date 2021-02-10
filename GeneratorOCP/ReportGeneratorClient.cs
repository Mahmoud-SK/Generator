using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator
{
	public class ReportGeneratorClient
	{
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("ZUB", 1, 18));
            db.AddEmployee(new Employee("Magnus", 2, 36));
            db.AddEmployee(new Employee("Lasse", 3, 49));

            var SalaryreportGenerator = new SalaryFirstRP();
            var NamereportGenerator = new NameFirstRP();
            var AgereportGenerator = new AgeFirstRP();
            var ReportGenerator = new ReportGenerator(db);

            ReportGenerator.CompileReport(NamereportGenerator);

            Console.WriteLine("");
            Console.WriteLine("");

            ReportGenerator.CompileReport(SalaryreportGenerator);

            Console.WriteLine("");
            Console.WriteLine("");

            ReportGenerator.CompileReport(AgereportGenerator);

            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
