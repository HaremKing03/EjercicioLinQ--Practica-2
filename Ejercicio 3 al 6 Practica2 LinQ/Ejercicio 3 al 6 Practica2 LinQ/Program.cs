using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_al_6_Practica2_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio3();
            Ejercicio4A();
            Ejercicio4B();
            Ejercicio5conLinQ();
            Ejercicio6();


        }


        static void Ejercicio3()
        {
            List<int> valores = new List<int>() { 1, 5, 2, 3, 4, 6, 7, 8, 9 };

            var valoresNoOrdenados = valores.OrderBy(X => X);

            foreach (var valorOrdenado in valoresNoOrdenados)
            {
                Console.WriteLine(valorOrdenado);
            }


        }
        static void Ejercicio4A()
        {
            List<int> valores = new List<int>() { 1, 5, 2, 3, 4, 6, 7, 8, 9 };

            var Suma = valores.Sum();


            Console.WriteLine(Suma);



        }
        static void Ejercicio4B()
        {
            List<int> valores = new List<int>() { 1, 5, 2, 3, 4, 6, 7, 8, 9 ,10 };

                    var valoresPares = valores.Where(valor => valor % 2== 0).ToList();

                    var Suma = valoresPares.Sum();
                    Console.WriteLine(Suma);

                

            


        }
        static void Ejercicio5conLinQ()
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var valoresParesMayores8 = valores.Where(x => x % 2 == 0 && x > 8).ToList();
            var valoresParesMenores8 = valores.Where(x => x % 2 == 0 && x < 8).ToList();
            var SumaMayores = valoresParesMayores8.Sum();
            var SumaMenores = valoresParesMenores8.Sum();

            Console.WriteLine("La suma de los mayores a 8 es de :" + SumaMayores);
            Console.WriteLine("La suma de los menores a 8 es de :" + SumaMenores);
        }
        static void Ejercicio6()
        {
            List<string> abecedario = new List<string>() { "a","b","c", "d", "e", "f", "g"};
            Console.WriteLine("Ingrese una letra minuscula desde A hasta F para saber cuales es la siguiente letra del abecedario");
            string letra = Console.ReadLine();
            int posicion = abecedario.IndexOf(letra);
            posicion++;
            for (int i = 0;i < abecedario.Count; i++) {
                
                //Console.WriteLine("La siguiente letra del abecedario es:" + abecedario[posicion][i]);
                Console.WriteLine("La siguiente letra del abecedario es:" + abecedario[posicion][i]);
                break;
                
            }
            
           
            
            
        }

    }
}
