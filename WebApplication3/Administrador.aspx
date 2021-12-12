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
            <br>
            <br>
            <label>Nombre:* </label> <input type="text" name="NombreMedicamento" />
            <br>
            <br>
            <label>Descripción: </label> <input type="text" name="DescripcionMedicamento" />
            <br>
            <br>
            <label>Precio:* </label><input type="number" name="Precio" />
            <br>
            <br>
            <label>Dirección de la Imágen: </label> <input type="text" name="Direccion" />
            <br>
            <br>
            <input type="button" name="Agregar" value="Agregar" />
        </div>
        <br>
        <div class="Categoría">
            <br>
            <label>Agregar Categorías</label>
            <br>
            <br>
            <label>Nombre: </label><input type="text" name="NombreCategoria" />
            <br>
            <br>
            <label>Actividad Terapéutica: </label><input type="text" name="Actividad" />
            <br>
            <br>
            <input type="button" name="Agregar_Categoria" value="Agregar" />
        </div>
        <br>
        <div class="Empleados">
            <br>
            <label>Agregar Empleados</label>
            <br>
            <br>
            <label>Nombre: </label>
            <br>
            <br>
            <label>Apellido Paterno: </label>
            <br>
            <br>
            <label>Apellido Materno: </label>
            <br>
            <br>
            <label>Correo: </label>
            <br>
            <br>
            <label>Contraseña: </label>
            <br>
            <br>
            <label>Confirmar Contraseña: </label>
            <br>
            <br>
            <label>Fecha de Nacimiento: </label>
            <br>
            <br>
            <label class="Direccion">Dirección</label> 
            <br>
            <label>Calle:* </label> <input type="text" name="Calle" class="Calle" /> 
            <br>
            <br>
            <label>Num. Exterior:* </label> <input type="number" name="Num_Exterior" class="Num_Exterior" />
            <br>
            <br>
            <label>Num. Interior: </label><input type="number" name="Num_Interior" class="Num_Interior" /> 
            <br>
            <br>
            <label>Código Postal:* </label> <input type="number" name="Postal" class="Postal" /> 
            <br>
            <br>
            <label>Municipio:* </label> <input type="text" name="Municipio" class="Municipio" />
            <br>
            <br>
            <label>Estado:* </label> <input type="text" name="Estado" class="Estado" />
            <br>
            <br>
            <input type="button" value="Añadir" name="Añadir" class="Añadir" />
        </div>

        <asp:Button ID="Cerrar" runat="server" Text="Cerrar Sesión" OnClick="Cerrar_Click" />
        </div>
    </form>
</body>
</html>
