using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sql;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace MenuProyecto
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }
        SqlConexion con = new SqlConexion();
        int datos;
        Button btn = new Button();
        string consultaSQL = null;
        int[] idmenuBase = new int[200];


        public void CrearBotones()
        {
            consultaSQL = "  SELECT count(ID_MENU) FROM MENU ";
            datos = con.EjecutarNSQL(consultaSQL);


            for (int i = 1; i <= datos; i++)
            {
                consultaSQL = null;
                consultaSQL = " Select  ID_MENU from MENU where ID_MENU= " + i;
                idmenuBase[i] = con.EjecutarNSQL(consultaSQL);
            }




            int x = 5, y = 5;
            for (int i = 1; i <= datos; i++)
            {

                Button btn = new Button();



                btn.Height = 200;
                btn.Width = 200;
                btn.Location = new Point(x, y); //Posicion
                y = y + 150;
                //Acomodado de botones
                if (y > 700) //Si hay 3 botones en la misma linea aumentamos la posicion X para crear otra linea al lado y no salirnos de la pantalla
                {
                    y = 10;
                    x = x + 150;
                }
                btn.Name = "c" + i.ToString();
                btn.Text = idmenuBase[i].ToString();


                SqlCommand consultaSQL = new SqlCommand("SELECT FOTO FROM MENU WHERE ID_MENU = " + i + ";", con.conexion());
                SqlDataAdapter dp = new SqlDataAdapter(consultaSQL);
                DataSet ds = new DataSet("foto");
                byte[] bytes = new byte[0];
                dp.Fill(ds, "foto");
                DataRow myRiw = ds.Tables["foto"].Rows[0];
                bytes = (byte[])myRiw["foto"];
                MemoryStream ms = new MemoryStream(bytes);
                //Para hacer stretch la imagen del boton 
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackgroundImage = Image.FromStream(ms);
                //btn.Image = Image.FromStream(ms);

                btn.Click += new EventHandler(button_Click);
                flowLayoutPanel1.Controls.Add(btn);


            }





        }


        public void button_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Button button = sender as Button;
                //Dando valor a ID_CLIENTE y asignandolo a la variable clienteid
                consultaSQL = null;
                // si bandera es igual false significa que es un cliente diferente si no es el mismo cliente.
                if (ClaseCompartida.bandera == false)
                {
                    consultaSQL = null;
                    consultaSQL = "SELECT count(ID_CLIENTE)+1 FROM CLIENTE";
                    ClaseCompartida.clienteid = con.EjecutarNSQL(consultaSQL);

                    //Insertando lo que hay en el txtnombre y lo que tiene clinteid
                    consultaSQL = null;
                    consultaSQL = "INSERT INTO CLIENTE(ID_CLIENTE, NOM_CLIENTE) VALUES(" + ClaseCompartida.clienteid + ", '" + txtNombre.Text + "')";
                    con.EjecutarSQL(consultaSQL);
                }
                else
                {
                    //MessageBox.Show("mismo cliente", "", MessageBoxButtons.OK);
                    consultaSQL = null;
                    consultaSQL = "SELECT count(ID_CLIENTE) FROM CLIENTE";
                    ClaseCompartida.clienteid = con.EjecutarNSQL(consultaSQL);
                }
                ClaseCompartida.idMenu = 0;
                ClaseCompartida.idMenu = int.Parse(button.Text);
                // mensajes prueba
                //ClaseCompartida.mensaje = "Se ha seleccionado el boton " + button.Name + " que tiene el id_menu " + button.Text;
                // MessageBox.Show("encontrado" + button.Name + " y text" + button.Text, " ?aaaaaa ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                epError.Clear();
                Desplegable frm = new Desplegable();
                frm.Show();
            }


        }

            
        public bool Validar()
        {
            bool estado = true;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                epError.SetError(txtNombre, "Valor requerido");
                estado = false;
            }
            return estado;
        }

        private void fmrMenu_Load(object sender, EventArgs e)
        {
            CrearBotones();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            CrearBotones();
            int mover = flowLayoutPanel1.VerticalScroll.Value - flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, mover);
        }

        private void btnFinal_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            CrearBotones();
            int mover = flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, mover);
        }
    }
}


