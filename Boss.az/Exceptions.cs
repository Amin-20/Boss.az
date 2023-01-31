using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    public class OzumunException : Exception
    {
        public OzumunException(string messages, DateTime date, int line)
        {
            Messages = messages;
            Date = date;
            Line = line;

        }
        public string Messages { get; set; }
        public DateTime Date { get; set; }
        public int Line { get; set; }


        public override string Message
        {
            get
            {
                return $@"====================================================================================
Error : {Message}
Date : {Date.ToLongDateString()}, {Date.ToLongTimeString()}
Line : {Line}
";
            }
        }
    }
}
