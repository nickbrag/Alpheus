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
        <div class="menu">
            <form id="form2" runat="server">
            <asp:Button ID="Inicio" runat="server" Text="Farmacia Alpheus" OnClick="Inicio_Click" CssClass="Inicio"/>
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
            <asp:Button ID="Iniciar" runat="server" Text="Iniciar Sesión" OnClick="Iniciar_Click" CssClass="Iniciar-Registrar"/>
        </div>
        </br>
        </br>
        </br>
        </br>
        </br>
        </br>
        <div class="Datos">
            <br>
            <h2>Información</h2>
            <br>
            <br>
            <br>
            <label>Nombre: </label><asp:Label ID="Nombre" runat="server" Text=" " CssClass="Nombre" />
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
            <label class="Direccion">Dirección</label> <label class="Metodo">Método de Pago</label>
            <br>
            <label>Calle:* </label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Calle" runat="server" Text=" " CssClass="Calle"/> <label class="Correo">Correo: </label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Correo" runat="server" Text=" " CssClass="Correotxt"/>
            <br>
            <br>
            <br>
            <label>Num. Exterior:* </label> <asp:TextBox ID="Num_Exterior" runat="server" Text=" " CssClass="Num_Exterior"/> <label class="Contraseña">Contraseña: </label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="password" name="Contraseña" class="Contraseñatxt" />
            <br>
            <br>
            <br>
            <label>Num. Interior: </label> &nbsp;&nbsp;&nbsp;<asp:TextBox ID="Num_Interior" runat="server" Text=" " CssClass="Num_Interior"/> <label class="Contraseña2">Confirmar Contraseña: </label> <input type="password" name="Contraseña2" class="Contraseñatxt" />
            <br>
            <br>
            <br>
            <label>Código Postal:* </label> <asp:TextBox ID="CP" runat="server" Text=" " CssClass="CP"/>&nbsp;&nbsp;<asp:Button ID="Actualizar_Metodo" runat="server" Text="Actualizar" CssClass="Actualizar" OnClick="Actualizar_Metodo_Click" />
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
            <asp:Button ID="Actualizar_Direccion" runat="server" Text="Actualizar" CssClass="Actualizar" />
        </div> 
        </br>      
    </form>
</body>
</html>
