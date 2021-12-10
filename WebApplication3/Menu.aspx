<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebApplication3.Menu" %>

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
        <div class="menu">
            <a href="Menu.aspx" class="Inicio">Farmacia Alpheus</a>
            <span class="icon-search"></span><asp:TextBox ID="Buscar" runat="server" Text="Buscar..." CssClass="Buscar"/>
            <ul class="Categoria">
                <li class="Categoria-text">
                    <button class="Boton-Categoria">Categoría</button>
                    <ul class="Categoria-Contenido">
                        <li><asp:Button ID="Medicamentos" runat="server" Text="Medicamentos" OnClick="Medicamentos_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Equipo" runat="server" Text="Equipo y Botiquín" OnClick="Equipo_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Salud" runat="server" Text="Salud Natural" OnClick="Salud_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Vitaminas" runat="server" Text="Vitaminas y Suplementos" OnClick="Vitaminas_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Cuidado" runat="server" Text="Cuidado Personal y Belleza" OnClick="Cuidado_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Sexual" runat="server" Text="Salud Sexual" OnClick="Sexual_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Bebes" runat="server" Text="Bebés" OnClick="Bebes_Click" CssClass="lista" /></li>
                    </ul>
                </li>
            </ul>
            <!--<button class="Carrito"><span class="icon-cart"></span></button>-->
            <span class="icon-car"><asp:Button ID="Carrito" runat="server" OnClick="Carrito_Click" CssClass="Carrito"></asp:Button></span>
            <a href="Login.aspx" class="Iniciar-Registrar">Iniciar Sesión</a>
        </div>
        </br>
        </br>
        </br>
        </br>
        </br>
        </br>
        <div class="Principales">
            <br>
            <p class="Titulo" aria-selected="false">Categorias Principales</p>
            <br>
            <br>
            <a href="#"><img class="Categoria_Bebes" height="250" width="475" src="img/Categoria_Bebes.jfif" href="#"/></a>
            <a href="#"><img class="Categoria_Cuidado" height="250" width="475" src="img/Categoria_Cuidado.jfif" /></a>
            <a href="#"><img class="Categoria_Medicamentos" height="250" width="475" src="img/Categoria_Medicamentos.jpg" /></a>
            <a href="#"><img class="Categoria_Suplementos" height="250" width="475"  src="img/Categoria_Suplementos.jpg" /></a>
        </div> 
        </br>  
    </form>
</body>
</html>
