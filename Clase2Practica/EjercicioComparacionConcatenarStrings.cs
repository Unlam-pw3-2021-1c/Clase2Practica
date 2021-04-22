using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Practica
{
    class EjercicioComparacionConcatenarStrings
    {
        public static void Ejecutar()
        {
            DateTime inicio = DateTime.Now;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                sb.AppendLine(Guid.NewGuid().ToString());
            }

            Console.WriteLine($"Demoro {(DateTime.Now - inicio).TotalMilliseconds} ms");
            //Console.WriteLine(sb.ToString());


            inicio = DateTime.Now;
            string texto = "";
            for (int i = 0; i < 1000; i++)
            {
                texto = texto + Environment.NewLine + Guid.NewGuid().ToString();
            }

            Console.WriteLine($"Demoro {(DateTime.Now - inicio).TotalMilliseconds} ms");
            Console.WriteLine(texto);

        }
    }
}
