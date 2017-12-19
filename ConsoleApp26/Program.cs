using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            test.PropertyChanged += EventReader;
            test.Number = 8;

            TestClass test1 = new TestClass();
            test.PropertyChanged += EventReader;
            test.Number = 10;

            Console.ReadLine();
        }

        static void EventReader(object sender,PropertyEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
