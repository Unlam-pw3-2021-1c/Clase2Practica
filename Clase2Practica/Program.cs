using Newtonsoft.Json;
using System;
using System.IO;

namespace Clase2Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //buscar archivo json
            //Console.WriteLine("El directorio actual es:");
            //string directorioDelJson = $@"..\.\..\..\{Directory.GetCurrentDirectory()}";

            //para archivos grandes, se debe leer de a bloques utilizando un while
            string jsonText = File.ReadAllText(@"..\.\..\..\..\ordenes.json");

            //parsear json
            JsonRoot myDetails = JsonConvert.DeserializeObject<JsonRoot> (jsonText);

            //filtrar ordenes sin entregar
            
            //mostrar por pantalla


        }


    }
}
