<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="WebApplication3.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro</title>
    <link rel="stylesheet" href="css/Registro.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="box">
                <label>Nombre: </label>
                </br>
                <asp:TextBox ID="nombre" runat="server" Text=" " CssId="nombre" /> 
                </br>
                </br>
                <label>Apellido Paterno: </label>
                </br>
                <asp:TextBox ID="apellido" runat="server" Text=" " CssId="apellido" /> 
                </br>
                </br>
                <label>Apellido Materno: </label>
                </br>
                <asp:TextBox ID="apellido2" runat="server" Text=" " CssId="apellido" /> 
                </br>
                </br>
                <label>Correo: </label>
                </br>
                <asp:TextBox ID="correo" runat="server" Text=" " CssId="correo" /> 
                </br>
                </br>
                <label>Contraseña: </label>
                </br>
                <asp:TextBox ID="contraseña" runat="server" Text=" " CssId="contraseña" /> 
                </br>
                </br>
                <label>Confirmar Contraseña: </label>
                </br>
                <asp:TextBox ID="contraseña2" runat="server" Text=" " CssId="contraseña" /> 
                <br />
                <br />
                <label>Fecha de nacimiento: </label>
                </br>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </br>
                <asp:Button ID="registrar2" runat="server" Text="Registrar" CssId="boton_ingresar" />
        </div>
    </form>
</body>
</html>
