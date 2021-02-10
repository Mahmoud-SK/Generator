using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator
{
	public interface ReportPrinter
	{
		public void PrintReport(List<Employee> Employees);
	}
}
