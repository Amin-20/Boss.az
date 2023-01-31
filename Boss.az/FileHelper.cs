using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    public class FileHelper
    {
        public static void WriteJsonWorker(List<Worker> workers)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("Worker.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, workers);
                }
            }
        }

        public static void WriteJsonEmployer(List<Employer> employers)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("Employers.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, employers);
                }
            }
        }

        public static List<Worker> ReadJsonWorker()
        {
            List<Worker> workers = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("Worker.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    workers = serializer.Deserialize<List<Worker>>(jr);

                }
            }
            return workers;
        }


        public static List<Employer> ReadJsonEmployer()
        {
            List<Employer> employers = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("Employers.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    employers = serializer.Deserialize<List<Employer>>(jr);

                }
            }
            return employers;
        }



        public static void WriteExceptionToFile(Exception ex)
        {
            StackTrace st = new StackTrace(ex, true);
            StackFrame frame = st.GetFrame(0);
            string fileName = frame.GetFileName();
            int line = frame.GetFileLineNumber();
            File.AppendAllText("Errors.txt", ex.Message + "\n");

        }

    }
}
