using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOpcional_0900167780
{
    class Nodo
    {
        public Object Elemento { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Object el)
        {
            Elemento = el;
            Siguiente = null;
        }

        public override string ToString()
        {
            return "Elemento = " + Elemento.ToString();
        }
    }
}
