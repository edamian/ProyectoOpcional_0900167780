using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOpcional_0900167780
{
    class Imagen
    {
        public String direccion { get; set; }
        
        public Imagen(String dir)
        {
            direccion = dir;
        }

        public override string ToString()
        {
            return direccion.ToString();
        }
    }
}
