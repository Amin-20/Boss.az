using Boss.az;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Boss.az1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Boss.az";
            Controller.Start();
        }
    }
}