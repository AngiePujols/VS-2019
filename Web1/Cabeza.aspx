<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cabeza.aspx.cs" Inherits="Web1.WebForm7" %>

<!DOCTYPE html>


    <html lang="en" dir="ltr">
<head runat="server">
      <meta charset="UTF-8">
    <title>Banco internacional el pechu</title>
        <style>
        .cabeza{
            background:#4cff00;
            color: black;
            width:100%;
            height: 20%;
            font-size: 30px;
            font-weight: bold;
            font-family: Verdana;
            padding:10px;
        }
        .cuerpo{
            width:60%;
            background:white;
            margin:auto;
            text-align:center;
            align-self:center;
            border:5px solid#000000 ;

        }
        img{
            width:400px;
            height:310px;
            text-align:center;
        }

        h3{
            color:black;
            font-size: 25px;
            font-weight:bold;
            padding: 30px;
        }

        #Button1{
            background:#ffd800;
            color:white;
            font-size:25px;
            font-weight:bold;
            width: 220px;
            height: 70px;
            border-radius: 15px;
            padding: 20px;
            text-align:center;
            


        }
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <div>
            <div class="cabeza">
                <asp:Label ID="Label1" runat="server" Text="Banco internacional el pechu"></asp:Label>
            </div>
            <div class="cuerpo">
                <h3>Entre su tarjeta
                                     
                </h3>
                <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True" Font-Size="Large" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
                    <asp:ListItem>Elejir una cuenta</asp:ListItem>
                </asp:DropDownList>
                <h3><img src="icon-ath-01.png" style="text-align:center" />
                </h3>
                <h3>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </h3>
                <p>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </p>
                <p>&nbsp;</p>

                &nbsp;<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
