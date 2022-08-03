using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMecanico
{
    class ListaLigada
    {
        private Nodo raiz;
        public ListaLigada()
        {
            raiz = new Nodo("lista");
        }

        public void insertar(string [] val)
        {
            Nodo ap = null;
            ap = raiz;
            while (ap.Siguiente != null)
            {
                ap = ap.Siguiente;
            }
            ap.Siguiente = new Nodo(val);
        }

        public void insertar(string [] val, int pos)
        {
            int tam = Length();
            if (pos < 0 || pos >= tam)
            {
                throw new Exception("Posicion para insertar valores fuera de rango permitido!!");
            }

            if (pos == 0)//va a entrar como raiz
            {
                try
                {
                    Nodo tem = new Nodo(val);
                    tem.Siguiente = raiz;
                    raiz = tem;
                }
                catch (Exception err)
                {
                    throw new Exception("Error al insertar un elemento en la posicion inicial");
                }
            }
            else
            {
                try
                {
                    int con = 0;
                    Nodo ap = null;
                    ap = raiz;

                    while (con < pos - 1)
                    {
                        ap = ap.Siguiente;
                        con++;
                    }
                    Nodo t = new Nodo(val);
                    t.Siguiente = ap.Siguiente;
                    ap.Siguiente = t;
                }
                catch (Exception err)
                {
                    throw new Exception("Error al insertar nodos en una posicion del arreglo");
                }
            }
        }

        public void eliminar()
        {
            Nodo ac = null;
            Nodo an = null;
            ac = raiz;
            an = raiz;
            while (ac.Siguiente != null)
            {
                an = ac;
                ac = ac.Siguiente;
            }
            an.Siguiente = null;
        }

        public void eliminar(int pos)
        {
            int tam = Length();
            if (pos < 0 || pos >= tam)
            {
                throw new Exception("Posicion para eliminar nodos fuera de rango valido");
            }
            if (pos == 0)//deseo eliminar el primer elemento
            {
                //reviso si existe almenos un nodo despues de la raiz
                if (raiz.Siguiente != null)
                {
                    Nodo tem = null;
                    tem = raiz.Siguiente;
                    raiz.Siguiente = null;
                    raiz = null;
                    raiz = tem;
                }
            }
            else
            {
                int i = 0;
                Nodo ac = null;
                Nodo an = null;
                ac = raiz;
                an = raiz;

                while (i < pos)
                {
                    an = ac;
                    ac = ac.Siguiente;
                    i++;
                }
                an.Siguiente = ac.Siguiente;
                ac = null;
            }
        }

        public void modificar(int pos, string [] val)
        {
            int tam = Length();
            if (pos < 0 || pos >= tam)
            {
                throw new Exception("Posicion para eliminar nodos fuera de rango valido");
            }
            int i = 0;
            Nodo ac = null;
            Nodo an = null;

            ac = raiz;
            an = raiz;

            while (i < pos)
            {
                an = ac;
                ac = ac.Siguiente;
                i++;
            }
            ac.Valor = val;
        }

        public object getValue(int pos)
        {
            int tam = Length();
            if (pos < 0 || pos >= tam)
            {
                throw new Exception("Posicion para obtener valor fuera del rango establecido");
            }

            int i = 0;
            Nodo t = null;
            t = raiz;

            while (i < pos)
            {
                t = t.Siguiente;
                i++;
            }
            return t.Valor;
        }

        public override string ToString()
        {
            StringBuilder cad = new StringBuilder(10);
            Nodo t = null;
            t = raiz;

            while (t.Siguiente != null)
            {
                cad.Append(t.Valor.ToString());
                cad.Append("->");
                t = t.Siguiente;
            }

            cad.Append(t.Valor.ToString());
            cad.Append("->null");
            return cad.ToString();
        }

        public int Length()
        {
            int i = 1;
            Nodo t = null;
            t = raiz;
            while (t.Siguiente != null)
            {
                i++;
                t = t.Siguiente;
            }
            return i;
        }

        internal string getValue()
        {
            throw new NotImplementedException();
        }
    }
}
