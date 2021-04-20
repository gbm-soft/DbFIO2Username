using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFIO2Username
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fs1 = new StreamReader(args[0]);
            StreamWriter result1 = new StreamWriter(args[0] + ".usernames");

            string s = "";
            var list = new List<string> { };
            while (s != null)
            {
                s = fs1.ReadLine();
                if (s != null)
                {
                    var s1 = s.Split(' ');
                    string u = "";
                    foreach (var z in s1)
                    {
                        result1.WriteLine(z);
                        u += z;
                    };
                    result1.WriteLine(u);
                    u = "";
                    foreach (var z in s1.Reverse())
                    {
                        u += z;
                    };
                    result1.WriteLine(u);
                }
            }
            result1.Close();

        }
    }
}
