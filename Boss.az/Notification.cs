using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    public class Notification
    {
        public int Count { get; set; } = 0;
        public string Content { get; set; }

        public void Show()
        {
            Console.WriteLine(Content);
        }
    }
}