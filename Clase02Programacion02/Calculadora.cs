using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02Programacion02
{
    class Calculadora//Es un nuevo tipo de dato llamado calculadora
    {
        
        private static void sumar(double numero1, double numero2)//Es un metodo estatico se puede saber si se pone la clase. y aparece
        {
            Console.WriteLine("Estoy sumando");        
            Console.WriteLine(numero1 + numero2);
        }

        private static void restar(double numero1, double numero2)
        {
            Console.WriteLine("Estoy restando");
            Console.WriteLine(numero1 - numero2);
        }

        private static void multiplicar(double numero1, double numero2)
        {
            Console.WriteLine("Estoy multiplicando");
            Console.WriteLine(numero1 * numero2);
        }

        private static void dividir(double numero1, double numero2)
        {
            Console.WriteLine("Estoy dividiendo");
            //Console.WriteLine(numero1 / numero2);

            if (Calculadora.validarSiEsDistintoACero(numero2) == true)
            {
                Console.WriteLine(numero1 / numero2);
            }
            else 
            {
                Console.WriteLine("Error, no se puede dividir por cero(0)");
            }
        }

        private static bool validarSiEsDistintoACero(double numero2)//private solo se ve dentro de la clase
        {
            if (numero2 != 0)
            {
                return true;
            }
            else 
            {
                //Console.WriteLine("Error, no se puede dividir por cero");
                return false;
            }           
        }

        public static void calcular(double numero1, double numero2, string operacion) 
        {
            
            switch(operacion)
            {
                case "+":
                    Calculadora.sumar(numero1, numero2);                  
                    break;

                case "-":
                    Calculadora.restar(numero1, numero2);
                    break;

                case "*":
                    Calculadora.multiplicar(numero1, numero2);
                    break;

                case "/":
                    Calculadora.dividir(numero1, numero2);
                    break;

            }
        }

        public static void mayor(double numero1, double numero2, double numero3)
        {
            if (numero1 > numero2 && numero1> numero2)
            {
                Console.WriteLine(numero1);
            }
            if (numero2 > numero1 && numero2 > numero3) 
            {
                Console.WriteLine(numero2);
            }

            if (numero3 > numero1 && numero3 > numero2) 
            {
                Console.WriteLine(numero3);
            }

        }
        
    }
}
