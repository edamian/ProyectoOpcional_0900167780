using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOpcional_0900167780
{
    class Cola
    {
        public Nodo frente { get; set; }
        public Nodo fin { get; set; }
        public int tamanio { get; set; }
        public Cola()
        {
            frente = fin = null;
        }

        public void insertar(Imagen img)
        {
            Nodo nodo = new Nodo(img);
            if(colaVacia())
            {
                frente = nodo;
                tamanio++;
            } else
            {
                fin.Siguiente = nodo;
                tamanio++;
            }
            fin = nodo;
        }

        public Object quitar() 
        {
            Object aux = null;
            if(!colaVacia())
            {
                aux = frente.Elemento;
                frente = frente.Siguiente;
                tamanio--;
            } 
            return aux;
        }

        public void borrar()
        {
            for(; frente != null;)
            {
                frente = frente.Siguiente;
            }
            //System.GC;
        }

        public Object FrenteCola()
        {
            if(colaVacia())
            {

            }
            return frente.Elemento;
        }

        public bool colaVacia()
        {
            return (frente == null);
        }

        public void ver()
        {
            Nodo temp = frente;
            if(!colaVacia())
            {
                for(int k =0; k<tamanio; k++)
                {
                    Console.WriteLine(temp.Elemento.ToString() + ", ");
                    temp = temp.Siguiente;
                }
                Console.Write("");
            }
        }
    }
}
