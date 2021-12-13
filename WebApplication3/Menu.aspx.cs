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
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UsuarioLogin"]!=null)
            {
                String UsuarioLogin = Session["UsuarioLogin"].ToString();
                //Inciar.Text = UsuarioLogin;

                string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conectar);

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Apellido_Paterno, Apellido_Materno, Fecha_de_Nacimiento FROM Usuarios WHERE Correo= '" + UsuarioLogin + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    Inciar.Text = dr["Nombre"].ToString();
                }
                con.Close();
            }
        }

        protected void Inicio_Click(object sender, EventArgs e)
        {
            
        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {

        }

        protected void Carrito_Click(object sender, EventArgs e)
        {

        }

        protected void Medicamentos_Click(object sender, EventArgs e)
        {

        }

        protected void Equipo_Click(object sender, EventArgs e)
        {

        }

        protected void Salud_Click(object sender, EventArgs e)
        {

        }

        protected void Vitaminas_Click(object sender, EventArgs e)
        {

        }

        protected void Cuidado_Click(object sender, EventArgs e)
        {

        }

        protected void Sexual_Click(object sender, EventArgs e)
        {

        }

        protected void Bebes_Click(object sender, EventArgs e)
        {

        }

        protected void Actualizar_Metodo_Click(object sender, EventArgs e)
        {

        }

        protected void Inciar_Click(object sender, EventArgs e)
        {
            if (Session["UsuarioLogin"] != null)
            {
                Response.Redirect("Juanreturn.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }
    }
}