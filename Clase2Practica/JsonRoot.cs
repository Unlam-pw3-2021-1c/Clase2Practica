using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Practica
{
    public class JsonRoot
    {
        public List<Orden> ordenes { get; set; }
    }
    public class Orden
    {
        public int nroOrden { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
        public bool entregada { get; set; }
    }
}
