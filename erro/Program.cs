using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação(+(1),-(2),*(3),/(4))");
            double ope= double.Parse(Console.ReadLine());      
            Console.WriteLine("Digite o primeiro valor");
            double v11 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("o valor da soma é: " + opera(ope,v11,v2));

            
            Console.ReadKey();

        }

        static double opera(double ope, double v11, double v2)
        {


            if (ope == 1)
            {
                return v11 + v2 ;
              
            }
            else if (ope == 2)
            {
               return v11 - v2 ;
                
            }
            else if (ope == 3)
            {
                return v11 * v2 ;
              

            }
            else if (ope == 4)
            {
                return v11 / v2 ;
               
            }
            else 
            {
                return 0;
            }
            

        }
    }
}
