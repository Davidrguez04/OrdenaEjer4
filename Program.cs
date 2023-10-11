
using System;
/*Desarrolla un programa que solicite tres números reales por pantalla y mediante el uso de if else if else... 
 * mostrar por consola los tres números ordenados de mayor a menor.
 */

namespace OrdenaEjer4
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// contiene el procedimiento o flujo de nuestra aplicación
        /// 111023 - David Rodriguez Alonso
        /// </summary>
        /// <param name="args"></param>



        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Intoduzca un número: ");
            num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Intoduzca el número 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Intoduzca el número 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSolución:");

            if (num1 > num2 && num1> num3)
            {
                Console.Write(num1);

            }
            else if(num2>num3)
            {
                Console.Write(num2);
            }
            else if (num3 > num2)
            {
                Console.Write(num3);
            }
            /***********************************/
            Console.Write("<");
            if (num1 > num2 && num1 < num3|| num1>num3 && num1<num2)
            {
                Console.Write(num1);

            }
            else if (num2 > num3 && num2 <num1 || num2<num3 && num2>num1)
            {
                Console.Write(num2);
            }
            else if (num3 > num2 && num3< num1|| num3<num2 && num3>num1)
            {
                Console.Write(num3);
            }
            /******************************************/
            Console.Write("<");
            if (num1 < num2 && num1 < num3)
            {
                Console.Write(num1);

            }
            else if (num2 < num3)
            {
                Console.Write(num2);
            }
            else if (num3 < num2)
            {
                Console.Write(num3);
            }
            Console.WriteLine();
        }

    }
}
