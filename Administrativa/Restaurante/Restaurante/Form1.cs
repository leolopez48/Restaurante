using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.IO;
using System.Data.SqlClient;
using Sql;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region DECLARACION DE VARIABLES
        SqlConexion con = new SqlConexion();
        bool Agregando = false, Editando = false, abierto = false;
        string destino= null;
        string consultaSQL = null;
        int datos;
        #endregion
        #region METODOS PERSONALIZADOS

        public void LlenarComboBox()
        {
            cmbPedidos.Items.Add("Sin entregar");
            cmbPedidos.Items.Add("Entregados");
            cmbPedidos.SelectedIndex = 0;
        }

        public void mostrarPedidos()
        {
            consultaSQL = null;
            consultaSQL = ("SELECT P.ID_PEDIDO, P.ID_MENU, C.NOM_CLIENTE, M.NOM_MENU, M.DESC_MENU, M.PRECIO, M.FOTO, P.ID_CLIENTE, DESPACHADO FROM PEDIDO P INNER JOIN MENU M ON M.ID_MENU = P.ID_MENU INNER JOIN CLIENTE C ON C.ID_CLIENTE = P.ID_CLIENTE WHERE P.DESPACHADO = "+cmbPedidos.SelectedIndex+";");
            con.LlenarGrid(consultaSQL, dgvPedidos);
        }

        void HabilitarObjetos(bool estado = false)
        {
            txtNombres.Enabled = estado;
            txtDescripcion.Enabled = estado;
            txtDireccion.Enabled = estado;
            txtPedido.Enabled = estado;
            txtNombreMenu.Enabled = estado;
            txtIdCliente.Enabled = estado;
            btnEntregar.Enabled = estado;
            txtPrecioPedido.Enabled = estado;
        }

        void LimpiarObjetos()
        {
            txtNombres.Clear();
            txtDescripcion.Clear();
            txtDireccion.Clear();
            txtPedido.Clear();
            txtNombreMenu.Clear();
            btnEntregar.Enabled = false;
            pictureBox1.Image = null;
            txtIdCliente.Clear();
            txtIdMenu.Clear();
            txtNomMenu.Clear();
            txtDescMenu.Clear();
            txtPrecio.Clear();
            btnExaminar.Enabled = false;
            epError.Clear();
            pbMenu.Image = null;
        }

        #endregion

        #region METODOS GENERADOS

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            HabilitarObjetos(true);
            txtNombres.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cancelar?",
                "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HabilitarObjetos();
                LimpiarObjetos();
                epError.Clear();
            }
        }

        private void DgvPedidos_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.RowCount > 0)
            {
                btnEntregar.Enabled = true;
                txtPedido.Text = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["ID_PEDIDO"].Value.ToString();
                txtIdCliente.Text = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["ID_CLIENTE"].Value.ToString();
                txtNombres.Text = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["NOM_CLIENTE"].Value.ToString();
                txtNombreMenu.Text = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["NOM_MENU"].Value.ToString();
                txtDescripcion.Text = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["DESC_MENU"].Value.ToString();
                txtPrecioPedido.Text = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["PRECIO"].Value.ToString();
                if ((int)dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["DESPACHADO"].Value == 0)
                {
                    txtDireccion.Text = "Sin entregar";
                }else
                {
                    txtDireccion.Text = "Entregado";
                }
                mostrarImagen();
            }
            
        }

        public void mostrarImagen()
        {
            SqlCommand consultaSQL = new SqlCommand("SELECT FOTO FROM MENU WHERE ID_MENU = " + dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["ID_MENU"].Value.ToString(), con.conexion());
            SqlDataAdapter dp = new SqlDataAdapter(consultaSQL);
            DataSet ds = new DataSet("foto");
            byte[] bytes = new byte[0];
            dp.Fill(ds, "foto");
            DataRow myRiw = ds.Tables["foto"].Rows[0];
            bytes = (byte[])myRiw["foto"];
            MemoryStream ms = new MemoryStream(bytes);
            pictureBox1.Image = Image.FromStream(ms);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.RowCount > 0)
            {
                if ((int)dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["DESPACHADO"].Value == 0)
                {
                    if (MessageBox.Show("Desea entregar el pedido?", "Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        consultaSQL = null;
                        consultaSQL = "UPDATE PEDIDO SET DESPACHADO = 1 WHERE ID_PEDIDO = " + txtPedido.Text+ ";";
                        con.EjecutarSQL(consultaSQL);
                        
                        MessageBox.Show("Su pedido ha sido entregado. ", "Entregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (MessageBox.Show("Desea cancelar la entrega de este pedido?", "Cancelar entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        consultaSQL = null;
                        consultaSQL = "UPDATE PEDIDO SET DESPACHADO = 0 WHERE ID_PEDIDO = " + txtPedido.Text + ";";
                        con.EjecutarSQL(consultaSQL);
                        MessageBox.Show("Se ha cancelado la entrega.", "Entregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                mostrarImagen();

            }
            mostrarPedidos();
            LimpiarObjetos();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            HabilitarObjetos(false);
            mostrarPedidos();
            con.ocultarColumna(dgvPedidos, "FOTO, DESPACHADO");
            mostrarMenu();
            con.ocultarColumna(dgvMenu, "ID_MENU, FOTO, URL");
            dgvPedidos.Columns["ID_MENU"].HeaderText = "No. Menu";
            dgvPedidos.Columns["ID_CLIENTE"].HeaderText = "No. Cliente";
            dgvPedidos.Columns["NOM_CLIENTE"].HeaderText = "Cliente";
            dgvPedidos.Columns["ID_PEDIDO"].HeaderText = "No. Pedido";
            dgvPedidos.Columns["NOM_MENU"].HeaderText = "Platillo";
            dgvPedidos.Columns["DESC_MENU"].HeaderText = "Descripcion";
            txtIdMenu.Enabled = false;
            HabilitarObjetosMenu(false);
            ControlBarra();
            dgvMenu.Columns["NOM_MENU"].HeaderText = "Nombre";
            dgvMenu.Columns["DESC_MENU"].HeaderText = "Descripión";
            //rptRestaurantes1.SetParameterValue("parametro", 1);
        }

        public void mostrarMenu()
        {
            consultaSQL = null;
            consultaSQL = ("SELECT * FROM MENU;");
            con.LlenarGrid(consultaSQL, dgvMenu);
        }

        private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarPedidos();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvMenu.RowCount > 0)
            {
                if (MessageBox.Show("Desea eliminar el registro?",
                    "Pregunta", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Remover fila actual
                    consultaSQL = null;
                    consultaSQL = "DELETE FROM MENU WHERE ID_MENU = " + txtIdMenu.Text;
                    if (con.EjecutarSQL(consultaSQL) > 0)
                    {
                        LimpiarObjetos();
                        ControlBarra();
                        //Mensaje de confirmacion
                        MessageBox.Show("Registro eliminado correctamente",
                            "Confirmacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        mostrarMenu();
                    }
                    else
                    {
                        //Mensaje de confirmacion
                        MessageBox.Show("No se han encontrado registros para eliminar",
                            "Confirmacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string dir = dialog.FileName;
                destino = Path.GetFullPath(dir);
                abierto = true;
                pbMenu.Image = Image.FromFile(dialog.FileName);
            }
        }

        bool ValidarFormulario()
        {
            bool estado = true;
            //Nombre
            if (string.IsNullOrEmpty(txtDescMenu.Text))
            {
                epError.SetError(txtDescMenu, "Valor requerido");
                estado = false;
            }

            if (string.IsNullOrEmpty(txtNomMenu.Text))
            {
                epError.SetError(txtNomMenu, "Valor requerido");
                estado = false;
            }

            return estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = null;
            if (ValidarFormulario())
            {
                consultaSQL = "SELECT COUNT(ID_MENU) FROM MENU;";
                datos = con.EjecutarNSQL(consultaSQL);
                if (Agregando)
                {
                    //Preparar consulta INSERT
                    consultaSQL = null;
                    consultaSQL = "INSERT INTO MENU (ID_MENU, NOM_MENU, DESC_MENU, URL, PRECIO, FOTO) SELECT "+(datos+=1)+",'" + txtNomMenu.Text + "', '" + txtDescMenu.Text+"', '"+destino+"', " + txtPrecio.Text + ", "+" BulkColumn  FROM Openrowset(Bulk '" +destino+"', Single_Blob) as Imagen;";
                    mensaje = "Registro almacenado conrrectamente";
                }
                else
                {
                    if (abierto == false)
                    {
                        destino = dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells["URL"].Value.ToString();
                    }
                    consultaSQL = null;
                    consultaSQL = "UPDATE MENU SET ID_MENU = "+txtIdMenu.Text+ ", NOM_MENU = '"+txtNomMenu.Text+"', DESC_MENU = '"+ txtDescMenu.Text + "', URL ='"+destino+"', "+"PRECIO="+txtPrecio.Text+" , FOTO = BulkColumn  FROM Openrowset(Bulk '"+destino+"', Single_Blob) as Imagen WHERE ID_MENU = "+ dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells["ID_MENU"].Value + ";";
                    mensaje = "Registro actualizado correctamente";

                }

                //Ejecutar consulta resultante
                if (con.EjecutarSQL(consultaSQL) > 0)
                {
                    MessageBox.Show(mensaje, "Validacion de formulario",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiarObjetos();
                mostrarMenu();
                HabilitarObjetos(false);
                Agregando = false;
                Editando = false;
                ControlBarra();
                HabilitarObjetosMenu(false);
            }
        }
        public void mostrarImagenMenu()
        {
            SqlCommand consultaSQL = new SqlCommand("SELECT FOTO FROM MENU WHERE ID_MENU = " + dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells["ID_MENU"].Value.ToString(), con.conexion());
            SqlDataAdapter dp = new SqlDataAdapter(consultaSQL);
            DataSet ds = new DataSet("foto");
            byte[] bytes = new byte[0];
            dp.Fill(ds, "foto");
            DataRow myRiw = ds.Tables["foto"].Rows[0];
            bytes = (byte[])myRiw["foto"];
            MemoryStream ms = new MemoryStream(bytes);
            pbMenu.Image = Image.FromStream(ms);
        }

        private void dgvMenu_Click(object sender, EventArgs e)
        {
            if (dgvMenu.RowCount > 0)
            {
                txtIdMenu.Text = dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells["ID_MENU"].Value.ToString();
                txtNomMenu.Text = dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells["NOM_MENU"].Value.ToString();
                txtDescMenu.Text = dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells["DESC_MENU"].Value.ToString();
                txtPrecio.Text = dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells["PRECIO"].Value.ToString();
                mostrarImagenMenu();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            HabilitarObjetosMenu(true);
            Agregando = false; Editando = true;
            ControlBarra();
            txtNombres.Focus();
        }

        public void HabilitarObjetosMenu(bool estado)
        {
            txtIdMenu.Enabled = false;
            txtNomMenu.Enabled = estado;
            txtDescMenu.Enabled = estado;
            btnExaminar.Enabled = estado;
            txtPrecio.Enabled = estado;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cancelar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HabilitarObjetosMenu(false);
                LimpiarObjetos();
                Agregando = false;
                Editando = false;
                ControlBarra();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HabilitarObjetosMenu(true);
            LimpiarObjetos();
            Agregando = true; Editando = false;
            ControlBarra();
            txtNomMenu.Focus();
            btnExaminar.Enabled = true;
        }

        void ControlBarra()
        {
            if (dgvMenu.RowCount == 0)
            {
                btnAgregar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }

            if (Agregando || Editando)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }
    }
}
