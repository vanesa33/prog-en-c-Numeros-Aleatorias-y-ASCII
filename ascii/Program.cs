using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace NÚMEROS_ALEATORIOS_Y_CARACTERES_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CAN, K;
            int NUM;
            string linea;
            Console.Write("CUANTOS NÚMEROS: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            //INICIALIZA EL GENERADOR DE ALEATORIOS
            Random ran = new Random();
            for (K = 1; K <= CAN; K++)
            {
                NUM = Convert.ToInt32(ran.Next(100));
                Console.WriteLine("GENERÓ EL: " + NUM);
                if (((NUM > 0) & (NUM < 256)))
                {
                    Console.WriteLine("EL CÓDIGO DEL " + NUM + " ES " +
                   Convert.ToString((char)NUM));
                }
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}