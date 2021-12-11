<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="WebApplication3.Prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="BaseFarmacia" Height="315px" Width="907px">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Descripción" HeaderText="Descripción" SortExpression="Descripción" />
                    <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="BaseFarmacia" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [Nombre], [Descripción], [precio] FROM [Medicamentos]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
