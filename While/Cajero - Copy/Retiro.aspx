<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Retiro.aspx.cs" Inherits="Cajero.Retiro" %>

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

        .cont{
            width:50%;
            margin:auto;
            border:3px solid #EFAC3C;
            height:500px;

        }

        .logo{
             width:50%;
            margin:auto;
            border:3px solid #EFAC3C;
            height:120px;
        }

         .logo h2{
            color:white;
            font-size:32px;
            font-weight:bold;
            text-align:center;


        }

        .btn{
            background: #EFAC3C;
            color:white;
            font-size:25px;
            font-weight:bold;
            border-radius:8px;
            width:130px;
            height:55px;

        }

        .gp1{
            text-align:left;
       
        }
       .gp2{
            text-align:right;
 

        }

       .cont h2{
           color:white;
            font-size:32px;
            font-weight:bold;
            text-align:center;
       }


        .auto-style1 {
            color: #FFFFFF;
        }

        .auto-style2 {
            color: #FF99CC;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cabeza">
          
            <asp:Label ID="Label1" runat="server" Text="BANCO INTERNACIONAL LIZ"></asp:Label>
            </div>

        <div class="logo">
           <h2 >Retiros</h2>

        </div>
        <div class="cont row">
            <h2>Seleccione un monto</h2>

            <div class="gp1 col-6">
                <asp:Button ID="Aceptar1" runat="server" Text="Aceptar" CssClass="btn" OnClick="Aceptar1_Click"/>
                <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FFFFFF"  CssClass="auto-style2">100</asp:Label>
                <br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Aceptar" CssClass="btn" OnClick="Button1_Click"/>
                <asp:Label ID="Label3" runat="server" Text="Label" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FFFFFF" >200</asp:Label>
                <br />
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Aceptar" CssClass="btn" OnClick="Button2_Click"/>
                <asp:Label ID="Label4" runat="server" Text="Label" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FFFFFF" CssClass="auto-style1">500</asp:Label>



            </div>

            <div class="gp2 col-6">


                <asp:Label ID="Label5" runat="server" Text="Label" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FFFFFF" >1000</asp:Label>
                <asp:Button ID="Button3" runat="server" Text="Aceptar" CssClass="btn" OnClick="Button3_Click"/>
                <br />
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Label" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FFFFFF" >2000</asp:Label>
                <asp:Button ID="Button4" runat="server" Text="Aceptar" CssClass="btn" OnClick="Button4_Click"/>
                <br />
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Label" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FFFFFF" >Otro</asp:Label>
                <asp:Button ID="Button5" runat="server" Text="Aceptar" CssClass="btn" OnClick="Button5_Click"/>

            </div>

        </div>

        </form>
</body>
</html>

