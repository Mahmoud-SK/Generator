using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator
{
	class SalaryFirstRG : IReportGenerator
	{

		private readonly EmployeeDB _employeeDb;

		public SalaryFirstRG(EmployeeDB employeeDb)
		{
			if (employeeDb == null) throw new ArgumentNullException("employeeDb");
			_employeeDb = employeeDb;
		}

		public void CompileReport()
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }

            // All employees collected - let's output them
            Console.WriteLine("Salary-first report");
            foreach (var e in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("------------------");
            }
        }
    }
}
