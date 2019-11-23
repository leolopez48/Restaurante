using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;



namespace Sql
{
 
        public static class ClaseCompartida
        {

            public static string mensaje = null;
            public static int idMenu;
            public static int numeroDePedidos;
            public static int clienteid;
            public static bool bandera = false;



            // otras variables estáticas
        }
    public class SqlConexion
    {
        //METODO PARA ESTABLECER CONEXION A LA BASE
        public SqlConnection conexion()
        {
            //Establecer credenciales de conexion
            SqlConnection conn = new SqlConnection(
                Properties.Settings.Default.conexion);
            //Aperturar conexion
            conn.Open();
            //retornar estado de conexion
            return conn;
        }//Fin de conexion

        //METODO PARA EJECUTAR SENTENCIAS SQL
        public int EjecutarSQL(string sql)
        {
            int resultado = 0;
            try
            {
                //Preparar sentencia sql a ejecutar
                SqlCommand Ejecutar = new SqlCommand(sql, conexion());
                //Ejecute la operacion
                resultado = Ejecutar.ExecuteNonQuery();
                //Cerrar conexion
                conexion().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha producido un error: " + e.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = 0;
            }
            return resultado;
        }//Fin de EjecutarSQL
        public int EjecutarNSQL(string sql)
        {
            int resultado = 0;
            try
            {
                //Preparar sentencia sql a ejecutar
                SqlCommand Ejecutar = new SqlCommand(sql, conexion());
                //Ejecute la operacion
                resultado = int.Parse(Ejecutar.ExecuteScalar().ToString());
                //Cerrar conexion
                conexion().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha producido un error: " + e.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = 0;
            }
            return resultado;
        }

        //METODO PARA LLENAR DATAGRIDVIEW
        public void LlenarGrid(string sql, DataGridView grid)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion());
            DataTable dt = new DataTable();

            //Llenar el datatable
            da.Fill(dt);
            //Asignar el nuevo origen de datos al datagridview
            grid.DataSource = dt;
            //Cerrar la conexion
            conexion().Close();
        }//Fin de LlenarGrid

        //METODO PARA LLENAR COMBOBOX
        public void LlenarCombo(
            string sql, string valor, string descripcion, ComboBox combo)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            combo.DataSource = null;
            combo.Items.Clear();

            combo.DataSource = dt;
            combo.DisplayMember = descripcion;
            combo.ValueMember = valor;
            combo.Refresh();
        }//Fin de LlenarCombo

        //METODO PARA OCULTAR COLUMNAS EN DATAGRIDVIEW
        public void ocultarColumna(DataGridView grid, string columnas)
        {
            string[] txt = columnas.Split(',');
            if (grid.RowCount > 0)
                for (int i = 0; i < txt.Length; i++)
                    grid.Columns[(txt[i].Trim())].Visible = false;
        }//Fin de ocultarColumna
    }//Fin de SqlConexion



}
