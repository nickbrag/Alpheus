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
    public partial class Juanreturn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioLogin"] != null)
            {
                String UsuarioLogin = Session["UsuarioLogin"].ToString();
                //Inciar.Text = UsuarioLogin;

                string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conectar);

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Apellido_Paterno, Apellido_Materno, Fecha_de_Nacimiento FROM Usuarios WHERE Correo= '" + UsuarioLogin+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read()==true)
                {
                    Inciar.Text = dr["Nombre"].ToString();
                    Nombre.Text = dr["Nombre"].ToString();
                    Apellido1.Text = dr["Apellido_Paterno"].ToString();
                    Apellido2.Text = dr["Apellido_Materno"].ToString();
                    Fecha.Text = dr["Fecha_de_Nacimiento"].ToString();
                }
                con.Close();
            }
            else
            {
                Response.Redirect("Menu.aspx");
            }
        }

        protected void Inicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
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

        }

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("UsuarioLogin");
            Response.Redirect("Menu.aspx");
        }

        protected void Actualizar_Direccion_Click(object sender, EventArgs e)
        {
            if (Session["UsuarioLogin"] != null)
            {
                Boolean bandera = false;
                String UsuarioLogin = Session["UsuarioLogin"].ToString();
                //Inciar.Text = UsuarioLogin;

                string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conectar);

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_Domicilio FROM Usuarios WHERE Correo= '" + UsuarioLogin + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read() == true)
                {
                    String Domicilio = dr["id_Domicilio"].ToString();
                    dr.Close();
                    cmd = new SqlCommand("SELECT Calle, Num_Ext, Num_Int, CP, Municipio, Estado FROM Domicilio WHERE='"+Domicilio+"'", con);
                    SqlDataReader dr2 = cmd.ExecuteReader();
                    if (dr2.Read() == true)
                    {
                        Calle.Text = dr2["Calle"].ToString();
                        Num_Exterior.Text = dr2["Num_Ext"].ToString();
                        Num_Interior.Text = dr2["Num_Int"].ToString();
                        CP.Text = dr2["CP"].ToString();
                        Municipio.Text = dr2["Municipio"].ToString();
                        Estado.Text = dr2["Estado"].ToString();
                    }
                }
                else
                {
                    Error_Direccion.Text = "No se ha definido una dirección";
                }
                con.Close();
            }
            else
            {
                Response.Redirect("Menu.aspx");
            }
        }
    }
}