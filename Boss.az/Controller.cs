using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

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

        static public void CreatCv(Worker worker, List<Worker> workers, int index)
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
            workers[index].AddCv(cV);
            FileHelper.WriteJsonWorker(workers);
        }

        static public void Worker(Worker worker, List<Employer> employers, int index1, List<Worker> workers)
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
                    string search = String.Empty;
                    int result;
                    while (true)
                    {
                        var letter = Console.ReadKey();
                        if (letter.Key == ConsoleKey.D1 || letter.Key == ConsoleKey.D2 ||
                            letter.Key == ConsoleKey.D3 || letter.Key == ConsoleKey.D4 ||
                            letter.Key == ConsoleKey.D5 || letter.Key == ConsoleKey.D6 ||
                            letter.Key == ConsoleKey.D7 || letter.Key == ConsoleKey.D8 ||
                            letter.Key == ConsoleKey.D9)
                        {
                            var result1 = letter.Key.ToString();
                            result1 = result1.Replace('D', ' ');
                            result = int.Parse(result1);
                            break;
                        }
                        Console.Clear();
                        search += letter.KeyChar;
                        search = search.ToLower();
                        if (letter.Key == ConsoleKey.Backspace)
                        {
                            search = "";
                        }
                        Console.WriteLine(search);
                        var selectedVacancy = from e in employers
                                              from v in e.Vacancies
                                              where v.Speciality.ToLower().Contains(search)
                                              select v;
                        foreach (var vacancy in selectedVacancy)
                        {
                            Console.WriteLine($"{vacancy.Id} - {vacancy.Speciality}");
                        }
                        Console.WriteLine("\n\n");
                    }
                    Console.Clear();
                    var vacancy1 = from e in employers
                                   from v in e.Vacancies
                                   where v.Id == result
                                   select v;
                    Vacancy vacancyResult = new Vacancy();
                    foreach (var vacancy in vacancy1)
                    {
                        vacancyResult = vacancy;
                    }
                    vacancyResult.ShowVacancy();
                    Console.WriteLine("[1] Apply");
                    Console.WriteLine("[2] Back");
                    Console.Write("Select : ");
                    var select1 = Console.ReadLine();
                    if (select1 == "1")
                    {
                        for (int i = 0; i < employers.Count; i++)
                        {
                            for (int k = 0; k < employers[i].Vacancies.Count; k++)
                            {
                                if (result == employers[i].Vacancies[k].Id)
                                {
                                    employers[i].Notifications.Count += 1;
                                    employers[i].Applicant.Add(worker);
                                    employers[i].ApplicantVacancy.Add(vacancyResult);
                                }
                            }
                        }
                        Notification notification = new Notification();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Request sent successfully");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                    else if (select == "2") { }
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
                            workers[index1].Cv.Speciality = result;
                        }
                        else if (select1 == "2")
                        {
                            Console.Write("Enter new school : ");
                            var result = Console.ReadLine();
                            worker.Cv.School = result;
                            workers[index1].Cv.School = result;
                        }
                        else if (select1 == "3")
                        {
                            Console.Write("Enter new university : ");
                            var result = Console.ReadLine();
                            worker.Cv.UniversityResult = result;
                            workers[index1].Cv.UniversityResult = result;
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
                                workers[index1].Cv.Skills.Add(skill);
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
                                        workers[index1].Cv.Skills.Add(skill1);
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
                                            workers[index1].Cv.Skills[index] = result;
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
                                workers[index1].Cv.Companies.Add(companies);
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
                                        workers[index1].Cv.Companies.Add(companies1);
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
                                            worker.Cv.Companies[index] = result;
                                            workers[index1].Cv.Companies[index] = result;
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
                                workers[index1].Cv.Language.Add(language);
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
                                        workers[index1].Cv.Language.Add(language1);
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
                                            worker.Cv.Language[index] = result;
                                            workers[index1].Cv.Language[index] = result;
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
                            Worker(worker, employers, index1, workers);
                        }
                        FileHelper.WriteJsonWorker(workers);
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
                        CreatCv(worker, workers, index1);
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
                    if (worker.Applicant.Count != 0)
                    {
                        worker.Applicant.ForEach(e => e.Show());
                        worker.ApplicantVacancy.ForEach(v => v.ShowVacancy());
                        Console.WriteLine(worker.Notification.Content);
                        Console.ReadKey();
                        worker.Applicant.Clear();
                        worker.ApplicantVacancy.Clear();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("There is no information.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
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

        static public void Employer(Employer employer, List<Employer> employers)
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
                    Console.Write("Enter experience year : ");
                    var experienceYear = int.Parse(Console.ReadLine());
                    Vacancy v1 = new Vacancy(speciality, salary, experienceYear);
                    employer.Vacancies.Add(v1);
                    FileHelper.WriteJsonEmployer(employers);
                }
                else if (select == "3")
                {
                    employer.Vacancies.ForEach(v => v.ShowVacancy());
                    Console.Write("Enter vacancy id : ");
                    var id = int.Parse(Console.ReadLine());
                    var vacancy = employer.GetVacancyById(id);
                    if (vacancy != null)
                    {
                        Console.WriteLine("[1] Speciality");
                        Console.WriteLine("[2] Salary");
                        Console.WriteLine("[3] Experience year");
                        Console.Write("Select : ");
                        var choise = Console.ReadLine();
                        if (choise == "1")
                        {
                            Console.Write("Enter new speciality : ");
                            var speciality = Console.ReadLine();
                            vacancy.Speciality = speciality;

                        }
                        else if (choise == "2")
                        {
                            Console.Write("Enetr new salary : ");
                            var salary = double.Parse(Console.ReadLine());
                            vacancy.Salary = salary;

                        }
                        else if (choise == "3")
                        {
                            Console.Write("Enter new experience year : ");
                            var experienceYear = int.Parse(Console.ReadLine());
                            vacancy.PractiseYear = experienceYear;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Invalid select !");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        FileHelper.WriteJsonEmployer(employers);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Vacancy not found");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                else if (select == "4")
                {
                    if (employer.Applicant.Count != 0)
                    {
                        Vacancy vacancy = new Vacancy();
                        var result1 = employer.ApplicantVacancy.Select(v => v);
                        foreach (var v in result1)
                        {
                            vacancy = v;
                        }
                        employer.Applicant.ForEach(w => w.Show());
                        employer.Applicant.ForEach(w => w.ShowCv());
                        employer.ApplicantVacancy.ForEach(v => v.ShowVacancy());
                        Console.WriteLine("[1] Accept");
                        Console.WriteLine("[2] Reject");
                        Console.Write("Select : ");
                        var choise = Console.ReadLine();
                        if (choise == "1")
                        {
                            Worker worker = null;
                            var result = employer.Applicant.Select(w => w);
                            foreach (var w in result)
                            {
                                worker = w;
                            }
                            worker.Applicant.Add(employer);
                            worker.ApplicantVacancy.Add(vacancy);
                            worker.Notification.Content = "Was accepted";
                            Console.ForegroundColor= ConsoleColor.Green;
                            Console.WriteLine("Message sended");
                            Console.ResetColor();
                            Console.ReadKey();
                            employer.Applicant.Clear();
                            employer.ApplicantVacancy.Clear();
                            employer.Vacancies.Remove(vacancy);
                            FileHelper.WriteJsonEmployer(employers);
                        }
                        else if (choise == "2")
                        {
                            Worker worker = null;
                            var result = employer.Applicant.Select(w => w);
                            foreach (var w in result)
                            {
                                worker = w;
                            }
                            worker.Applicant.Add(employer);
                            worker.ApplicantVacancy.Add(vacancy);
                            worker.Notification.Content = "Was rejected";
                            Console.ReadKey();
                            employer.Applicant.Clear();
                            employer.ApplicantVacancy.Clear();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("There is no information.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }

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
            //FileHelper.WriteJsonWorker(workers);
            workers = FileHelper.ReadJsonWorker();

            List<Employer> employers = new List<Employer>();
            Employer em1 = new Employer("raf1", "raf1", "Rafiq", "Agayev", "Baku", "+994555555555", 45);
            Employer em2 = new Employer("R", "A", "Babi", "Baba", "Baku", "+994555555555", 45);
            em1.Vacancies.Add(new Vacancy("Middle C# Developer", 3000, 3));
            em1.Vacancies.Add(new Vacancy("Junior Java Developer", 1200, 1));
            employers.Add(em1);
            employers.Add(em2);
            //FileHelper.WriteJsonEmployer(employers);
            employers = FileHelper.ReadJsonEmployer();
            while (true)
            {
                Console.Clear();
                SiteName();
                //Worker(workers[0], employers);
                Console.WriteLine("\n\t\t\t\t\t\t[1] Login ");
                Console.WriteLine("\n\t\t\t\t\t\t[2] SignUp ");
                Console.Write("\n\t\t\t\t\t\tSelect : ");
                string choise = Console.ReadLine();
                Worker worker = null;
                int wIndex = 0;
                Employer employer = null;
                int eIndex = 0;
                if (choise == "1")
                {
                    Console.Write("\n\t\t\t\t\t\tEnter username : ");
                    string username = Console.ReadLine();
                    Console.Write("\n\t\t\t\t\t\tEnter password : ");
                    string password = Console.ReadLine();
                    for (int i = 0; i < workers.Count; i++)
                    {
                        if (username == workers[i].Username && password == workers[i].Password)
                        {
                            worker = workers[i];
                            wIndex = i;
                        }
                    }
                    for (int i = 0; i < employers.Count; i++)
                    {
                        if (username == employers[i].Username && password == employers[i].Password)
                        {
                            employer = employers[i];
                            eIndex = i;
                        }
                    }
                    if (worker != null)
                    {
                        Worker(worker, employers, wIndex, workers);
                    }
                    else if (employer != null)
                    {
                        Employer(employer, employers);
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
                            CreatCv(worker1, workers, wIndex);
                        }
                        workers.Add(worker1);
                        FileHelper.WriteJsonWorker(workers);
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
                        Employer employer1 = new Employer(username, password, name, surname, city, phone, age);
                        employers.Add(employer1);
                        FileHelper.WriteJsonEmployer(employers);
                    }
                    Console.WriteLine("User added succesfully ! ");
                    Console.ReadKey();
                }
            }
        }
    }
}
