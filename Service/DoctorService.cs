using System;
using TaskOctober.Models;

namespace TaskOctober.Service
{
	public class DoctorService
	{
        public DoctorModels[] GetAll()
        {
            DoctorModels doctor1 = new()
            {
                Name = "Elnur",
                Surname = "Safiyev",
                Address = "Yasamal",
                Birthday = new(2004,07,08)
            };

            DoctorModels doctor2 = new()
            {
                Name = "Tural",
                Surname = "Abdulayev",
                Address = "Nesimi",
                Birthday = new(2001,12,12)
            };

            DoctorModels doctor3 = new()
            {
                Name = "Togrul",
                Surname = "Babayev",
                Address = "Sahil",
                Birthday = new(1996,03,05)
            };

            return new DoctorModels[] {doctor1,doctor2,doctor3 };
        }

        public void BetweenBirthadys(DateTime date1, DateTime date2)
        {
            DoctorModels[] doctors = GetAll();

            foreach(var item in doctors)
            {
                if(item.Birthday > date1 && item.Birthday < date2)
                {
                    Console.WriteLine($"{item.Name} {item.Surname} / {item.Birthday}");
                }
            }
        }
    }
}

