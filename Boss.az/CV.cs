using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    public class CV
    {
        public string Speciality { get; set; }
        public string School { get; set; }
        public string UniversityResult { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Companies { get; set; }
        public string WorkStartEnd { get; set; }
        public List<string> Language { get; set; }
        public bool HonorsDiploma { get; set; } = false;
        public string GitLink { get; set; } = null;
        public string Linkedin { get; set; } = null;
    }
}
