using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calc calc1 = new Calc();
            Console.WriteLine($"{ calc1.Add(2, 3)} - Expecting 5");     
            Console.WriteLine($"{calc1.Sub(3, 1)} - Expecting 2");     
            Console.WriteLine($"{calc1.Mult(4, 5)} - Expecting 20");    
            Console.WriteLine($"{calc1.Div(10, 3)} - Expecting 3");    

            int[] vallist = new int[4];
            vallist[0] = calc1.Add(2, 3);           //5
            vallist[1] = calc1.Sub(3, 1);           //2
            vallist[2] = calc1.Mult(4, 2);          //8
            vallist[3] = calc1.Div(15, 3);          //5
            int[] resultList = { 5, 2, 8, 5 };

            for(int i= 0; i < resultList.Length; i++)
            {
                Console.WriteLine($"{vallist[i]} - Expecting {resultList[i]}");
            }
        }
    }
}
