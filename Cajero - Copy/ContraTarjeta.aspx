<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContraTarjeta.aspx.cs" Inherits="Cajero.Otro" %>

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
        .menu{
            background:#163354;
            border:5px solid#EFAC3C;
            width:60%;
            margin:auto;
            text-align:center;
        }

        #TextClave{
            width:220px;
            border:none;
            border-radius:10px;
            height:50px;
            margin-top:12%;  
            padding:8px;
            font-size:30px;

        }

        #ButtonAceptar{
            width:220px;
            height:70px;
            background:#EFAC3C;
            padding:10px;
            margin-top:10%;
            margin-bottom:15%;
            border-radius:10px;
            font-size:22px;
            color:white;
            font-weight:bold;

        }
         .menu img{
            text-align:left;
            width:200px;
            height:120px;
            margin-left:1px;

        }

        .auto-style2 {
            color: #FFFFFF;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cabeza">

            <asp:Label ID="Label1" runat="server" Text="BANCO INTERNACIONAL LIZ"></asp:Label>
            </div>
        <div class="menu">
          <h2 class="auto-style2"> &nbsp;</h2>
            <h2 class="auto-style2"> &nbsp;INTRODUZCA SU CLAVE</h2>

            &nbsp;<asp:TextBox ID="TextClave" runat="server" TextMode="Password" MaxLength="4"></asp:TextBox>
            <br />
            <asp:Label ID="Labmsj" runat="server" CssClass="auto-style2"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonAceptar" runat="server" Text="Aceptar" />

        </div>
        
        </form>
</body>
</html>
