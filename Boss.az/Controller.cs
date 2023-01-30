﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    class Controller
    {
        static void SiteName()
        {
            Console.WriteLine(); Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t   ▀█████████▄   ▄██████▄     ▄████████    ▄████████       ▄████████  ▄███████▄    ");
            Console.WriteLine("\t\t     ███    ███ ███    ███   ███    ███   ███    ███      ███    ███ ██▀     ▄██   ");
            Console.WriteLine("\t\t     ███    ███ ███    ███   ███    █▀    ███    █▀       ███    ███       ▄███▀   ");
            Console.WriteLine("\t\t    ▄███▄▄▄██▀  ███    ███   ███          ███             ███    ███  ▀█▀▄███▀▄▄   ");
            Console.WriteLine("\t\t   ▀▀███▀▀▀██▄  ███    ███ ▀███████████ ▀███████████    ▀███████████   ▄███▀   ▀   ");
            Console.WriteLine("\t\t     ███    ██▄ ███    ███          ███          ███      ███    ███ ▄███▀         ");
            Console.WriteLine("\t\t     ███    ███ ███    ███    ▄█    ███    ▄█    ███      ███    ███ ███▄     ▄█   ");
            Console.WriteLine("\t\t   ▄█████████▀   ▀██████▀   ▄████████▀   ▄████████▀  ███  ███    █▀   ▀████████▀   ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }

        static public void CreatCv(Worker worker)
        {
            Console.Write("Enter speciality : ");
            var speciality = Console.ReadLine();
            Console.Write("Enter school : ");
            var school = Console.ReadLine();
            Console.Write("Enter university : ");
            var uni = Console.ReadLine();
            Console.Write("Enter skill : ");
            var skill = Console.ReadLine();
            var skills = new List<string> { };
            skills.Add(skill);
            Console.Write("Want to improve your skills? ");
            while (true)
            {
                Console.Write("Yes / No : ");
                var result = Console.ReadLine();
                if (result.ToLower() == "yes")
                {
                    Console.Write("Enter skill : ");
                    var skill1 = Console.ReadLine();
                    skills.Add(skill1);

                }
                else if (result.ToLower() == "no")
                {
                    break;
                }
            }
            Console.Write("Enter companies : ");
            var companies = Console.ReadLine();
            var companiess = new List<string> { };
            companiess.Add(companies);
            Console.Write("Want to improve your companies? ");
            while (true)
            {
                Console.Write("Yes / No : ");
                var result = Console.ReadLine();
                if (result.ToLower() == "yes")
                {
                    Console.Write("Enter companies : ");
                    var companies1 = Console.ReadLine();
                    companiess.Add(companies1);

                }
                else if (result.ToLower() == "no")
                {
                    break;
                }
            }
            Console.Write("Enter language : ");
            var language = Console.ReadLine();
            var languages = new List<string> { };
            languages.Add(language);
            Console.Write("Want to improve your companies? ");
            while (true)
            {
                Console.Write("Yes / No : ");
                var result = Console.ReadLine();
                if (result.ToLower() == "yes")
                {
                    Console.Write("Enter companies : ");
                    var language1 = Console.ReadLine();
                    languages.Add(language1);

                }
                else if (result.ToLower() == "no")
                {
                    break;
                }
            }
            Console.Write("Enter work start date : ");
            var start = Console.ReadLine();
            Console.Write("Enter work end date : ");
            var end = Console.ReadLine();
            Console.Write("Honors Diploma (Yes / No ) : ");
            var result1 = Console.ReadLine();
            bool HonorsDiploma = false;
            if (result1.ToLower() == "yes")
            {
                HonorsDiploma = true;
            }
            Console.Write("Gitlink (Yes / No ) : ");
            var result3 = Console.ReadLine();
            string gitlink = null;
            if (result3.ToLower() == "yes")
            {
                gitlink = Console.ReadLine();
            }
            Console.Write("Linkedin (Yes / No ) : ");
            var result2 = Console.ReadLine();
            string linkedin = null;
            if (result2.ToLower() == "yes")
            {
                linkedin = Console.ReadLine();
            }
            CV cV = new CV()
            {
                Speciality = speciality,
                School = school,
                UniversityResult = uni,
                Skills = skills,
                Companies = companiess,
                WorkStartEnd = $"{start} || {end}",
                Language = languages,
                HonorsDiploma = HonorsDiploma,
                GitLink = gitlink,
                Linkedin = linkedin
            };
            worker.AddCv(cV);
        }

        static public void Worker(Worker worker, List<Employer> employers)
        {
            string a = "\n\t\t\t\t\t\t";
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{a}Welcome {worker.Name} {worker.Surname}");
                Console.WriteLine();
                Console.WriteLine("[1] Show cv");
                Console.WriteLine("[2] Search vacancy");
                Console.WriteLine("[3] Update cv");
                Console.WriteLine("[4] Creat cv");
                Console.WriteLine("[5] Notification");
                Console.WriteLine("[6] Sign Out");
                Console.Write("Select : ");
                string select = Console.ReadLine();
                if (select == "1")
                {
                    if (worker.Cv != null)
                    {
                        Console.Clear();
                        Console.WriteLine("Your CV");
                        worker.ShowCv();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("You have no CV. Please create your Cv!");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "2")
                {
                    employers.ForEach(e => e.Vacancies.ForEach(v => v.ShowVacancy()));
                    Console.ReadKey();
                }
                else if (select == "3")
                {
                    if (worker.Cv != null)
                    {
                        Console.Clear();
                        Console.WriteLine("Your CV");
                        worker.ShowCv();
                        Console.WriteLine("[1] Speciality");
                        Console.WriteLine("[2] School");
                        Console.WriteLine("[3] UniversityResult");
                        Console.WriteLine("[4] Skills");
                        Console.WriteLine("[5] Companies ");
                        Console.WriteLine("[6] Language");
                        Console.WriteLine("[7] HonorsDiploma");
                        Console.WriteLine("[8] GitLink");
                        Console.WriteLine("[9] Linkedin");
                        Console.WriteLine("[10] Back");
                        Console.Write("Select : ");
                        var select1 = Console.ReadLine();
                        if (select1 == "1")
                        {
                            Console.Write("Enter new speciality : ");
                            var result = Console.ReadLine();
                            worker.Cv.Speciality = result;
                        }
                        else if (select1 == "2")
                        {
                            Console.Write("Enter new school : ");
                            var result = Console.ReadLine();
                            worker.Cv.School = result;
                        }
                        else if (select1 == "3")
                        {
                            Console.Write("Enter new university : ");
                            var result = Console.ReadLine();
                            worker.Cv.UniversityResult = result;
                        }
                        else if (select1 == "4")
                        {
                            Console.Write("Add or uptade? (1/2) : ");
                            var choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Console.Write("Enter skill : ");
                                var skill = Console.ReadLine();
                                worker.Cv.Skills.Add(skill);
                                Console.Write("Want to add a new skill?");
                                while (true)
                                {
                                    Console.Write("Yes / No : ");
                                    var result = Console.ReadLine();
                                    if (result.ToLower() == "yes")
                                    {
                                        Console.Write("Enter skill : ");
                                        var skill1 = Console.ReadLine();
                                        worker.Cv.Skills.Add(skill1);
                                    }
                                    else if (result.ToLower() == "no")
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (choise == "2")
                            {
                                bool flag = true;
                                while (flag)
                                {
                                    Console.Clear();
                                    worker.Cv.Skills.ForEach(s => Console.WriteLine($"Skill : {s}"));
                                    Console.Write("Enter skill name : ");
                                    var skill = Console.ReadLine();
                                    foreach (var skill1 in worker.Cv.Skills)
                                    {
                                        if (skill == skill1)
                                        {
                                            Console.Write("Enter new skill name : ");
                                            var result = Console.ReadLine();
                                            var index = worker.Cv.Skills.IndexOf(skill1);
                                            worker.Cv.Skills[index] = result;
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("Succesfully ! ");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Skill not found!");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }
                        else if (select1 == "5")
                        {
                            Console.Write("Add or uptade? (1/2) : ");
                            var choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Console.Write("Enter companies : ");
                                var companies = Console.ReadLine();
                                worker.Cv.Companies.Add(companies);
                                Console.Write("Want to add a new companies?");
                                while (true)
                                {
                                    Console.Write("Yes / No : ");
                                    var result = Console.ReadLine();
                                    if (result.ToLower() == "yes")
                                    {
                                        Console.Write("Enter companies : ");
                                        var companies1 = Console.ReadLine();
                                        worker.Cv.Companies.Add(companies1);
                                    }
                                    else if (result.ToLower() == "no")
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (choise == "2")
                            {
                                bool flag = true;
                                while (flag)
                                {
                                    Console.Clear();
                                    worker.Cv.Companies.ForEach(s => Console.WriteLine($"Companies : {s}"));
                                    Console.Write("Enter companies name : ");
                                    var companies = Console.ReadLine();
                                    foreach (var companies1 in worker.Cv.Companies)
                                    {
                                        if (companies == companies1)
                                        {
                                            Console.Write("Enter new companies name : ");
                                            var result = Console.ReadLine();
                                            var index = worker.Cv.Companies.IndexOf(companies1);
                                            worker.Cv.Skills[index] = result;
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("Succesfully ! ");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Companies not found!");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }
                        else if (select1 == "6")
                        {
                            Console.Write("Add or uptade? (1/2) : ");
                            var choise = Console.ReadLine();
                            if (choise == "1")
                            {
                                Console.Write("Enter language : ");
                                var language = Console.ReadLine();
                                worker.Cv.Language.Add(language);
                                Console.Write("Want to add a new language?");
                                while (true)
                                {
                                    Console.Write("Yes / No : ");
                                    var result = Console.ReadLine();
                                    if (result.ToLower() == "yes")
                                    {
                                        Console.Write("Enter language : ");
                                        var language1 = Console.ReadLine();
                                        worker.Cv.Language.Add(language1);
                                    }
                                    else if (result.ToLower() == "no")
                                    {
                                        break;
                                    }
                                }
                            }
                            else if (choise == "2")
                            {
                                bool flag = true;
                                while (flag)
                                {
                                    Console.Clear();
                                    worker.Cv.Language.ForEach(s => Console.WriteLine($"Language : {s}"));
                                    Console.Write("Enter language name : ");
                                    var language = Console.ReadLine();
                                    foreach (var language1 in worker.Cv.Language)
                                    {
                                        if (language == language1)
                                        {
                                            Console.Write("Enter new language name : ");
                                            var result = Console.ReadLine();
                                            var index = worker.Cv.Language.IndexOf(language1);
                                            worker.Cv.Skills[index] = result;
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("Succesfully ! ");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Language not found!");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }
                        else if (select1 == "7")
                        {
                            if (worker.Cv.HonorsDiploma == false)
                            {
                                Console.Write("Add an honors diploma? (y/n) : ");
                                var result = Console.ReadLine();
                                if (result.ToLower() == "y")
                                {
                                    worker.Cv.HonorsDiploma = true;
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("Succesfully ! ");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                                else if (result.ToLower() == "n") { }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("You have a diploma of distinction");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                        }
                        else if (select1 == "8")
                        {
                            if (worker.Cv.GitLink == null)
                            {
                                Console.Write("Enter gitlink : ");
                                var result = Console.ReadLine();
                                worker.Cv.GitLink = result;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("You have a github link");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                        }
                        else if (select1 == "9")
                        {
                            if (worker.Cv.Linkedin == null)
                            {
                                Console.Write("Enter linkedin link : ");
                                var result = Console.ReadLine();
                                worker.Cv.GitLink = result;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("You have a linkedin");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                        }
                        else if (select1 == "10")
                        {
                            Worker(worker, employers);
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("You have no CV. Please create your Cv !");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "4")
                {
                    if (worker.Cv == null)
                    {
                        CreatCv(worker);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("You already have a CV !");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "5")
                {

                }
                else if (select == "6")
                {
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid select !");
                    Console.ResetColor();
                    Console.ReadKey();
                }

            }
        }

        static public void Employer(Employer employer)
        {
            string a = "\n\t\t\t\t\t\t";
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{a}Welcome {employer.Name} {employer.Surname}");
                Console.WriteLine();
                Console.WriteLine("[1] Show vacancy");
                Console.WriteLine("[2] Add vacancy");
                Console.WriteLine("[3] Update vacancy");
                Console.WriteLine("[4] Notification");
                Console.WriteLine("[5] Sign Out");
                Console.Write("Select : ");
                string select = Console.ReadLine();
                if (select == "1")
                {
                    if (employer.Vacancies.Count != 0)
                    {
                        employer.Vacancies.ForEach(v => v.ShowVacancy());
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You have not vacancy !!");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "2")
                {
                    Console.Write("Enter speciality : ");
                    var speciality = Console.ReadLine();
                    Console.Write("Enter salary : ");
                    var salary = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter experience year : ");
                    var experienceYear = int.Parse(Console.ReadLine());
                    Vacancy v1 = new Vacancy(speciality, salary, experienceYear);
                    employer.Vacancies.Add(v1);
                }
                else if (select == "3")
                {
                    employer.Vacancies.ForEach(v => v.ShowVacancy());
                    Console.WriteLine("Enter vacancy id : ");
                    var id = int.Parse(Console.ReadLine());
                    var employer1 = employer.GetVacancyById(id);
                    if (employer1 != null)
                    {
                        Console.WriteLine("[1] Speciality");
                        Console.WriteLine("[2] Salary");
                        Console.WriteLine("[3] Experience year");
                        Console.Write("Select : ");
                        var choise = Console.ReadLine();
                        if (choise == "1")
                        {
                            Console.WriteLine("Enter new speciality : ");
                            var speciality=Console.ReadLine();

                        }

                    }
                    else
                    {
                        Console.WriteLine("Vacancy not found");
                    }
                }
                else if (select == "4")
                {

                }
                else if (select == "5")
                {
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid sleect !");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }

        static public void Start()
        {
            List<Worker> workers = new List<Worker>();
            Worker w1 = new Worker("Mahdi123", "mahdi12", "Mehdi", "Esedov", "Baku", "+994553264323", 25);
            Worker w2 = new Worker("Nargiz123", "nargiz12", "Nergiz", "Mehdiyev", "Baku", "+994772734875", 20);
            Worker w3 = new Worker("John123", "john12", "John", "Johnlu", "Germany", "+494326432367", 27);
            w1.AddCv(new CV()
            {
                Speciality = "C# Developer",
                School = "53",
                UniversityResult = "ADNSU",
                Skills = new List<string> { "Java script", "HTML" },
                Companies = new List<string> { "Chinar Plaza", "Azersun MMC" },
                WorkStartEnd = "10/11/2019 || 10/12/2022",
                Language = new List<string> { "English", "Germany" },
                HonorsDiploma = false,
                GitLink = "github.com/Mahdi123"
            });
            workers.Add(w1);
            workers.Add(w2);
            workers.Add(w3);

            List<Employer> employers = new List<Employer>();
            Employer em1 = new Employer("raf1", "raf1", "Rafiq", "Agayev", "Baku", "+994555555555", 45);
            Employer em2 = new Employer("R", "A", "Babi", "Baba", "Baku", "+994555555555", 45);
            em1.Vacancies.Add(new Vacancy("Middle C# Developer", 3000, 3));
            em1.Vacancies.Add(new Vacancy("Junior Java Developer", 1200, 1));
            employers.Add(em1);
            employers.Add(em2);

            while (true)
            {
                Console.Clear();
                SiteName();
                Console.WriteLine("\n\t\t\t\t\t\t[1] Login ");
                Console.WriteLine("\n\t\t\t\t\t\t[2] SignUp ");
                Console.Write("\n\t\t\t\t\t\tSelect : ");
                string choise = Console.ReadLine();
                if (choise == "1")
                {
                    Console.Write("\n\t\t\t\t\t\tEnter username : ");
                    string username = Console.ReadLine();
                    Console.Write("\n\t\t\t\t\t\tEnter password : ");
                    string password = Console.ReadLine();
                    Worker worker = null;
                    Employer employer = null;
                    for (int i = 0; i < workers.Count; i++)
                    {
                        if (username == workers[i].Username && password == workers[i].Password)
                        {
                            worker = workers[i];
                        }
                    }
                    for (int i = 0; i < employers.Count; i++)
                    {
                        if (username == employers[i].Username && password == employers[i].Password)
                        {
                            employer = employers[i];
                        }
                    }
                    if (worker != null)
                    {
                        Worker(worker, employers);
                    }
                    else if (employer != null)
                    {
                        Employer(employer);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\tUser not found. Please try again !");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (choise == "2")
                {
                    Console.WriteLine("\n\t\t\t\t\t\t[1] Worker");
                    Console.WriteLine("\n\t\t\t\t\t\t[2] Employer");
                    var select1 = Console.ReadLine();
                    if (select1 == "1")
                    {
                        Console.Write("Enter name : ");
                        var name = Console.ReadLine();
                        Console.Write("Enter surname : ");
                        var surname = Console.ReadLine();
                        Console.Write("Age : ");
                        var age = int.Parse(Console.ReadLine());
                        Console.Write("Enter city : ");
                        var city = Console.ReadLine();
                        Console.Write("Enter phone number : ");
                        var phone = Console.ReadLine();
                        Console.Write("Enter username : ");
                        var username = Console.ReadLine();
                        Console.Write("Creat password : ");
                        var password = Console.ReadLine();
                        Worker worker1 = new Worker(username, password, name, surname, city, phone, age);
                        Console.WriteLine("Do you want add CV ?");
                        Console.WriteLine("[1] Yes");
                        Console.WriteLine("[2] No");
                        var choise1 = Console.ReadLine();
                        if (choise1 == "1")
                        {
                            CreatCv(worker1);
                        }
                        workers.Add(worker1);
                    }
                    else if (select1 == "2")
                    {
                        Console.Write("Enter name : ");
                        var name = Console.ReadLine();
                        Console.Write("Enter surname : ");
                        var surname = Console.ReadLine();
                        Console.Write("Age : ");
                        var age = int.Parse(Console.ReadLine());
                        Console.Write("Enter city : ");
                        var city = Console.ReadLine();
                        Console.Write("Enter phone number : ");
                        var phone = Console.ReadLine();
                        Console.Write("Enter username : ");
                        var username = Console.ReadLine();
                        Console.Write("Creat password : ");
                        var password = Console.ReadLine();
                        Employer employer = new Employer(username, password, name, surname, city, phone, age);
                        employers.Add(employer);
                    }
                    Console.WriteLine("User added succesfully ! ");
                    Console.ReadKey();
                }
            }
        }
    }
}