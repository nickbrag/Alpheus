<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <body>
        <div class="Medicamentos">
            <br>
            <label>Agregar Medicamentos</label>
            <br>
            <br>
            <label>Categoría:* </label>
            <asp:DropDownList ID="Categoria" runat="server" DataSourceID="Administrador" DataTextField="Nombre" DataValueField="Nombre"></asp:DropDownList>
            <asp:SqlDataSource ID="Administrador" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [Nombre] FROM [Categorias]"></asp:SqlDataSource>
            <br>
            <br>
            <label>Nombre:* </label><asp:TextBox ID="Nombre_Medicamento" runat="server" Text="" />
            <br>
            <br>
            <label>Descripción: </label> <asp:TextBox ID="Descripcion_Medicamento" runat="server" Text="" />
            <br>
            <br>
            <label>Precio:* </label><asp:TextBox ID="TextBox1" runat="server" Text="" />
            <br>
            <br>
            <label>Dirección de la Imágen: </label> <input type="text" name="Direccion" />
            <br>
            <br>
            <asp:Button ID="Agregar_Medicamento" runat="server" Text="Agregar" />
         </div>
        <br>
        <div class="Categoría">
            <br>
            <label>Agregar Categorías</label>
            <br>
            <br>
            <label>Nombre: </label><asp:TextBox ID="Nombre_Categoría" runat="server" Text="" />
            <br>
            <br>
            <label>Actividad Terapéutica: </label><asp:TextBox ID="Actividad" runat="server" Text="" />
            <br>
            <br>
            <asp:Button ID="Agregar_Categoria" runat="server" Text="Agregar" />
        </div>
        <br>
        <div class="Empleados">
            <br>
            <label>Agregar Empleados</label>
            <br>
            <br>
            <label>Nombre: </label> <asp:TextBox ID="Nombre_Empleado" runat="server" Text="" />
            <br>
            <br>
            <label>Apellido Paterno: </label> <asp:TextBox ID="Apellido" runat="server" Text="" />
            <br>
            <br>
            <label>Apellido Materno: </label><asp:TextBox ID="Apellido2" runat="server" Text="" />
            <br>
            <br>
            <label>Correo: </label><asp:TextBox ID="correo" runat="server" Text="" TextMode="Email"/>
            <br>
            <br>
            <label>Contraseña: </label><asp:TextBox ID="contraseña" runat="server" Text="" TextMode="Password" />
            <br>
            <br>
            <label>Confirmar Contraseña: </label><asp:TextBox ID="contraseña2" runat="server" Text="" TextMode="Password" />
            <br>
            <br>
            <label>Fecha de Nacimiento: </label><asp:TextBox ID="Fecha" runat="server" Text="" TextMode="Date"/>
            <br>
            <br>
            <label class="Direccion">Dirección</label> 
            <br>
            <label>Calle:* </label> <asp:TextBox ID="Calle" runat="server" Text="" /> 
            <br>
            <br>
            <label>Num. Exterior:* </label> <asp:TextBox ID="Num_Ext" runat="server" Text="" TextMode="Number"/>
            <br>
            <br>
            <label>Num. Interior: </label><asp:TextBox ID="Num_Int" runat="server" Text="" TextMode="Number"/>
            <br>
            <br>
            <label>Código Postal:* </label> <asp:TextBox ID="CP" runat="server" Text="" TextMode="Number" />
            <br>
            <br>
            <label>Municipio:* </label> <asp:TextBox ID="Municipio" runat="server" Text="" />
            <br>
            <br>
            <label>Estado:* </label> <asp:TextBox ID="Estado" runat="server" Text="" />
            <br>
            <br>
            <asp:Button ID="Agregar_Empleados" runat="server" Text="Agregar" />
        </div>

        <asp:Button ID="Cerrar" runat="server" Text="Cerrar Sesión" OnClick="Cerrar_Click" />
        </div>
    </form>
</body>
</html>
