using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideConfuseExample
{
    public class B:A
    {
        public override void Display()
        {
            Console.WriteLine("B");
        }
    }
}
