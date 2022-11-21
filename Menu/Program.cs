using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       

            Console.WriteLine("1) Opción 1");
            Console.WriteLine("2) Opción 2");
            Console.WriteLine("3) Opción 3");
            Console.WriteLine("4) Salir");
            Console.WriteLine("Elige una de las opciones");
            int otp = int.Parse(Console.ReadLine());

            switch (otp)
            {
                case 1:
                    Console.WriteLine("Has elegido la Opción 1");                    
                    Console.ReadKey();
                    break;

               case 2:
                    Console.WriteLine("Has elegido la Opción 2");
                    Console.ReadKey();
                    break ;

              case 3:
                    Console.WriteLine("Has elegido la Opción 3");
                    Console.ReadKey();
                    break;

                case 4:
                    break ;

                default:
                    Console.WriteLine("Debe elegir una opción correcta");
                    Console.ReadKey();
                    break;
            }
            


        }
    }
}
