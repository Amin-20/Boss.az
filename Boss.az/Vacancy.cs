using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
     public class Vacancy
    {
        public Vacancy(string speciality, double salary, int practiseYear)
        {
            Id = ++ID;
            Speciality = speciality;
            Salary = salary;
            PractiseYear = practiseYear;
        }

        public Vacancy()
        {
                
        }
        public string Speciality { get; set; }
        public double Salary { get; set; }
        public int PractiseYear { get; set; }
        public int Id { get; set; }
        static public int ID { get; set; } = 0;


        public void ShowVacancy()
        {
            Console.WriteLine($"\nID : {Id}");
            Console.WriteLine($"Speciality : {Speciality}");
            Console.WriteLine($"Salary : {Salary} $");
            Console.WriteLine($"Experience year : {PractiseYear}\n");
        }
    }
}
