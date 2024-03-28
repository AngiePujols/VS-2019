<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Idioma.aspx.cs" Inherits="Cajero.Idioma" %>

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
            text-align: right;
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
       #Button1{
           background:#c46ee1;
           color:white;
           font-size:25px;
           font-weight:bold;
           width:220px;
           height:70px;
           border-radius:15px;
           padding:20px;

       }

        .msj {
            text-align: center;
            border: 3px solid#EFAC3C;
            width: 50%;
            margin: auto;
            background: #163354;


       }

       .btn{
           color:white;
           background:#EFAC3C;
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
           color:#ffd800;
           font-size:40px;
           font-weight:bold;
           animation-iteration-count:infinite;
       }


        .auto-style2 {
            font-size: xx-large;
            color: #FFFFFF;
        }
        .auto-style3 {
            color: #FFFFFF;
        }
        .auto-style5 {
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
            font-size: 26px;
            border-radius: 4px;
            transition: none;
            width: 200px;
            height: 60px;
            border: 1px solid transparent;
            margin-left: 30px;
            margin-right: 12px;
            margin-top: 0px;
            background: #EFAC3C;
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cabeza">
          
            <asp:Label ID="Label1" runat="server" Text="BANCO INTERNACIONAL LIZ"></asp:Label>
            </div>



        <div class="msj">
            <h2 class="auto-style3">Seleccione un idioma</h2>
            <h2 class="auto-style3">Select a language</h2>
        </div>
 
            <div class="cont"> 

                <div class="gp1">
                     <strong>
                    <br />
                    <br />
                     <br />
                    <asp:Label ID="LabelEspanol" runat="server" Text="Español" CssClass="auto-style2" ></asp:Label>
                    <asp:Button ID="ButtonAceptar1" runat="server" Text="Aceptar" CssClass="auto-style5" OnClick="ButtonAceptar1_Click" />
                    <br />
                    <br />
                    <br />
                    <br />
                     </strong>
                </div>

                 <div class="gp2">
                     <strong>
                    <asp:Label ID="LabelIngles" runat="server" Text="English" CssClass="auto-style2"></asp:Label>
                    &nbsp;
                    <asp:Button ID="ButtonAceptar2" runat="server" Text="Aceptar" CssClass="auto-style5"  />
                     </strong>
                </div>
            
       

        </div>
        </form>
</body>
</html>