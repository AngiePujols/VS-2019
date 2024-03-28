<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Elegir monto.aspx.cs" Inherits="Cajero.Elegir_monto" %>



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
            text-align: center;
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
           width:190px;
           height:55px;
           border-radius:15px;



       }

       h2{
           color:#ffd800;
           font-size:40px;
           font-weight:bold;
           animation-iteration-count:infinite;
       }


        h3{
           color:#ffd800;
           font-size:30px;
           font-weight:bold;
           text-align:center;

        }

        .auto-style2 {
            color: #FFFFFF;
        }

        .auto-style3 {
            display: inline-block;
            font-weight: bold;
            line-height: 1.5;
            color: white;
            text-align: center;
            text-decoration: none;
            vertical-align: middle;
            cursor: pointer;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
            font-size: 25px;
            border-radius: 15px;
            transition: none;
            border: 1px solid transparent;
            padding: 20px;
            background: #EFAC3C;
            margin-top: 53px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cabeza">
          
            <asp:Label ID="Label1" runat="server" Text="BANCO INTERNACIONAL LIZ"></asp:Label>
            </div>

        <div class="msj">
            <h2 class="auto-style2">Digite su monto</h2>
           
        </div>
 
            <div class="cont"> 
                 <h3 class="auto-style2">Solo multiplos de 100</h3>



                <asp:TextBox ID="TextBox1" runat="server" placeholder="ej.1200" Height="40px" Width="200px" BorderStyle="Solid" ></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Labelmsj" runat="server" Text="" CssClass="auto-style2"></asp:Label>
                 <br />
                <asp:Button ID="Button2" runat="server" Text="Aceptar"  CssClass="auto-style3" OnClick="Button2_Click" Height="75px" Width="181px"/>

     

        </div>
        </form>
</body>
</html>