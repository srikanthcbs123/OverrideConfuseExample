using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideConfuseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Check The different combinations
            A obj = new B();

            obj.Display();

            B obj1=new B();
            obj1.Display();

            A obj5=new A();
            obj5.Display();

            // B obj3 = new A();it will throw the error

            //---Here one more interview question
            var a = 1;
            var b = '2';//here  var will store char 2 of  asciii value ..because if you assign direct char value to var it will read the ascii value of that single quote .
            var c = a + b;//what will be the output of c.
            Console.WriteLine(c);//51

            var a11 = 1;
            var b11 = "2";//in this scenario if you assign the data in double quotes it think it is a string it wont change the anything of string.
            var c11 = a11 + b11;//what will be the output of c.
            Console.WriteLine(c11);//12
            //same thing we will repeat with narmal datatypes.
            int a1 = 1;
            string a2 = "2";
            var result = a1 + a2;
            Console.WriteLine(result);


            Console.ReadKey();
           

        }
    }
}
