<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Retiro.aspx.cs" Inherits="Web1.Retiro" %>

<!DOCTYPE html>

 <html lang="en" dir="ltr">
<head runat="server">
      <meta charset="UTF-8">
    <title>Banco internacional el pechu</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
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

    

     h2{
         color:#3588ee;
         font-size:40px;
         font-weight:bold;
         animation-iteration-count:infinite;
        
     }
     
     .cont{
         width:50%;
         height:500px;
         margin:auto;
         border: 3px solid#FF5DA2;
     }

     .logo{
          width:50%;
         height:120px;
         margin:auto;
         border: 3px solid#FF5DA2;

     }

     .logo h2{
         color:#ff6a00;
         font-size: 32px;
         font-weight:bold;
         text-align:center;

     }

     .btn{
         background:#b6ff00;
         color:white;
         font-size:28px;
         font-weight:bold;
         border-radius: 8px;
     }

     .gp1{
         text-align:left;
        

     }

      .gp2{
         text-align:right;
        
     }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <div class="logo">
            <h2>Retiros</h2>
        </div>
        <div class="cont row">
            <h2>Seleccione un monto</h2>
            <div class="gp1 col-6">
                <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#00066ff" Font-Bold="True">100</asp:Label>
                <asp:Button ID="Button1" runat="server" Text="Aceptar"  CssClass="btn"/>
               <br />
                <br />
                <br />
           
           
                 <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="#00066ff" Font-Bold="True">200</asp:Label> 
                <asp:Button ID="Button2" runat="server" Text="Aceptar"  CssClass="btn"/>
                <br />
                <br />
                <br />
              
                <asp:Label ID="Label3" runat="server" Text="Label" ForeColor="#00066ff" Font-Bold="True">500</asp:Label> 
                <asp:Button ID="Button3" runat="server" Text="Aceptar"  CssClass="btn"/>
              <br />
                <br />
                <br />
                 </div>
             <div class="gp2 col-6">
                <asp:Label ID="Label4" runat="server" Text="Label" ForeColor="#00066ff" Font-Bold="True">1000</asp:Label> 
                <asp:Button ID="Button4" runat="server" Text="Aceptar"  CssClass="btn"/>
                <br />
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Label" ForeColor="#00066ff" Font-Bold="True">2000</asp:Label> 
                <asp:Button ID="Button5" runat="server" Text="Aceptar"  CssClass="btn"/>
                <br />
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Label" ForeColor="#00066ff" Font-Bold="True">otros</asp:Label> 
                <asp:Button ID="Button6" runat="server" Text="Aceptar"  CssClass="btn"/>
                <br />
                <br />
                <br />
        </div>
            </div>
    </form>
</body>
</html>

