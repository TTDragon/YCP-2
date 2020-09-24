using System;

namespace usr2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c, h;
            c = Convert.ToInt32(a);
            h = Convert.ToInt32(b);
            if ((c > h) | (c<h) & (c!=h))
            { Console.WriteLine(c>h);
            }

                
            else 
            
                Console.WriteLine("Равны между собой");
            
           
            
                
        }
    }
}