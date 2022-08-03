using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMecanico.Controlador
{
    class Controlador
    {
        Modelo.Modelo m = new Modelo.Modelo();
        public bool Loguearme(string user, string password)
        {
            return m.Loguearme(user,password);
        }

        public bool AltasUsuario(string n,string apP,string apM, string tF,string tM,string co, string di, string se, int p)
        {
            return m.AltasUsuarios(n,apP,apM,tF,tM,co,di,se,p);
        }

        public DataTable ConsultarUsuarios(string vista, string condicion)
        {
            return m.ConsultarUsuarios(vista, condicion);
        }

        public DataTable ConsultarUsuarios(string vista)
        {
            return m.ConsultarUsuarios(vista);
        }

        public void EliminarUsuarios(string id)
        {
            m.EliminarUsuario(id);
        }

        public string[] GetDatosUsuarios(string id)
        {
            return m.GetDatosUsuarios(id);
        }

        public void ActulizarDatos(string n, string ap, string am, string tf, string tm, string c, string d, string s, string id)
        {
            m.ActualizarDatos(n,ap,am,tf,tm,c,d,s,id);
        }

        public bool GetCorreo(string correo)
        {
            return m.GetCorreo(correo);
        }

        public string[] GetClientes(string campo, string vista)
        {
            return m.GetClientes(campo,vista);
        }

        public string GetIdClientes(string nombre)
        {
            return m.GetIdCliente(nombre);
        }

        public string GetNombreCliente(string id)
        {
            return m.GetNombreCliente(id);
        }

        public string GetNombreEmpleado(string id)
        {
            return m.GetNombreEmpleado(id);
        }

        public bool AltaCitas(string fecha, string lugar, string descripcion, string costo, string cliente)
        {
            return m.AltasCitas(fecha,lugar,descripcion,costo,cliente);
        }

        public DataTable ConsultarCitas(string vista, string condicion)
        {
            return m.ConsultarCitas(vista,condicion);
        }

        public DataTable ConsultarCitas(string vista)
        {
            return m.ConsultarCitas(vista);
        }

        public string[] GetDatosCitas(string id)
        {
            return m.GetDatosCitas(id);
        }

        public void ActualizarDatosCitas(string f, string l, string d, string c, string id)
        {
            m.ActualizarDatosCitas(f,l,d,c,id);
        }

        public void CancelarCita(string id)
        {
            m.CancelarCita(id);
        }

        public string[] GetDatosServicios(string id)
        {
           return m.GetDatosServicio(id);
        }

        public bool IniciarServicio(string te, string fe, string au, string pl, string cli, string co, string fg, string fae, string c, string e)
        {
            return m.IniciarServicio(te,fe,au,pl,cli,co,fg,fae,c,e);
        }

        public string GetIdEmpleado(string nombre)
        {
            return m.GetIdEmpleado(nombre);
        }

        public void ActualizaEstatusCita(string id)
        {
            m.ActualizarEstatusCita(id);
        }

        public void ActualizarDatosServicios(string da, string ti, string det, string ct, string mat, string id)
        {
            m.ActualizarDatosServicios(da,ti,det,ct,mat,id);
        }

        public string GetIdMaterial(string nombre)
        {
            return m.GetIdMaterial(nombre);
        }

        public string EncriptaPass(string p)
        {
            return m.EncriptaPassword(p);
        }
    }
}
