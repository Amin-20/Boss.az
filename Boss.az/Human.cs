using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    public abstract class Human
    {
        protected Human(string name, string surname, string city, string phone, int age)
        {
            Name = name;
            Surname = surname;
            City = city;
            Phone = phone;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public void Show()
        {
            Console.WriteLine($"Name : {Name}\nSurname : {Surname}\nAge : {Age}\nCity : {City}\nPhone : {Phone}");
        }
    }
}
