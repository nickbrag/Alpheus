<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="WebApplication3.productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Farmacia Alpheus</title>
        
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="css/Menu.css" type="text/css" />
        <link rel="stylesheet" href="css/style.css" type="text/css" />

        <link rel="stylesheet" href="C:\Users\marti\source\repos\WebApplication3\WebApplication3\cssstyle.css" type="text/css" />     
        
</head>
<body>
<div class="Menu">
            <button class="Inicio">Farmacia Alpheus</button>
            <button class="Buscar"><span class="icon-search"></span></button> <input type="text" id="Buscar" name="Buscartxt" placeholder="Buscar..." />
            <ul class="Categoria">
                <li class="Categoria-text">
                    <button class="Boton-Categoria">Categoría</button>
                    <ul class="Categoria-Contenido">
                        <li><a href="#">Medicamentos</a></li>
                        <li><a href="#">Equipo y Botiquín</a></li>
                        <li><a href="#">Salud Natural</a></li>
                        <li><a href="#">Vitaminas y Suplementos</a></li>
                        <li><a href="#">Cuidado Personal y Belleza</a></li>
                        <li><a href="#">Salud Sexual</a></li>
                        <li><a href="#">Bebés</a></li>
                    </ul>
                </li>
            </ul></a>
            <button class="Carrito"><span class="icon-cart"></span></button>
            <button class="Iniciar-Registrar">Iniciar Sesión</button>


</html>
