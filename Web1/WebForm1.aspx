<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="wrapper">
        <div class="container">
            <div>
                <asp:Label ID="Label1" runat="server" Text="User"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"  CssClass="form-control" Placeholder="Usuario"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Button ID="Button1" runat="server" Text="Aceptar" CssClass="btn btn-primary form-control" OnClick="Button1_Click"/>
            </div>
            <div>
                <input type="checkbox" name="name" value="" />
                <span>mantener conectado <a href="#">Registrate</a></span>
            </div>
        </div>
    </form>
</body>
</html>
