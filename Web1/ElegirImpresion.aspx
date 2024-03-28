<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ElegirImpresion.aspx.cs" Inherits="Web1.ElegirImpresion" %>

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
     

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="cabeza">
                <asp:Label ID="Label1" runat="server" Text="Banco internacional el pechu"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
