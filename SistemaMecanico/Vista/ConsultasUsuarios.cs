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
    public partial class ConsultasUsuarios : Form
    {
        string sexo, operacion, us, menu, nom;
        int perfil;
        DataTable usuarios;
        Controlador.Controlador controler = new Controlador.Controlador();

        public ConsultasUsuarios(int pe, string ope,string men)
        {
            InitializeComponent();
            perfil = pe;
            operacion = ope;
            menu = men;
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            ActividadesLoad();   
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            ActividadesBtnBuscar();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActividadesCmbFiltro();
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu.Equals("Empleado") || menu.Equals("Clientes"))
            {
                if (cmbFiltro.SelectedIndex < 0) btnBuscar.Enabled = false;
                else btnBuscar.Enabled = true;
                if (cmbSexo.SelectedIndex == 0) sexo = "m";
                if (cmbSexo.SelectedIndex == 1) sexo = "f";
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "") btnBuscar.Enabled = true;
            else btnBuscar.Enabled = false;
        }

        private void dtwDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ActividadesDtwDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ActividadesBtnEliminar();
        }

        public void ActividadesLoad()
        {
            if (menu.Equals("Empleado") || menu.Equals("Clientes"))
            {
                cmbFiltro.Items.Add("ID");
                cmbFiltro.Items.Add("NOMBRE");
                cmbFiltro.Items.Add("CORREO");
                cmbFiltro.Items.Add("SEXO");
                cmbFiltro.Items.Add("GENERAL");
                cmbSexo.Items.Add("MASCULINO");
                cmbSexo.Items.Add("FEMENINO");
                if (perfil == 1) us = "EMPLEADOS";
                else us = "CLIENTES";
                if (operacion.Equals("Consultar") || operacion.Equals("Editar")) this.Text = "CONSULTAS " + us;
                if (operacion.Equals("Eliminar"))
                {
                    this.Text = "ELIMINAR " + us;
                    btnEliminar.Visible = true;
                }
                else btnEliminar.Visible = false;
            }
            if (menu.Equals("Citas"))
            {
                if (operacion.Equals("Consultar")) this.Text = "CONSULTAS " + menu;
                {
                    cmbFiltro.Items.Add("CITAS ATENDIDAS");
                    cmbFiltro.Items.Add("CITAS PENDIENTES");
                    cmbFiltro.Items.Add("ID CITA");
                    cmbFiltro.Items.Add("NOMBRE CLIENTE");
                    btnEliminar.Visible = false;
                }
                if (operacion.Equals("Editar"))
                {
                    cmbFiltro.Visible = false;
                    txtFiltro.Visible = false;
                    btnBuscar.Visible = false;
                    btnEliminar.Visible = false;
                    lblFiltro.Visible = false;
                    usuarios = controler.ConsultarCitas("vista_citas_pendientes");
                    if (usuarios != null) dtwDatos.DataSource = usuarios;
                }
                if (operacion.Equals("Cancelar"))
                {
                    this.Text = "CANCELAR CITAS";
                    btnEliminar.Visible = true;
                    btnEliminar.Text = "CANCELAR";
                    usuarios = controler.ConsultarCitas("vista_citas_pendientes");
                    if (usuarios != null) dtwDatos.DataSource = usuarios;
                }
                cmbSexo.Visible = false;
            }
            if (menu.Equals("Servicios"))
            {
                if (operacion.Equals("Consultar"))
                {
                    cmbFiltro.Items.Add("SERVICIOS ATENDIDOS");
                    cmbFiltro.Items.Add("SERVICIOS PENDIENTES");
                    cmbFiltro.Items.Add("ID SERVICIO");
                    cmbFiltro.Items.Add("IS CLIENTE");
                    btnEliminar.Visible = false;
                }
                if (operacion.Equals("Finalizar"))
                {
                    cmbFiltro.Visible = false;
                    txtFiltro.Visible = false;
                    btnBuscar.Visible = false;
                    btnEliminar.Visible = false;
                    lblFiltro.Visible = false;
                    usuarios = controler.ConsultarCitas("vista_servicios_pendientes");
                    if (usuarios != null) dtwDatos.DataSource = usuarios;
                }
                cmbSexo.Visible = false;
            }
        }

        public void ActividadesBtnBuscar()
        {
            if (menu.Equals("Empleado") || menu.Equals("Clientes"))
            {
                if (perfil == 2)
                {
                    if (cmbFiltro.SelectedIndex == 0)
                        usuarios = controler.ConsultarUsuarios("vista_datos_cliente", "ID_CLIENTE='" + txtFiltro.Text + "'");
                    if (cmbFiltro.SelectedIndex == 1)
                        usuarios = controler.ConsultarUsuarios("vista_datos_cliente", "NOMBRE='" + txtFiltro.Text + "'");
                    if (cmbFiltro.SelectedIndex == 2)
                        usuarios = controler.ConsultarUsuarios("vista_datos_cliente", "CORREO='" + txtFiltro.Text + "'");
                    if (cmbFiltro.SelectedIndex == 3)
                        usuarios = controler.ConsultarUsuarios("vista_datos_cliente", "SEXO = '" + sexo + "'");
                    if (cmbFiltro.SelectedIndex == 4)
                        usuarios = controler.ConsultarUsuarios("vista_datos_cliente");
                }
                if (perfil == 1)
                {
                    if (cmbFiltro.SelectedIndex == 0)
                        usuarios = controler.ConsultarUsuarios("vista_datos_empleados", "ID_EMPLEADO='" + txtFiltro.Text + "'");
                    if (cmbFiltro.SelectedIndex == 1)
                        usuarios = controler.ConsultarUsuarios("vista_datos_empleados", "NOMBRE='" + txtFiltro.Text + "'");
                    if (cmbFiltro.SelectedIndex == 2)
                        usuarios = controler.ConsultarUsuarios("vista_datos_empleados", "CORREO='" + txtFiltro.Text + "'");
                    if (cmbFiltro.SelectedIndex == 3)
                        usuarios = controler.ConsultarUsuarios("vista_datos_empleados", "SEXO = '" + sexo + "'");
                    if (cmbFiltro.SelectedIndex == 4)
                        usuarios = controler.ConsultarUsuarios("vista_datos_empleados");
                }
            }
            if (menu.Equals("Citas"))
            {
                if (cmbFiltro.SelectedIndex == 0)
                    usuarios = controler.ConsultarCitas("vista_citas_atendidas");
                if (cmbFiltro.SelectedIndex == 1)
                    usuarios = controler.ConsultarCitas("vista_citas_pendientes");
                if (cmbFiltro.SelectedIndex == 2)
                    usuarios = controler.ConsultarCitas("vista_citas_totales", "ID_CITA= '" + txtFiltro.Text + "'");
                if (cmbFiltro.SelectedIndex == 3)
                    usuarios = controler.ConsultarCitas("vista_citas_totales", "NOMBRE_CLIENTE= '" + txtFiltro.Text + "'");
            }
            if (usuarios != null) dtwDatos.DataSource = usuarios;
            else MessageBox.Show("DATO INVALIDO");
            btnBuscar.Enabled = false;
            txtFiltro.Enabled = false;
            txtFiltro.Text = "";
            cmbSexo.Enabled = false;
            cmbFiltro.Text = "FILTRO";
            cmbSexo.Text = "SEXO";
        }

        public void ActividadesCmbFiltro()
        {
            if (menu.Equals("Empleado") || menu.Equals("Clientes"))
            {
                if (cmbFiltro.SelectedIndex == 0 || cmbFiltro.SelectedIndex == 1 || cmbFiltro.SelectedIndex == 2)
                    txtFiltro.Enabled = true; cmbSexo.Enabled = false;
                if (cmbFiltro.SelectedIndex == 3)
                    cmbSexo.Enabled = true; txtFiltro.Enabled = false;
                if (cmbFiltro.SelectedIndex == 4) btnBuscar.Enabled = true;
            }
            if (menu.Equals("Citas"))
            {
                if (cmbFiltro.SelectedIndex == 0 || cmbFiltro.SelectedIndex == 1)
                    btnBuscar.Enabled = true;
                if (cmbFiltro.SelectedIndex == 2 || cmbFiltro.SelectedIndex == 3)
                    txtFiltro.Enabled = true;
            }
        }

        public void ActividadesDtwDatos()
        {
            if (menu.Equals("Empleado") || menu.Equals("Clientes"))
            {
                if (operacion.Equals("Eliminar"))
                {
                    btnEliminar.Enabled = true;
                }
                if (operacion.Equals("Editar"))
                {
                    nom = dtwDatos.CurrentRow.Cells[0].Value.ToString();
                    AltasUsuarios a = new AltasUsuarios(perfil, operacion, nom, menu);
                    a.Show();
                    this.Hide();
                }
            }
            if (menu.Equals("Citas"))
            {
                if (operacion.Equals("Editar"))
                {
                    nom = dtwDatos.CurrentRow.Cells[0].Value.ToString();
                    AltasCitas ac = new AltasCitas(operacion, nom);
                    ac.Show();
                    this.Hide();
                }
                if (operacion.Equals("Cancelar"))
                {
                    btnEliminar.Enabled = true;
                }
            }

            if (menu.Equals("Servicios"))
            {
                nom = dtwDatos.CurrentRow.Cells[0].Value.ToString();
                Servicio s = new Servicio(operacion,nom);
                s.Show();
                this.Hide();
            }
        }

        public void ActividadesBtnEliminar()
        {
            if (menu.Equals("Empleado") || menu.Equals("Clientes"))
            {
                if (perfil == 1)
                {
                    controler.EliminarUsuarios(dtwDatos.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Trabajador eliminado");
                    usuarios = controler.ConsultarUsuarios("vista_datos_empleados");
                }
                if (perfil == 2)
                {
                    controler.EliminarUsuarios(dtwDatos.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Cliente eliminado");
                    usuarios = controler.ConsultarUsuarios("vista_datos_cliente");
                }
                if (usuarios != null) dtwDatos.DataSource = usuarios;
            }
            if (menu.Equals("Citas"))
            {
                if (operacion.Equals("Cancelar"))
                {
                    controler.CancelarCita(dtwDatos.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Cita cancelada");
                    usuarios = controler.ConsultarCitas("vista_citas_pendientes");
                }
                if (usuarios != null) dtwDatos.DataSource = usuarios;
            }
            btnEliminar.Enabled = false;
        }
    } 
}
