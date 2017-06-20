using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D;

namespace C
{
    public class ClassC
    {
        public void Run()
        {
            Console.WriteLine("  C class");
            Console.WriteLine("  It also use:");
            new ClassD().Run();
        }
    }
}
