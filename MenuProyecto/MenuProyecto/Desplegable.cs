using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MenuProyecto
{
    public partial class Desplegable : Form
    {
        public Desplegable()
        {
            InitializeComponent();
        }
        #region declaracion de variables
        SqlConexion con = new SqlConexion();

        string consultaSQLL;
        #endregion

        private void btnPedido_Click(object sender, EventArgs e)
        {
            consultaSQLL = null;
            consultaSQLL = "SELECT count(ID_PEDIDO)+1 FROM PEDIDO";
            ClaseCompartida.numeroDePedidos = con.EjecutarNSQL(consultaSQLL);

            // MessageBox.Show(" N se " + ClaseCompartida.numeroDePedidos + " ddd "+ClaseCompartida.idMenu, "Validacion  " + ClaseCompartida.clienteid, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            consultaSQLL = null;
            //consultaSQLL = "INSERT INTO PEDIDO(ID_PEDIDO, DESPACHADO, ID_MENU, ID_CLIENTE) VALUES ("+(ClaseCompartida.numeroDePedidos+1)+ ", 0, "+(ClaseCompartida.numeroDePedidos+1)+", "+ClaseCompartida.clienteid+");";
            consultaSQLL += "INSERT INTO PEDIDO(ID_PEDIDO, DESPACHADO, ID_MENU, ID_CLIENTE) VALUES ('";
            consultaSQLL += (ClaseCompartida.numeroDePedidos + 1) + "','0";
            consultaSQLL += "','";
            consultaSQLL += (ClaseCompartida.idMenu) + "','";
            consultaSQLL += ClaseCompartida.clienteid + "')";
            con.EjecutarSQL(consultaSQLL);

            if (MessageBox.Show("Se ha añadido el pedido! , Desea seguir comprando?", "Validacion  ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ClaseCompartida.bandera = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("GRACIAS POR SU COMPRA", "DESPEDIDA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ClaseCompartida.bandera = false;
                this.Close();
            }

        }
        public void mostrarImagen()
        {

            SqlCommand consultaSQL = new SqlCommand("SELECT FOTO FROM MENU WHERE ID_MENU = " + ClaseCompartida.idMenu + ";", con.conexion());
            SqlDataAdapter dp = new SqlDataAdapter(consultaSQL);
            DataSet ds = new DataSet("foto");
            byte[] bytes = new byte[0];
            dp.Fill(ds, "foto");
            DataRow myRiw = ds.Tables["foto"].Rows[0];
            bytes = (byte[])myRiw["foto"];
            MemoryStream ms = new MemoryStream(bytes);
            pbPlatillo.Image = Image.FromStream(ms);

        }
        public void Descripcion()
        {
            SqlCommand consultaSQL = new SqlCommand("SELECT DESC_MENU FROM MENU WHERE ID_MENU = " + ClaseCompartida.idMenu + ";", con.conexion());
            SqlDataReader registro = consultaSQL.ExecuteReader();
            if (registro.Read())
            {
                lblDescripcion.Text = registro["DESC_MENU"].ToString();
            }
        }
        public void Nombre()
        {
            SqlCommand consultaSQL = new SqlCommand("SELECT NOM_MENU FROM MENU WHERE ID_MENU =" + ClaseCompartida.idMenu + ";", con.conexion());
            SqlDataReader registro = consultaSQL.ExecuteReader();
            if (registro.Read())
            {
                lblNombrePlato.Text = registro["NOM_MENU"].ToString();
            }
        }

        private void Desplegable_Load(object sender, EventArgs e)
        {
            mostrarImagen();
            Descripcion();
            Nombre();
        }
    }
}

    

