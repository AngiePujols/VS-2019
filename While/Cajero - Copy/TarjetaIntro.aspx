<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TarjetaIntro.aspx.cs" Inherits="Cajero.Tarjeta3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body{
            background:#163354;
        }
        .cabeza{
            background:#EFAC3C;
            color:white;
            width:100%;
            height:30%;
            font-size:30px;
            font-weight:bold;
            font-family: "Verdana";
            padding:10px;

        }

        .cuerpo{
            width:60%;
            background:#163354;
            margin:auto;
            text-align:center;
            border: 5px solid#EFAC3C;
        }

       img{
            width:400px;
            height:310px;
        }

       h3{
           color:white;
           font-size:25px;
           font-weight:bold;
           padding:30px;


       }
       #Button1{
           background:#EFAC3C;
           color:white;
           font-size:25px;
           font-weight:bold;
           width:220px;
           height:70px;
           border-radius:15px;
           padding:10px;

       }
     
        .auto-style1 {
            height: 366px;
        }
        .auto-style2 {
            font-size: 30px;
        }
     
        .auto-style3 {
            color: #FFFFFF;
        }
     
        .auto-style4 {
            font-size: large;
        }
     
        .auto-style5 {
            color: #FF0000;
        }
     
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cabeza">
          
            <asp:Label ID="Label1" runat="server" Text="BANCO INTERNACIONAL LIZ"></asp:Label>
            </div>

        <div class="cuerpo">
            <h3 class="auto-style2">Introduzca su tarjeta</h3>
            <p class="auto-style2">
                <asp:DropDownList ID="DropCuenta" runat="server" Font-Bold="True" style="margin-left: 0px" Width="212px" CssClass="auto-style4" OnSelectedIndexChanged="DropCuenta_SelectedIndexChanged">
                    <asp:ListItem>Elegir una cuenta</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CajeroConnectionString %>" SelectCommand="SELECT [Num_cuenta] FROM [Cuenta]"></asp:SqlDataSource>
            </p>
            <img src="icon-ath-01.png" class="auto-style1" /><br />
            <asp:Label ID="Labelnumero" runat="server" Text="Label" CssClass="auto-style3" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="LabelMsj" runat="server"  Font-Bold="True" Font-Size="Large" style="font-weight: 700" CssClass="auto-style5" ></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" Height="68px" Width="196px" />

            <br />
            <br />

        </div>
        </form>
</body>
</html>
