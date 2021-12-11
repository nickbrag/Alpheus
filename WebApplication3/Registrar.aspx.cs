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
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registrar2_Click(object sender, EventArgs e)
        {
            int tipo = 1;
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection con = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("Registrar_Usuario", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = nombre.Text;
            cmd.Parameters.Add("@apellido_paterno", SqlDbType.VarChar, 50).Value = apellido.Text;
            cmd.Parameters.Add("@apellido_materno", SqlDbType.VarChar, 50).Value = apellido2.Text;
            cmd.Parameters.Add("@correo_usuario", SqlDbType.VarChar, 50).Value = correo.Text;
            cmd.Parameters.Add("@contraseña_usuario", SqlDbType.VarChar, 8).Value = contraseña.Text;
            cmd.Parameters.Add("@fecha_usuario", SqlDbType.Date).Value = Fecha.Text;
            cmd.Parameters.Add("@tipo_usuario", SqlDbType.Int).Value = tipo;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Error en el registro de usuario";
            }
            else
            {
                Response.Redirect("Menu.aspx");
                Label1.Text = "Usuario Registrado";
            }
            cmd.Connection.Close();
        }
    }
}