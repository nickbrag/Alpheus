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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void boton_ingresar_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection con = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("Iniciar_Sesion", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = Usuario.Text;
            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 8).Value = contraseña.Text;
            SqlDataReader dr=cmd.ExecuteReader();

        
        }
    }
}