using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Clase2Practica
{
    class EjercicioLeerJson
    {
        public static void Ejecutar()
        {
            //buscar archivo json
            //Console.WriteLine("El directorio actual es:");
            //string directorioDelJson = $@"..\.\..\..\{Directory.GetCurrentDirectory()}";

            //para archivos grandes, se debe leer de a bloques utilizando un while
            string jsonText = File.ReadAllText(@"..\.\..\..\..\ordenes.json");

            //parsear json
            JsonRoot jsonObj = JsonConvert.DeserializeObject<JsonRoot>(jsonText);

            //filtrar ordenes sin entregar
            List<Orden> ordenesSinEntregar = jsonObj.ordenes.Where(o => !o.entregada).ToList();

            //mostrar por pantalla
            Console.WriteLine("Las ordenes sin entregar son:");
            Console.WriteLine("nroOrden, descripcion, cantidad, precio");
            foreach (Orden orden in ordenesSinEntregar)
            {
                Console.WriteLine($"{orden.nroOrden}, {orden.descripcion}, {orden.cantidad}, {orden.precio}");
            }
        }
    }
}
