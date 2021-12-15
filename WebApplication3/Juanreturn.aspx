<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Juanreturn.aspx.cs" Inherits="WebApplication3.Juanreturn" %>

<!DOCTYPE html>
<html lang="es">
    <head>
        <title>Farmacia Alpheus</title>
        <link rel="stylesheet" href="css/Juan.css" type="text/css" />
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
                    <asp:Button ID="Categoria" runat="server" Text="Productos" CssClass="Boton-Categoria" OnClick="Categoria_Click" />
                    <!--<ul class="Categoria-Contenido">
                        <li><asp:Button ID="Medicamentos" runat="server" Text="Medicamentos" OnClick="Medicamentos_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Equipo" runat="server" Text="Equipo y Botiquín" OnClick="Equipo_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Salud" runat="server" Text="Salud Natural" OnClick="Salud_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Vitaminas" runat="server" Text="Vitaminas y Suplementos" OnClick="Vitaminas_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Cuidado" runat="server" Text="Cuidado Personal y Belleza" OnClick="Cuidado_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Sexual" runat="server" Text="Salud Sexual" OnClick="Sexual_Click" CssClass="lista" /></li>
                        <li><asp:Button ID="Bebes" runat="server" Text="Bebés" OnClick="Bebes_Click" CssClass="lista" /></li>
                    </ul>-->
                </li>
            </ul>
            <!--<button class="Carrito"><span class="icon-cart"></span></button>-->
            <span class="icon-car"><asp:Button ID="Carrito" runat="server" OnClick="Carrito_Click" CssClass="Carrito"></asp:Button></span>
            <asp:Button ID="Inciar" runat="server" Text="Iniciar Sesión" CssClass="Iniciar-Registrar" OnClick="Inciar_Click" />
        </div>
        </br>
        </br>
        </br>
        </br>
        </br>
        </br>
        <div class="Datos">
            <br>
            <label class="Direccion">Información</label> &nbsp;&nbsp;&nbsp;<label class="Metodo">Dirección</label>&nbsp;&nbsp;<br>
            <br>
            <br>
            <label>Nombre: </label><asp:Label ID="Nombre" runat="server" Text=" " CssClass="Nombre" />&nbsp;&nbsp;&nbsp;
            <br>
            <br>
            <label>Apellido Paterno: </label><asp:Label ID="Apellido1" runat="server" Text=" " CssClass="Apellido_Paterno" />
            <br>
            <br>
            <label>Apellido Materno: </label><asp:Label ID="Apellido2" runat="server" Text=" " CssClass="Apellido_Materno" />
            <br>
            <br>
            <label>Fecha de Nacimiento: </label> <asp:Label ID="Fecha" runat="server" Text=" " CssClass="Fecha" />
            <br>
            <br>
            <br>
            <br>
            <label class="Direccion">Dirección</label><asp:Label ID="Error_Direccion" runat="server" Text=" " /> <label class="Metodo">Método de Pago</label><asp:Label ID="Error_Metodo" runat="server" Text=" " />
            <br>
            <label>Calle:* </label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Calle" runat="server" Text=" " CssClass="Calle"/> <label class="Correo">Correo: </label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Correo" runat="server" Text="" CssClass="Correotxt"/>
            <br>
            <br>
            <br>
            <label>Num. Exterior:* </label> <asp:TextBox ID="Num_Exterior" runat="server" Text="" TextMode="Number" CssClass="Num_Exterior"/> <label class="Contraseña">Contraseña: </label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Contraseña" runat="server" Text=" " TextMode="Password" CssClass="Contraseñatxt" />
            <br>
            <br>
            <br>
            <label>Num. Interior: </label> &nbsp;&nbsp;&nbsp;<asp:TextBox ID="Num_Interior" runat="server" Text="" TextMode="Number" CssClass="Num_Interior"/> <label class="Contraseña2">Confirmar Contraseña: </label> <asp:TextBox ID="Contraseña2" runat="server" Text=" " TextMode="Password" CssClass="Contraseñatxt" />
            <br>
            <br>
            <br>
            <label>Código Postal:* </label> <asp:TextBox ID="CP" runat="server" Text="" TextMode="Number" CssClass="CP"/>&nbsp;&nbsp;<asp:Button ID="Actualizar_Metodo" runat="server" Text="Actualizar" CssClass="Actualizar" OnClick="Actualizar_Metodo_Click" /><asp:Button ID="Buscar_Metodo" runat="server" Text="Buscar" CssClass="Actualizar" OnClick="Buscar_Metodo_Click" />
            <br>
            <br>
            <br>
            <label>Municipio:* </label>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Municipio" runat="server" Text=" " CssClass="Municipio"/>
            <br>
            <br>
            <br>
            <label>Estado:* </label>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Estado" runat="server" Text=" " CssClass="Estado"/>
            <br>
            <br>
            <br>
            <asp:Button ID="Actualizar_Direccion" runat="server" Text="Actualizar" CssClass="Actualizar" OnClick="Actualizar_Direccion_Click" /><asp:Button ID="Buscar_Registro" runat="server" Text="Buscar" CssClass="Actualizar" OnClick="BuscarDireccion_Click" />
            <br />
            <br />
            <asp:Button ID="Cerrar" runat="server" Text="Cerrar Sesión" OnClick="Cerrar_Click" />
        </div> 
        </br>      
    </form>
</body>
</html>
