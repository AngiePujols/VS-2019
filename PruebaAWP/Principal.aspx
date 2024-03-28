<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="PruebaAWP.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 282px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Primer Numero"></asp:Label>
            <asp:TextBox ID="TbNum1" runat="server" Height="26px" OnTextChanged="TextBox1_TextChanged" style="margin-left: 24px" Width="136px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Segundo Numero"></asp:Label>
            <asp:TextBox ID="TbNum2" runat="server" Height="26px" OnTextChanged="TextBox1_TextChanged" style="margin-left: 11px" Width="136px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Resultado"></asp:Label>
            <asp:TextBox ID="TbResultado" runat="server" Height="29px" ReadOnly="True" style="margin-left: 56px" Width="138px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Labelmsj" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="BtAceptar" runat="server" Height="29px" OnClick="Button1_Click" style="margin-left: 111px; margin-right: 4px; margin-top: 0px" Text="Aceptar" Width="157px" />
        </p>
        <div style="height: 245px">
                

                 <asp:Label ID="Label4" runat="server" Text="User"></asp:Label>
                 <br />
                 <asp:TextBox ID="TbUser" runat="server" Height="24px" style="margin-bottom: 11px" Width="132px"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                 <br />
                 <asp:TextBox ID="TbPassword" runat="server" Height="23px" Width="136px"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Label ID="Labelmess" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                 <br />
                 <br />
                 <br />
                 <asp:Button ID="BtOK" runat="server" Height="31px" OnClick="Button1_Click1" Text="Aceptar" Width="147px" />
                

                 </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
