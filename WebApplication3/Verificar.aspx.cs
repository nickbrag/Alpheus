using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Threading;


namespace WebApplication3
{
    public partial class Verificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String UsuarioLogin = Session["UsuarioLogin"].ToString();

            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection con = new SqlConnection(conectar);

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_Tipo_de_usuario FROM Usuarios WHERE Correo='" + UsuarioLogin + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                Usuario.Text = UsuarioLogin;

                String tipo = dr["id_Tipo_de_usuario"].ToString();

                if (tipo.Equals("2"))
                {
                    Response.Redirect("Administrador.aspx");
                }
                else if(tipo.Equals("1"))
                {
                    Response.Redirect("Menu.aspx");
                }
            }
        }
    }
}