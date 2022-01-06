using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto13._2
{
    class Program
    {
        public class Triangulos
        {
            private float lado1 { get; set; }
            private float lado2 { get; set; }
            private float lado3 { get; set; }

            public void Cargar()
            {
                Console.Write("Dame el primer lado del triangulo: ");
                lado1 = float.Parse(Console.ReadLine());

                Console.Write("Dame el segundo lado del triangulo: ");
                lado2 = float.Parse(Console.ReadLine());

                Console.Write("Dame el tercer lado del triangulo: ");
                lado3 = float.Parse(Console.ReadLine());
            }

            public  void LadoMayor()
            {
                if (lado1 > lado2 && lado1 > lado3)
                {
                    Console.WriteLine("El primer lado es el lado mayor.");
                }
                else if(lado2 > lado1 && lado2 > lado3)
                {
                    Console.WriteLine("El segundo lado es el lado mayor.");
                }
                else if(lado3 > lado1 && lado3 > lado2)
                {
                    Console.WriteLine("El tercer lado es el lado mayor.");
                }
                else
                {
                    Console.WriteLine("Hay varios lados iguales.");
                }                                
            }

            public void Equilatero()
            {
                if (lado1 == lado2 && lado2 ==lado3)
                {
                    Console.WriteLine("Es un triangulo equilatero");
                }
                else
                {
                    Console.WriteLine("No es un triangulo equilatero");
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Triangulos triangulo = new Triangulos();
                triangulo.Cargar();
                triangulo.LadoMayor();
                triangulo.Equilatero();
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");
            }
            Console.ReadKey();
        }
    }
}
