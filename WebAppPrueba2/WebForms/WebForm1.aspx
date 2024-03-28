<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppPrueba2.WebForms.WebForm1" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Pagina Prueba </title>
    <style type="text/css">
        .auto-style1 {
            font-family: "KG HAPPY";
            font-size: large;
        }
        .auto-style2 {
            font-family: "Bite Chocolate";
        }
        .auto-style3 {
            font-size: xx-large;
        }
    </style>
    <script>
        function
    </script>

</head>
<body>

    <form id="form1" runat="server">
        <div >
            <h1 style="height: 134px; width: 1400px; background-image:url('https://marketplace.canva.com/EAD0ULvv4V4/1/0/1600w/canva-con-patrón-puesta-del-sol-playa-creativo-fondo-de-pantalla-de-escritorio-wIfWY0wk23Q.jpg');" class="auto-style2"> <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Calculadora</span> </h1>
        </div>

        <div style="text-align: center; background-color:antiquewhite;">
            <span class="auto-style1">
            <br />
                <label> Primer Número</label></span>
            <br />

            
                   <asp:TextBox ID="TextBox1"  runat="server"   Font-Names="Bree Serif" Font-Size="Medium" Height="24px" OnTextChanged="TextBox1_TextChanged" Width="116px" onkeypress='return event.charCode >= 45 && event.charCode <= 57' meta:resourcekey="TextBox1Resource1"></asp:TextBox>


            <br />
            <br />
            <span class="auto-style1">
            <label> Segundo Número</label></span>

            <br /> 
                <asp:TextBox ID="TextBox2" runat="server" Font-Names="Bree Serif" Font-Size="Medium" Height="23px" Width="116px" onkeypress='return event.charCode >= 45 && event.charCode <= 57' meta:resourcekey="TextBox2Resource1"></asp:TextBox>
            <br />
            <br />

           <asp:Button ID="Button" runat="server" Text="Sumar" Height="29px" Width="109px" BackColor="#FFFF99" BorderStyle="Dashed" Font-Bold="False" Font-Names="LEMON MILK" Font-Size="Medium" meta:resourcekey="ButtonResource1" />

            <br />

            <br />
            <asp:Label ID="LabelResultado" runat="server" Text="Resultado" Font-Italic="False" Font-Names="lemon milk,medium" Font-Size="Medium" meta:resourcekey="LabelResultadoResource1" ></asp:Label>
            
           

        </div>

        <br /> 

        <hr />
        <br class="auto-style1" />

    </form>
</body>
</html>
