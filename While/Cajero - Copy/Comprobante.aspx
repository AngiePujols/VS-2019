<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comprobante.aspx.cs" Inherits="Cajero.Impresión" %>



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
            margin: auto;
            border: 3px solid#EFAC3C;
            text-align: left;
            height:400px;

        }

        .cuerpo{
            width:60%;
            background:#c46ee1;
            margin:auto;
            text-align:center;
            border: 5px solid#9919be;
        }

       img{
            width:400px;
            height:310px;
        }

       h3{
           color:#000000;
           font-size:25px;
           font-weight:bold;
           padding:30px;


       }
   

       .msj{
           text-align: center;
           border:3px solid#EFAC3C;
           width:50%;
           margin:auto;
         background:#163354;


       }

       .btn{
           background:#EFAC3C;
           color:white;
           font-size:25px;
           font-weight:bold;
           width:220px;
           height:70px;
           border-radius:15px;
           padding:20px;


       }

       h2{
           color:white;
           font-size:40px;
           font-weight:bold;
           animation-iteration-count:infinite;
       }


        .auto-style1 {
            font-size: xx-large;
            color: #FFFFFF;
        }

        h3{
           color:white;
           font-size:30px;
           font-weight:bold;
           text-align:center;

        }

        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cabeza">
          
            <asp:Label ID="Label1" runat="server" Text="BANCO INTERNACIONAL LIZ"></asp:Label>
            </div>

        <div class="msj">
            <h2>Imprimir Comprobante</h2>
           
        </div>
 
            <div class="cont"> 
                 <h3>¿Desea imprimir el comprobante?</h3>


           &nbsp;&nbsp;&nbsp;
           
           <asp:Button ID="Button1" runat="server" Text="Aceptar" CssClass="btn" Height="81px" Width="214px" />


           &nbsp;


           <asp:Label ID="LabelSi" runat="server" Text="Si" CssClass="auto-style1" ></asp:Label>
           
                <br />
                <br />
                <br />
                <br />
           &nbsp;&nbsp;
           <asp:Button ID="Button2" runat="server" Text="Aceptar"  CssClass="btn" Height="81px" Width="214px" />
     
     

           &nbsp;
     
     

           <asp:Label ID="LabelNo" runat="server" Text="No" CssClass="auto-style1"></asp:Label>
     
     

        </div>
        </form>
</body>
</html>