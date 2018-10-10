using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanted_methods_
{
    class Program
    {
        static string GetLastHalf(string text)
        {
            int length = text.Length;
            text = text.Substring(length / 2);
            text = text.Replace(" ", string.Empty);
            return text;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }
    }
}
