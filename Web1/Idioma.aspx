<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Idioma.aspx.cs" Inherits="Web1.Idioma" %>

<!DOCTYPE html>


    <html lang="en" dir="ltr">
<head runat="server">
      <meta charset="UTF-8">
    <title>Banco internacional el pechu</title>
        <style>
        .cabeza{
            background:#4cff00;
            color: white;
            width:100%;
            height: 20%;
            font-size: 30px;
            font-weight: bold;
            font-family: Verdana;
            padding:10px;
        }
        .cuerpo{
            width:60%;
            background:#FF5DA2;
            margin:auto;
            text-align:center;
            border:5px solid#4cff00 ;

        }
     .cont{
         width:50%;
         height:400px;
         margin:auto;
         border: 3px solid#936B2F;
         text-align:right;


     }

     .msj{
         text-align:center;
         margin:auto;
         width:50%;
         border:3px solid#936B2F;
         background-color:brown;

     }
     .btn{
         color:white;
         background:#3588ee;
         width:200px;
         height:60px;
         margin-top:80px;
         border-radius:4px;
         font-size:26px;
         font-weight:bold;
         margin-right:12px;
         margin-left:30px;


     }

     h2{
         color:#3588ee;
         font-size:40px;
         font-weight:bold;
         animation-iteration-count:infinite;
        
     }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="cabeza">
                <asp:Label ID="Label1" runat="server" Text="Banco internacional el pechu"></asp:Label>
            </div>
            <div class="msj">
                <h2>Seleccione un Idioma</h2>
                <h2>Select a Language</h2>
            </div>

            <div class="cont">
                <div class="gp1">
                    <asp:Label ID="Label2" runat="server" Text="Español" Font-Size="X-Large"></asp:Label>
                    <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn" OnClick="Button1_Click" />
                </div>

                <div class="gp2">
                     <asp:Label ID="Label3" runat="server" Text="English" Font-Size="X-Large"></asp:Label>
                    <asp:Button ID="Button2" runat="server" Text="Button" CssClass="btn" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>

