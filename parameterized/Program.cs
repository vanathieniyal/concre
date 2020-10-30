using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized
{
   
        class paraconstrctor
        {
            public int a, b;
            public paraconstrctor(int a, int b)  // decalaring Paremetrized Constructor with ing x,y parameter  
            {
                this.a = a;
                this.b = b;
            }
        public paraconstrctor()
        {
            this.a = 20;
            this.b = 30;

        }
        }
        class MainClass
        {
            static void Main()
            {
                paraconstrctor v = new paraconstrctor(); 
            // Creating object of Parameterized Constructor and ing values     
                Console.WriteLine("value of a=" + v.a);
                Console.WriteLine("value of b=" + v.b);
                Console.Read();
            }
        }
    }
