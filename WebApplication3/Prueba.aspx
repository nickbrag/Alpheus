<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="WebApplication3.Prueba1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblAgregado" runat="server" Text="" />
            <asp:DataList ID="DataList1" runat="server" DataKeyField="codproducto" DataSourceID="SqlDataSource1" RepeatColumns="3" OnItemCommand="DataList1_ItemCommand" CssClass="table table-responsive">
                                <ItemTemplate>
                                    <asp:Image ID="Image1" width="140" height="120" runat="server" ImageUrl='<%# "~/Imagenes/"+Eval("imagen") %>' CssClass="img-fluid" />
                                    <br />
                                    <br />
                                    Producto :
                                    <asp:Label ID="desproductoLabel" runat="server" Text='<%# Eval("desproducto") %>' />
                                    <br />
                                    Precio :
                                    <asp:Label ID="preproductoLabel" runat="server" Text='<%# Eval("preproducto") %>' />
                                    <br />
                                    <asp:Button ID="Button1" runat="server" CommandName="Seleccionar" OnClick="Button1_Click" Text="Agregar al Carrito" CssClass="btn btn-success" />
                                    <br />
                                </ItemTemplate>
                            </asp:DataList>
        </div>
    </form>
</body>
</html>
