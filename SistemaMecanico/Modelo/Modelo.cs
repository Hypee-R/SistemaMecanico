using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace SistemaMecanico.Modelo
{
    class Modelo
    {
        MySqlConnection conexion = ClassConection.crearAdminDB().getConection();
        MySqlCommand query= new MySqlCommand();
        MySqlDataReader lector;
        string[] datos;
        DataTable usuarios;
        string passEncrip;
        
        public bool Loguearme(string user, string password)
        {
            conexion.Close();
            conexion.Open(); 
            query.CommandText = "SELECT * FROM administrador WHERE USER_NAME='"+ user +"' && `PASSWORD`='"+password+"';";
            query.Connection=conexion;
            lector = query.ExecuteReader();
            if (lector.Read()) 
                return true;
            else 
                return false;
        }

        public bool AltasUsuarios(string name,string apPat, string apMat,string telF, string telM, string cor, string dir, string sex, int per)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "INSERT INTO datos_personales VALUES('','"+name+"', '"+apPat+"','"+apMat+"','"+telF+"','"+telM+"','"+cor+"','"+dir+"','"+sex+"',"+per+");";
            query.Connection = conexion;
            if (query.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }

        public DataTable ConsultarUsuarios(string vista, string condicion)
        {
            bool p=false;
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT *  FROM " + vista + " WHERE " + condicion + " && ESTATUS='Activo';";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            if (lector.Read()) p = true;
            if (p == true)
            {
                conexion.Close();
                conexion.Open();
                query.CommandText = "SELECT * FROM " + vista + " WHERE " + condicion + " && ESTATUS='Activo';";
                query.Connection = conexion;
                lector = query.ExecuteReader();
                usuarios = new DataTable();
                usuarios.Load(lector);
            }
            else usuarios = null;
            return usuarios;
        }

        public DataTable ConsultarUsuarios(string vista)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT * FROM " + vista + " WHERE ESTATUS='Activo';";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            usuarios = new DataTable();
            usuarios.Load(lector);
            if (usuarios != null) return usuarios;
            else return null;
        }

        public void EliminarUsuario( string id)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText ="UPDATE datos_personales SET ESTATUS='Inactivo' WHERE ID_DATOS_PERSONALES="+id+";";
            query.Connection = conexion;
            query.ExecuteNonQuery();
        }

        public string[] GetDatosUsuarios (string id)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT * FROM datos_personales WHERE ID_DATOS_PERSONALES="+id+"";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            datos = new string[8];
            if (lector.Read())
            {
                datos[0]=lector.GetString(1);
                datos[1]=lector.GetString(2);
                datos[2]=lector.GetString(3);
                datos[3]=lector.GetString(4);
                datos[4]=lector.GetString(5);
                datos[5]=lector.GetString(6);
                datos[6]=lector.GetString(7);
                datos[7]=lector.GetString(8);
            }
            return datos;
        }

        public void ActualizarDatos(string n,string ap, string am, string tf, string tm, string c, string d,string s, string id)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "UPDATE datos_personales SET NOMBRE='"+n+"', APELLIDO_PATERNO='"+ap+"',APELLIDO_MATERNO='"+am+"',TELEFONO_FIJO='"+tf+"',TELEFONO_MOVIL='"+tm+"',CORREO='"+c+"',DIRECCION='"+d+"',SEXO='"+s+"' WHERE ID_DATOS_PERSONALES='"+id+"';";
            query.Connection = conexion;
            query.ExecuteNonQuery();
        }

        public bool GetCorreo(string correo)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT * FROM datos_personales WHERE CORREO='"+correo+"';";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            if(lector.Read()) return true;
            else return false;
        }

        public string[] GetClientes(string campo, string vista)
        {
            int tamaño=0;
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT COUNT("+campo+") FROM "+vista+";";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            if(lector.Read()) tamaño=lector.GetInt32(0);
            datos=new string[tamaño];

            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT "+campo+" FROM "+vista+";";
            query.Connection = conexion;
            lector =query.ExecuteReader();
            for(int i=0;i<datos.Length;i++)
            {
                if(lector.Read())
                    datos[i]=lector.GetString(0);
            }
            return datos;
        }

        public string GetIdCliente(string nombre)
        {
            string p = "";
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT c.ID_CLIENTE  FROM cliente AS c, vista_datos_cliente AS vc WHERE c.DATOS_PERSONALES= vc.ID_CLIENTE && vc.NOMBRE_CLIENTE='"+nombre+"'";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            if (lector.Read())
                 p=lector.GetString(0);
            return p;
        }

        public string GetNombreCliente(string id)
        {
            string p = "";
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT vc.NOMBRE_CLIENTE  FROM cliente AS c, vista_datos_cliente AS vc WHERE c.DATOS_PERSONALES= vc.ID_CLIENTE && c.ID_CLIENTE='"+id+"'";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            if (lector.Read())
                p = lector.GetString(0);
            return p;
        }

        public string GetNombreEmpleado(string id)
        {
            string p = "";
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT ve.NOMBRE_EMPLEADO  FROM empleado AS e, vista_datos_empleados AS ve WHERE e.DATOS_PERSONALES= ve.ID_EMPLEADO && e.ID_EMPLEADO='"+id+"'";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            if (lector.Read())
                p = lector.GetString(0);
            return p;
        }

        public string GetIdEmpleado(string nombre)
        {
            string p = "";
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT e.ID_EMPLEADO  FROM empleado AS e, vista_datos_empleados AS ve WHERE e.DATOS_PERSONALES= ve.ID_EMPLEADO && ve.NOMBRE_EMPLEADO='"+nombre+"'";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            if (lector.Read())
                p = lector.GetString(0);
            return p;
        }

        public bool AltasCitas(string fecha, string lugar, string descripcion, string costo, string cliente)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "INSERT INTO cita VALUES('','"+fecha+"','"+lugar+"','"+descripcion+"','"+costo+"','"+cliente+"', 'Pendiente');";
            query.Connection = conexion;
            if (query.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }

        public DataTable ConsultarCitas(string vista, string condicion)
        {
            bool p = false;
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT *  FROM " + vista + " WHERE " + condicion + " && ESTATUS='Atendida';";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            if (lector.Read()) p = true;
            if (p == true)
            {
                conexion.Close();
                conexion.Open();
                query.CommandText = "SELECT * FROM " + vista + " WHERE " + condicion + " && ESTATUS='Atendida';";
                query.Connection = conexion;
                lector = query.ExecuteReader();
                usuarios = new DataTable();
                usuarios.Load(lector);
            }
            else usuarios = null;
            return usuarios;
        }

        public DataTable ConsultarCitas(string vista)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT * FROM " + vista + ";";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            usuarios = new DataTable();
            usuarios.Load(lector);
            if (usuarios != null) return usuarios;
            else return null;
        }

        public string[] GetDatosCitas(string idCita)  
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT * FROM vista_citas_totales WHERE ESTATUS='Pendiente' && ID_CITA= " + idCita + "";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            datos = new string[5];
            if (lector.Read())
            {
                datos[0] = lector.GetString(1);
                datos[1] = lector.GetString(2);
                datos[2] = lector.GetString(3);
                datos[3] = lector.GetString(4);
                datos[4] = lector.GetString(5);
                
            }
            return datos;
        }

        public void ActualizarDatosCitas(string f, string l, string d, string c, string id)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "UPDATE cita SET FECHA_HORA='"+f+"',LUGAR='"+l+"',DESCRIPCION='"+d+"',COSTO_ESTIMADO='"+c+"' WHERE ID_CITA='"+id+"';";
            query.Connection = conexion;
            query.ExecuteNonQuery();
        }

        public void CancelarCita(string id)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "UPDATE cita SET ESTATUS='Cancelada' WHERE ID_CITA='"+id+"';";
            query.Connection = conexion;
            query.ExecuteNonQuery();
        }

        public string[] GetDatosServicio(string id)
        {
                conexion.Close();
                conexion.Open();
                query.CommandText = "SELECT ID_SERVICIO,FECHA_RECEPCION,TIEMPO_ESTIMADO,FECHA_ENTREGA_ESTIMADA,AUTO_MARCA_MODELO,MATRICULA,CLIENTE,COSTO_ESTIMADO,DESCRIPCION_GLOBAL,DESCRIPCION_GENERAL,STATUS,CITA,EMPLEADO FROM servicio WHERE ID_SERVICIO='"+id+"';";
                query.Connection = conexion;
                lector = query.ExecuteReader();
                datos= new string [13];
                if(lector.Read())
                {
                    for(int i=0;i<datos.Length;i++)
                    {
                        datos[i] = lector.GetString(i);
                    }
                }
            return datos;
        }

        public bool IniciarServicio(string te,string fe,string au,string pl,string cli,string co,string fg,string fae,string c,string e)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "INSERT INTO servicio (FECHA_RECEPCION,TIEMPO_ESTIMADO,FECHA_ENTREGA_ESTIMADA,AUTO_MARCA_MODELO,MATRICULA,CLIENTE,COSTO_ESTIMADO,DESCRIPCION_GLOBAL,DESCRIPCION_GENERAL,STATUS,CITA,EMPLEADO) VALUES "+
                                                     "('" + DateTime.Today.ToString("d") + "','"+te+"','"+fe+"','"+au+"','"+pl+"','"+cli+"','"+co+"','"+fg+"','"+fae+"','En proceso','"+c+"','"+e+"');";
            query.Connection = conexion;
            if (query.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }

        public void ActualizarEstatusCita(string id)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "UPDATE cita SET ESTATUS='Atendida' WHERE ID_CITA='" + id + "';";
            query.Connection = conexion;
            query.ExecuteNonQuery();
        }

        public void ActualizarDatosServicios(string da, string ti, string det, string ct,string mat, string id)
        {
            conexion.Close();
            conexion.Open();
            query.CommandText = "UPDATE servicio SET FECHA_ENTREGA='" + DateTime.Today.ToString("d") + "',DESCRIPCION_ACTUAL='"+da+"',TIEMPO_INVERTIDO='"+ti+"',DETALLE_SERVICIO_REALIZADO='"+det+"',COSTO_TOTAL='"+ct+"',STATUS='Entregado',MATERIALES='"+mat+"' WHERE ID_SERVICIO='"+id+"';";
            query.Connection = conexion;
            query.ExecuteNonQuery();
        }

        public string GetIdMaterial(string nombre)
        {
            string p = "";
            conexion.Close();
            conexion.Open();
            query.CommandText = "SELECT ID_MATERIAL FROM materiales WHERE DESCRIPCION='"+nombre+"'";
            query.Connection = conexion;
            lector = query.ExecuteReader();
            if (lector.Read())
                p = lector.GetString(0);
            return p;
        }

        public string EncriptaPassword(string pass)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(pass));

            for (int i = 0; i < stream.Length ; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
                passEncrip = sb.ToString();
            }

            return passEncrip;
        }


    }
}
