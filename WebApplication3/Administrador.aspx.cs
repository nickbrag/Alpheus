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
   

    public partial class WebForm1 : System.Web.UI.Page
    {
        Boolean bandera = false;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("UsuarioLogin");
            Response.Redirect("Menu.aspx");
        }

        protected void Agregar_Medicamento_Click(object sender, EventArgs e)
        {
            if(Categoria.Text != "" || Nombre_Medicamento.Text != "" || Descripcion_Medicamento.Text != "" || TextBox1.Text != "")
            {
                //String UsuarioLogin = Session["UsuarioLogin"].ToString();
                string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conectar);


                SqlCommand cmd = new SqlCommand("Registrar_Producto", con) { CommandType = CommandType.StoredProcedure };
                con.Open();
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar, 50).Value = Categoria.Text;
                cmd.Parameters.Add("@nombre_producto", SqlDbType.VarChar, 50).Value = Nombre_Medicamento.Text;
                cmd.Parameters.Add("@descripcion_producto", SqlDbType.VarChar, 50).Value = Descripcion_Medicamento.Text;
                cmd.Parameters.Add("@precio_producto", SqlDbType.Decimal).Value = TextBox1.Text;
                SqlDataReader dt=cmd.ExecuteReader();
                if(dt.Read())
                {
                    Error_Medicamentos.Text = "Error";
                    con.Close();
                }
                else
                {
                    Error_Medicamentos.Text = "Medicamento registrado";
                    con.Close();
                }

                //Error_Medicamentos.Text = "Medicamento registrado";
            }
            else
            {
                Error_Medicamentos.Text = "No se ha llenado un campo correctamente.";
            }
        }

        protected void Agregar_Categoria_Click(object sender, EventArgs e)
        {
            if(Nombre_Categoría.Text == "" || Actividad.Text == "")
            {
                Error_Categorias.Text = "Un campo no se llenó completamente";
            }
            else
            {
                string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection con = new SqlConnection(conectar);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Categorias([Nombre], [Act. Terapeutica]) VALUES ('" +Nombre_Categoría.Text+"', '"+Actividad.Text+"')", con);
                cmd.ExecuteNonQuery();
                Error_Categorias.Text = "Registro completo";
            }
        }

        protected void Agregar_Empleado_Click(object sender, EventArgs e)
        {
            if (Nombre_Empleado.Text != " " && Apellido.Text != " " && Apellido2.Text != " " && correo.Text != " " && contraseña.Text != " " && contraseña2.Text != " " && Fecha.Text != " ")
            {
                if (contraseña.Text == contraseña2.Text)
                {
                    int tipo = 2;
                    string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                    SqlConnection con = new SqlConnection(conectar);
                    SqlCommand cmd = new SqlCommand("Registrar_Usuario", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Connection.Open();
                    cmd.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = Nombre_Empleado.Text;
                    cmd.Parameters.Add("@apellido_paterno", SqlDbType.VarChar, 50).Value = Apellido.Text;
                    cmd.Parameters.Add("@apellido_materno", SqlDbType.VarChar, 50).Value = Apellido2.Text;
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
                        Label1.Text = "Usuario Registrado";
                    }
                    cmd.Connection.Close();
                }
                else
                {
                    Label1.Text = "Contraseñas no coinciden.";
                }
            }
            else
            {
                Label1.Text = "Alguno de los campos no está lleno.";
            }
        }

        protected void Agregar_Empleados_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection con = new SqlConnection(conectar);

            con.Open();
            if (bandera == true)
            {
                if (Calle.Text == "" || Num_Ext.Text == "" || CP.Text == "" || Municipio.Text == "" || Estado.Text == "")
                {
                    Error_Direccion.Text = "Algún campo no se lleno correctamente";
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Actualizar_Domicilio", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add("@Correo_Usuario", SqlDbType.VarChar, 50).Value = Correo_Buscar.Text;
                    cmd.Parameters.Add("@Calle", SqlDbType.VarChar, 8).Value = Calle.Text;
                    cmd.Parameters.Add("@Num_Exterior", SqlDbType.VarChar, 4).Value = Num_Ext.Text;
                    cmd.Parameters.Add("@Num_Int", SqlDbType.VarChar, 4).Value = Num_Int.Text;
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
                        Num_Ext.Text = " ";
                        Num_Int.Text = " ";
                        CP.Text = " ";
                        Municipio.Text = "";
                        Estado.Text = " ";
                        //bandera = false;
                    }
                    con.Close();
                }
            }
            else
            {
                if (Correo_Buscar.Text == "" || Calle.Text == "" || Num_Ext.Text == "" || CP.Text == "" || Municipio.Text == "" || Estado.Text == "")
                {
                    Error_Direccion.Text = "Algún campo no se lleno correctamente";
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insertar_Domicilio", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add("@Calle", SqlDbType.VarChar, 8).Value = Calle.Text;
                    cmd.Parameters.Add("@Num_Exterior", SqlDbType.VarChar, 4).Value = Num_Ext.Text;
                    cmd.Parameters.Add("@Num_Int", SqlDbType.VarChar, 4).Value = Num_Int.Text;
                    cmd.Parameters.Add("@CP", SqlDbType.VarChar, 5).Value = CP.Text;
                    cmd.Parameters.Add("@Municipio", SqlDbType.VarChar, 50).Value = Municipio.Text;
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar, 50).Value = Estado.Text;
                    cmd.Parameters.Add("@correo_usuario", SqlDbType.VarChar, 50).Value = Correo_Buscar.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Error_Direccion.Text = "Error en el registro";
                    }
                    else
                    {
                        Error_Direccion.Text = "Domicilio Registrado";
                        Correo_Buscar.Text = "";
                        Calle.Text = " ";
                        Num_Ext.Text = " ";
                        Num_Int.Text = " ";
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