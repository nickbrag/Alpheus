<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="WebApplication3.Prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Farmacia Alpheus</title>
    <link rel="stylesheet" href="css/Menu.css" type="text/css" />
        <link rel="stylesheet" href="css/style.css" type="text/css" />
        <link rel="stylesheet" href="css/img/style.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="menu">
            <a href="Menu.aspx" class="Inicio">Farmacia Alpheus</a>
            <span class="icon-search"></span><asp:TextBox ID="Buscar" runat="server" Text="Buscar..." CssClass="Buscar" OnTextChanged="Buscar_TextChanged"/>
            <ul class="Categoria">
                <li class="Categoria-text">
                    <button class="Boton-Categoria">Categoría</button>
                    <ul class="Categoria-Contenido">
                        <li><asp:Button ID="Medicamentos" runat="server" Text="Medicamentos" CssClass="lista" /></li>
                        <li><asp:Button ID="Equipo" runat="server" Text="Equipo y Botiquín" CssClass="lista" /></li>
                        <li><asp:Button ID="Salud" runat="server" Text="Salud Natural" CssClass="lista" /></li>
                        <li><asp:Button ID="Vitaminas" runat="server" Text="Vitaminas y Suplementos" CssClass="lista" /></li>
                        <li><asp:Button ID="Cuidado" runat="server" Text="Cuidado Personal y Belleza" CssClass="lista" /></li>
                        <li><asp:Button ID="Sexual" runat="server" Text="Salud Sexual" CssClass="lista" /></li>
                        <li><asp:Button ID="Bebes" runat="server" Text="Bebés" CssClass="lista" /></li>
                    </ul>
                </li>
            </ul>
            <!--<button class="Carrito"><span class="icon-cart"></span></button>-->
            <span class="icon-car"><asp:Button ID="Carrito" runat="server" OnClick="Carrito_Click" CssClass="Carrito"></asp:Button></span>
            <asp:Button ID="Inciar" runat="server" Text="Iniciar Sesión" CssClass="Iniciar-Registrar" OnClick="Inciar_Click" />
        </div>
            <div class="Principales">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="Cargar" runat="server" Text="Cargar" OnClick="Cargar_Click"/>
                <asp:DataGrid ID="Producto" runat="server" Height="438px" Width="793px" ></asp:DataGrid>
            </div>
        </div>
    </form>
</body>
</html>
