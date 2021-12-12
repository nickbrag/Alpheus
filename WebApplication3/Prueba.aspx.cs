using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public partial class Prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //String UsuarioLogin = Session["UsuarioLogin"].ToString();
            //Inciar.Text = UsuarioLogin;
            

        }

        protected void Inciar_Click(object sender, EventArgs e)
        {

        }

        protected void Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Carrito_Click(object sender, EventArgs e)
        {

        }

        protected void Cargar_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection con = new SqlConnection(conectar);

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Medicamentos WHERE id_Categoria= 36", con);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            Producto.DataSource = dt;
            Producto.DataBind();
            con.Close();
        }
    }
}