using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s =
                System.Configuration.ConfigurationManager.ConnectionStrings["FarmaciaConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(s);
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Tipo_de_Usuario (Nombre) VALUES ('" +
                TextBox1.Text + "')", connection);
            cmd.ExecuteNonQuery();

            Label1.Text = "registro agregado";
        }
    }
}