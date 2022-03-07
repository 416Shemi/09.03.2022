using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 14, 4, 16, 78, 53 };
            Console.WriteLine(Min(arry));
            Console.ReadLine();
            
        }
        static int Min(int[] arry)
        {
            int min = arry[0];
            for (int i = 0; i <arry.Length; i++)
            {
                if (arry[i] < arry[0])
                {
                    min = arry[i];
                }
            }
            return min;
        }
        
        
    }
}
