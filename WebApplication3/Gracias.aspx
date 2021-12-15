<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gracias.aspx.cs" Inherits="WebApplication3.Gracias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Gracias por tu compra!!</label>
            <br />
            <br />
            <label>Para regresar al menú: </label><asp:Button ID="Regresar" runat="server" Text="Regresar" OnClick="Regresar_Click" style="height: 35px" />
        </div>
    </form>
</body>
</html>
