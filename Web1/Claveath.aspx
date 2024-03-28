<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Claveath.aspx.cs" Inherits="Web1.Claveath" %>

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

        .menu{
            width:60%;
            margin:auto;
            background:#ff6a00;
            border:5px solid#f5b283;
            text-align:center;
        }

        #TextBoxclave{
            width:250px;
            height:50px;
            border:none;
            padding:8px;
            font-size:22px;
            font-size:18px;

        }
     
        #Butaceptar{
            margin-top:20%;
            margin-bottom:15%;
            height:50px;
            text-align:center;
            border-radius:15px;
            background:#b6ff00;
            padding:20px;
            font-size:18px;
         

        }

        img{
            margin-left: 1px;
            text-align:left;
            width:200px;
            height:110px;
        }

          .cont{
         width:50%;
         height:400px;
         margin:auto;
         border: 3px solid#936B2F;
         text-align:right;


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
           <div class="menu" style="height: 400px">


               <asp:TextBox ID="TextBoxclave" runat="server" TextMode="Password" MaxLength="4" OnTextChanged="TextBoxclave_TextChanged"></asp:TextBox>
               <br />
               <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
               <br />
               <asp:Button ID="Butaceptar" runat="server" Text="Aceptar" />
               <br />


           </div>
        </div>
    </form>
</body>
</html>
