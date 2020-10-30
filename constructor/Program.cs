using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class addition
    {
        int a, b;
        //public addition()   //default contructor  
        //{
        //    a = 100;
        //    b = 175;
        //}

        public static void Main()
        {
            addition obj = new addition(); //an object is created , constructor is called  
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.Read();
        }
    }

}
