using Boss.az1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    public class Worker : Human
    {
        static int ID { get; set; } = 0;
        public int Id { get; set; }
        public CV Cv { get; set; } = null;
        public string Username { get; set; }
        public string Password { get; set; }
        public string SendingRequest { get; set; }
        public Worker(string username, string pass, string name, string surname, string city, string phone, int age)
            : base(name, surname, city, phone, age)
        {
            Username = username;
            Password = pass;
            Id = ++ID;
        }
        public void AddCv(CV cv)
        {
            this.Cv = cv;
        }
        public new void Show()
        {
            Console.WriteLine($"Id : {Id}");
            base.Show();
        }

        public void ShowCv()
        {
            Console.WriteLine($"Speciality : {Cv.Speciality}");
            Console.WriteLine($"School : {Cv.School}");
            Console.WriteLine($"University : {Cv.UniversityResult}");
            Cv.Skills.ForEach(s => Console.WriteLine($"Skill : {s}"));
            Cv.Companies.ForEach(c => Console.WriteLine($"Companie : {c}"));
            Console.WriteLine($"Work start end : {Cv.WorkStartEnd}");
            Cv.Language.ForEach(l => Console.WriteLine($"Language : {l}"));
            if (Cv.HonorsDiploma)
            {
                Console.WriteLine($"Honors diploma : Yes");
            }
            else
            {
                Console.WriteLine($"Honors diploma : No");
            }
            if (Cv.GitLink != null)
            {
                Console.WriteLine($"Github link : {Cv.GitLink}");
            }
            if (Cv.Linkedin != null)
            {
                Console.WriteLine($"Linkedin link : {Cv.Linkedin}");
            }
        }


    }
}
