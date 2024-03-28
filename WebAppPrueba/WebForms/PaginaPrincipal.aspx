<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="WebAppPrueba.WebForms.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Pagina Prueba </title>
</head>
<body style="height: 395px">
    <form id="form1" runat="server">
        <div >
            <h1 style="text-align: center"> Hola Mundo!!!</h1>
            <p style="text-align: center"> Este seria el parrafo?</p>
        </div>

        <br /> 
        <hr />
        <br />

        <div style="text-align: center">
            <label font-family="KG HAPPY"> Primer Número</label>
            <br />

            
              <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="133px"></asp:TextBox>
            <label> 
            <br />
            <br />
            Segundo Número</label>
            <br />
                <asp:TextBox ID="TextBox2" runat="server" Height="26px" style="margin-left: 0px" Width="129px"></asp:TextBox>
            <br />

            <br />

            <asp:Button ID="BtSumar" runat="server" Text="Sumar" BackColor="#CC99FF" ForeColor="Black" OnClick="Button1_Click" Width="168px" Height="26px" />

            <br />
            <br />
            <asp:Label ID="LabelResultado" runat="server" Text="Resultado" ></asp:Label>
            
           

        </div>

    </form>
</body>
</html>