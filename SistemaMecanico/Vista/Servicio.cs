using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMecanico.Vista
{
    public partial class Servicio : Form
    {
        Controlador.Controlador controler = new Controlador.Controlador();
        string operacion,idService;
        string[] datos;

        public Servicio(string op,string id=null)
        {
            InitializeComponent();
            operacion = op;
            idService = id;
        }

        private void InicioServicio_Load(object sender, EventArgs e)
        {
            if (operacion.Equals("IniciarServicio"))
            {
                grpInicioServicio.Enabled = true;

                datos = controler.GetClientes("ID_CITA", "cita WHERE ESTATUS='Pendiente'");
                for (int i = 0; i < datos.Length; i++)
                {
                    cmbCita.Items.Add(datos[i]);
                }

                datos = controler.GetClientes("NOMBRE_CLIENTE", "vista_datos_cliente");
                for (int i = 0; i < datos.Length; i++)
               {
                   cmbCliente.Items.Add(datos[i]);
               }

                datos = controler.GetClientes("NOMBRE_EMPLEADO", "vista_datos_empleados");
                for (int i = 0; i < datos.Length; i++)
               {
                   cmbEmpleado.Items.Add(datos[i]);
               }
            }
            if (operacion.Equals("Finalizar"))
            {
                datos = controler.GetClientes("DESCRIPCION", "materiales");
                for (int i = 0; i < datos.Length; i++)
                {
                    cmbMateriales.Items.Add(datos[i]);
                }

                lblCita.Visible = true;
                cmbCita.Visible = true;
                datos = controler.GetDatosServicios(idService);
                txtTiempoEstiamdo.Text=datos[2];
                txtFechaEstimada.Text = datos[3];
                txtModelo.Text = datos[4];
                txtMatricula.Text = datos[5];
                cmbCliente.Text = controler.GetNombreCliente(datos[6]);
                txtCostoEstimado.Text = datos[7];
                cmbDescGlobal.Text = datos[8];
                txtDescEspecifica.Text = datos[9];
                cmbCita.Text = datos[11];
                cmbEmpleado.Text = controler.GetNombreEmpleado(datos[12]);
                grpFinalServicio.Enabled = true;

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (operacion.Equals("IniciarServicio"))
            {
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
                this.Hide();
            }
            if (operacion.Equals("Finalizar"))
            {
                ConsultasUsuarios c = new ConsultasUsuarios(1,operacion,"Servicios");
                c.Show();
                this.Hide();
            }
        }

        private void rdbConCita_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConCita.Checked)
            {
                lblCita.Visible = true;
                cmbCita.Visible = true;
                cmbCita.Text = "ID CITA";
            }
            else
            {
                lblCita.Visible = false;
                cmbCita.Visible = false;
                cmbCliente.Enabled = true;
                txtDescEspecifica.Enabled = true;
                txtCostoEstimado.Enabled = true;
                cmbCliente.Text="Cliente";
                txtCostoEstimado.Text = "";
                txtDescEspecifica.Text = "";
                
            }
        }

        private void cmbCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos = controler.GetDatosCitas(cmbCita.SelectedItem.ToString());
            cmbCliente.Text=datos[0];
            txtDescEspecifica.Text=datos[2];
            txtCostoEstimado.Text = datos[3];
            cmbCliente.Enabled = false;
            txtDescEspecifica.Enabled = false;
            txtCostoEstimado.Enabled = false;
        }

        private void rdbConMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConMaterial.Checked)
            {
                lblMateriales.Visible = true;
                cmbMateriales.Visible = true;
            }
            else
            {
                lblMateriales.Visible = false;
                cmbMateriales.Visible = false;
            }
        }

        private void btnInicioServicio_Click(object sender, EventArgs e)
        {
            if (operacion.Equals("IniciarServicio"))
            {
                if (controler.IniciarServicio(txtTiempoEstiamdo.Text, txtFechaEstimada.Text, txtModelo.Text, txtMatricula.Text, controler.GetIdClientes(cmbCliente.SelectedItem.ToString()), txtCostoEstimado.Text, cmbDescGlobal.SelectedItem.ToString(), txtDescEspecifica.Text, cmbCita.SelectedItem.ToString(), controler.GetIdEmpleado(cmbEmpleado.SelectedItem.ToString())))
                {
                    controler.ActualizaEstatusCita(cmbCita.SelectedItem.ToString()); 
                    MessageBox.Show("Servicio dado de alta");
                }
                else
                    MessageBox.Show("Algo salio mal");
            }
            if (operacion.Equals("Finalizar"))
            {
               controler.ActualizarDatosServicios(txtDescAtual.Text,txtTiempoInvertido.Text,txtServRealizado.Text,txtCostoTotal.Text,controler.GetIdMaterial(cmbMateriales.SelectedItem.ToString()),idService);
            }
        }

        private void grpFinalServicio_Enter(object sender, EventArgs e)
        {

        }

        private void grpCita_Enter(object sender, EventArgs e)
        {

        }
    }
}
