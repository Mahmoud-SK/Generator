using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator
{
	public class SalaryFirstRP : ReportPrinter
	{
		public void PrintReport(List<Employee> Employees)
		{
			Console.WriteLine("Salary-first report");
			foreach (var e in Employees)
			{
				Console.WriteLine("------------------");
				Console.WriteLine("Salary: {0}", e.Salary);
				Console.WriteLine("Name: {0}", e.Name);
				Console.WriteLine("Age: {0}", e.Age);
				Console.WriteLine("------------------");
			}

		}
	}
}
