using System;
using TaskOctober.Models;

namespace TaskOctober.Service
{
	public class EmployeeService : EmployeeModels
	{
		public EmployeeModels[] GetAll()
		{
			EmployeeModels employee1 = new()
			{
				Name = "Elnur",
				Surname = "Safiyev",
				Age = 19,
				Salary = 1900
			};

            EmployeeModels employee2 = new()
            {
                Name = "Tural",
                Surname = "Abdulayev",
                Age = 29,
                Salary = 1400
            };

            EmployeeModels employee3 = new()
            {
                Name = "Togrul",
                Surname = "Babayev",
                Age = 39,
                Salary = 4000
            };

            return new EmployeeModels[] { employee1, employee2, employee3 };
        }

        public void RangeOfSalary(int a, int b)
        {
            EmployeeModels[] employees = GetAll();

            foreach(var item in employees)
            {
                if(item.Salary > a && item.Salary < b)
                {
                    Console.WriteLine($"{item.Name} {item.Surname} - {item.Salary}");
                }
            }
        }
	}
}

