using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMecanico
{
    class Nodo
    {
        private object valor;
        private Nodo sig;

        public Nodo()
        {
            valor = null;
            sig = null;
        }

        public Nodo(object val)
        {
            valor = val;
            sig = null;
        }

        public Nodo(object val, Nodo s)
        {
            valor = val;
            sig = s;
        }

        public object Valor
        {
            set { valor = value; }
            get { return valor; }
        }

        public Nodo Siguiente
        {
            set { sig = value; }
            get { return sig; }
        }
    }
}
