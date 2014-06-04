using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasRepetitivas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vamos a imprimir los 4 primeros numeros

            for (int i = 1; i < 5; i++) {
                Console.WriteLine("Va por el numero {0}", i);
            
            }

            int numero=1;
            while (numero < 5) {

                Console.WriteLine("Va por el numero {0}", numero);
                numero++;
            }

            numero = 1;

            do
            {
                Console.WriteLine("Va por el numero {0}", numero);
                numero++;
            } while (numero < 5);


            //Si lo que queremos es ver el contenido de un array

            String[] nombres = { "Eva", "Juan", "Pedro", "Antonio" };

            foreach (var nombre in nombres) {

                Console.WriteLine("El nombre es {0}", nombre);
                
            }

            Console.ReadLine();
        }
    }
}
