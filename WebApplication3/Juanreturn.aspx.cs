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
        Boolean bandera = false;
        

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

        protected void Buscar_Metodo_Click(object sender, EventArgs e)
        {
            String UsuarioLogin = Session["UsuarioLogin"].ToString();
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection con = new SqlConnection(conectar);

            con.Open();

            SqlCommand cmd = new SqlCommand("DECLARE @metodo int SET @metodo = (SELECT id_Paypal FROM Usuarios WHERE Correo = '" + UsuarioLogin + "'); SELECT Correo, Contraseña FROM Paypal WHERE ID = @metodo", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Correo.Text = dr["Correo"].ToString();
                Contraseña.Text = dr["Contraseña"].ToString();

                bandera = true;
            }
            else
            {
                Error_Metodo.Text = "No se ha registrado metodo.";
            }

        }

        protected void Actualizar_Metodo_Click(object sender, EventArgs e)
        {
            
            if (bandera == true)
            {
                if (Correo.Text == " " || Contraseña.Text == " " || Contraseña2.Text == "")
                {
                    Error_Direccion.Text = "Algún campo no se lleno correctamente";
                }
                else
                { 
                    if (Contraseña.Text == Contraseña2.Text)
                    {
                        String UsuarioLogin = Session["UsuarioLogin"].ToString();
                        string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                        SqlConnection con = new SqlConnection(conectar);


                        SqlCommand cmd = new SqlCommand("Insertar_Metodo", con) { CommandType = CommandType.StoredProcedure };
                        con.Open();
                        cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = Correo.Text;
                        cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50).Value = Contraseña.Text;
                        cmd.Parameters.Add("@Correo_Usuario", SqlDbType.VarChar, 50).Value = UsuarioLogin;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Error_Metodo.Text = "Error en el registro";
                        }
                        else
                        {
                            Error_Metodo.Text = "Metodo Registrado";
                            Correo.Text = "";
                            Contraseña.Text = "";
                            Contraseña2.Text = "";
                            con.Close();
                        }
                    }
                    else
                    {
                        Error_Metodo.Text = "Contraseñas no Coinciden";
                    }
                    
                }
            }
            else
            {
                if (Correo.Text == " " || Contraseña.Text == " " || Contraseña2.Text == "")
                {
                    Error_Metodo.Text = "Algún campo no se lleno correctamente";
                }
                else
                {
                    String UsuarioLogin = Session["UsuarioLogin"].ToString();
                    string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                    SqlConnection con = new SqlConnection(conectar);
                    SqlCommand cmd = new SqlCommand("Insertar_Metodo", con) { CommandType = CommandType.StoredProcedure };
                    con.Open();
                    cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = Correo.Text;
                    cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50).Value = Contraseña.Text;
                    cmd.Parameters.Add("@Correo_Usuario", SqlDbType.VarChar, 50).Value = UsuarioLogin;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Error_Metodo.Text = "Error en el registro";
                    }
                    else
                    {
                        Error_Metodo.Text = "Metodo Registrado";
                        Correo.Text = "";
                        Contraseña.Text = "";
                        Contraseña2.Text = "";
                        con.Close();
                    }
                }
            }
        }

        protected void Inciar_Click(object sender, EventArgs e)
        {

        }

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("UsuarioLogin");
            Response.Redirect("Menu.aspx");
        }

        protected void BuscarDireccion_Click(object sender, EventArgs e)
        {
            String UsuarioLogin = Session["UsuarioLogin"].ToString();
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection con = new SqlConnection(conectar);

            con.Open();

            SqlCommand cmd = new SqlCommand("DECLARE @domicilio int SET @domicilio = (SELECT id_Domicilio FROM Usuarios WHERE Correo = '" + UsuarioLogin + "'); SELECT Calle, Num_Ext, Num_Int, CP, Municipio, Estado FROM Domicilio WHERE ID = @domicilio", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                Calle.Text = dr["Calle"].ToString();
                Num_Exterior.Text = dr["Num_Ext"].ToString();
                Num_Interior.Text = dr["Num_Int"].ToString();
                CP.Text = dr["CP"].ToString();
                Municipio.Text = dr["Municipio"].ToString();
                Estado.Text = dr["Estado"].ToString();

                bandera = true;
            }
            else
            {
                Error_Direccion.Text = "No se ha registrado domicilio.";
            }

            
        }

        protected void Actualizar_Direccion_Click(object sender, EventArgs e)
        {
            String UsuarioLogin = Session["UsuarioLogin"].ToString();
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection con = new SqlConnection(conectar);

            con.Open();
            if (bandera == true)
            {
                if (Calle.Text == "" || Num_Exterior.Text == "" || CP.Text == "" || Municipio.Text == "" || Estado.Text == "")
                {
                    Error_Direccion.Text = "Algún campo no se lleno correctamente";
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Actualizar_Domicilio", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add("@Correo_Usuario", SqlDbType.VarChar, 50).Value = UsuarioLogin;
                    cmd.Parameters.Add("@Calle", SqlDbType.VarChar, 8).Value = Calle.Text;
                    cmd.Parameters.Add("@Num_Exterior", SqlDbType.VarChar, 4).Value = Num_Exterior.Text;
                    cmd.Parameters.Add("@Num_Int", SqlDbType.VarChar, 4).Value = Num_Interior.Text;
                    cmd.Parameters.Add("@CP", SqlDbType.VarChar, 5).Value = CP.Text;
                    cmd.Parameters.Add("@Municipio", SqlDbType.VarChar, 50).Value = Municipio.Text;
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar, 50).Value = Estado.Text;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Error_Direccion.Text = "Error en la Actualización";
                    }
                    else
                    {
                        Error_Direccion.Text = "Actualización Realizada";
                        Calle.Text = " ";
                        Num_Exterior.Text = " ";
                        Num_Interior.Text = " ";
                        CP.Text = " ";
                        Municipio.Text = "";
                        Estado.Text = " ";
                        bandera = false;
                    }
                    con.Close();
                }
            }
            else
            {
                if (Calle.Text == "" || Num_Exterior.Text == "" || CP.Text == "" || Municipio.Text == "" || Estado.Text == "")
                {
                    Error_Direccion.Text = "Algún campo no se lleno correctamente";
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insertar_Domicilio", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add("@Calle", SqlDbType.VarChar, 8).Value = Calle.Text;
                    cmd.Parameters.Add("@Num_Exterior", SqlDbType.VarChar, 4).Value = Num_Exterior.Text;
                    cmd.Parameters.Add("@Num_Int", SqlDbType.VarChar, 4).Value = Num_Interior.Text;
                    cmd.Parameters.Add("@CP", SqlDbType.VarChar, 5).Value = CP.Text;
                    cmd.Parameters.Add("@Municipio", SqlDbType.VarChar, 50).Value = Municipio.Text;
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar, 50).Value = Estado.Text;
                    cmd.Parameters.Add("@correo_usuario", SqlDbType.VarChar, 50).Value = UsuarioLogin;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Error_Direccion.Text = "Error en el registro";
                    }
                    else
                    {
                        Error_Direccion.Text = "Domicilio Registrado";
                        Calle.Text = " ";
                        Num_Exterior.Text = " ";
                        Num_Interior.Text = " ";
                        CP.Text = " ";
                        Municipio.Text = "";
                        Estado.Text = " ";
                    }
                    con.Close();
                }
            }
        }
    }
}