

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Calculadora1.WebForms.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="icon" href="calculator (1).png"/>
    <title>Calculadora </title>

    <style type="text/css">
        .auto-style4 {
            width: 58px;
            height: 23px;
            text-align: center;
            border: thin;
        }

        .auto-style5 {
            width: 436px;
            height: 560px;
            box-shadow: 20px 30px 50px #000000;
        }

        .auto-style6 {
            width: 30px;
        }
    </style>

</head>
<body style="background-image: url('Background.jpg'); height: 214px; text-align: center;">
    <br />
    &nbsp;<div style="text-align: center;" >
        
        <table style="border: solid thin; margin: 0 auto; border-radius: 18px;" class="auto-style5">
            <tr style="text-align: center; border: thin;">
                <th style="text-align: center; background-color:#4a4949; border-start-start-radius: 18px; border-start-end-radius:18px; " class="auto-style6">
                    <img src="Woman.png" alt="Background" style="margin-top: -20px;margin-right: -130px;width:300px;height:300px;"/>                    
                    <img src="logo.png" alt="Logo" style="margin-top: -3000px;margin-bottom: 86px;margin-right: 244px;width: 170px;height: 170px;"/>

                </th>
            </tr>
            <tr style="border: thin;">
                <td style="border-top: solid; height: 290px; background-color: white; border-end-start-radius: 18px; border-end-end-radius: 18px;" class="auto-style4">

                    <h1 style="font-family: 'Area Neu'; font-size: 30px; margin-top: -20px; color: #47597E; text-shadow: 1px 3px #afadad;">USER LOGIN</h1>
                    <p style="font-family: 'Bree serif'; font-size: 21.8px; color: #444446; margin-top: -20.9px;">Welcome Back</p>
                    <form id="form1" runat="server">

                        <asp:TextBox name="TextBoxN" type="text" ID="TextBoxN" runat="server" placeholder="Entre su Usuario" Style="height: 31px; width: 265px; font-size: 24px; font-family: Bree serif;" OnTextChanged="TextBox1_TextChanged"> </asp:TextBox>

                        <br />
                        <br />
                        <asp:TextBox name="TextBox2" type="text" ID="TextBox2" runat="server" placeholder="Entre su Contraseña" Style="height: 31px; width: 265px; font-size: 24px; font-family: Bree serif;"> </asp:TextBox>
                        <br />
                        <br />
                        <asp:Button id="ButtonConfirmar" runat="server" type="submit" name="ButtonConfirmar" Text="LOGIN"  style="height:33px;width:116px;font-family: 'Area Neu';" OnClick="ButtonConfirmar_Click"/>                     
                        <asp:Button id="ButtonLimpiar" runat="server" type="submit" name="ButtonLimpiar"  Text="LIMPIAR"  style="height:33px;width:116px;font-family: 'Area Neu'; margin-left: 7px;" OnClick="ButtonLimpiar_Click"/>


                    </form>
                </td>

            </tr>
        </table>

    </div>

</body>
</html>
