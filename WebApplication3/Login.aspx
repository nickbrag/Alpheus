<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio de Sesión</title>
    <link rel="stylesheet" href="css/login.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="box">
                <label>Correo: </label>
                </br>
                <asp:TextBox ID="Usuario" runat="server" Text=" " CssId="Usuario" />
                </br>
                </br>
                <label>Contraseña: </label>
                </br>
                <asp:TextBox ID="contraseña" runat="server" Text=" " CssId="contraseña"/>
                </br>
                </br>
                <asp:Button ID="boton_ingresar" runat="server" Text="Iniciar Sesión"  CssId="boton_ingresar" OnClick="boton_ingresar_Click"/>
                <a href="Registrar.aspx" class="boton_registrar">Registrar</a>
        </div>
    </form>
</body>
</html>
