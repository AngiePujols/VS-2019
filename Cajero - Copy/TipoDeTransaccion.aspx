<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TipoDeTransaccion.aspx.cs" Inherits="Cajero.TipoDeTransaccion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body{
            background:#163354;
        }
                .logo{
             width:50%;
            margin:auto;
            border:3px solid #EFAC3C;
            height:120px;
        }

        .cabeza{
            background:#EFAC3C;
            color:white;
            width:100%;
            height:30%;
            font-size:30px;
            font-weight:bold;
            font-family: "Verdana";
            padding:20px;

        }

        .cuerpo{
            width:60%;
            background:#c46ee1;
            margin:auto;
            text-align:center;
            border: 5px solid#9919be;
        }

             h2{
         color:#3588ee;
         font-size:40px;
         font-weight:bold;
         animation-iteration-count:infinite;
        
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
   .btn{
           background:#EFAC3C;
           color:white;
           font-size:25px;
           font-weight:bold;
           width:220px;
           height:70px;
           border-radius:15px;
           padding:10px;

       }
         .msj{
         text-align:center;
         margin:auto;
         width:50%;
         border:3px solid#EFAC3C;
         background-color:brown;

     }
            .cont {
            width: 50%;
            height: 400px;
            margin: auto;
            border: 3px solid#EFAC3C;
            text-align: right;
        }
        .auto-style1 {
            text-align: center;
            color: #FFFFFF;
        }
        .auto-style2 {
            color: #FFFFFF;
            font-size: x-large;
        }
        .auto-style3 {
            text-align: center;
            color: #FFFFFF;
            font-size: x-large;
        }
        .auto-style4 {
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
            width: 220px;
            height: 70px;
            border: 1px solid transparent;
            margin-right: 0;
            padding: 10px;
            background: #EFAC3C;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cabeza">
          
            <asp:Label ID="Label1" runat="server" Text="BANCO INTERNACIONAL LIZ"></asp:Label>
            </div>
        <div class="logo">
    <h2 class="auto-style1">Seleccione una opción</h2>
            </div>
     <div class ="cont">
 <div class="gp1">
         <br />
         <br />
         <strong>
         <br />
         <asp:Label ID="LabelRetiro" runat="server" Text="Retiro" CssClass="auto-style2"></asp:Label>
         &nbsp;&nbsp; </strong>
         <asp:Button ID="Button1" runat="server" Text="Aceptar" CssClass="auto-style4" OnClick="Button1_Click"/>
         &nbsp;&nbsp;&nbsp;&nbsp;
         <br />
         <br />
     </div>
                <div class="gp2">
                    <strong>
                    <asp:Label ID="LabelVerBalance" runat="server" Text="Ver balance" CssClass="auto-style3" ></asp:Label>
                    &nbsp;&nbsp;
                    </strong>
                    <asp:Button ID="ButtonAceptar1" runat="server" Text="Aceptar" CssClass="btn" OnClick="ButtonAceptar1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                </div>

                 <div class="gp3">
                     <strong>
                    <asp:Label ID="LabelDeposito" runat="server" Text="Deposito" CssClass="auto-style3"></asp:Label>
                     &nbsp;&nbsp;
                     </strong>
                    <asp:Button ID="ButtonAceptar2" runat="server" Text="Aceptar" CssClass="btn" OnClick="ButtonAceptar2_Click"  />
                &nbsp;&nbsp;&nbsp;&nbsp;
                </div>
            
     </div>
        </form>
</body>
</html>
