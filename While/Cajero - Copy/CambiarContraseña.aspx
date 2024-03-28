<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="Cajero.WebForm2" %>


<!DOCTYPE html>
<!-- Created By CodingLab - www.codinglabweb.com -->
<html lang="en" dir="ltr">
  <head>
    <meta charset="UTF-8">
    <!---<title> Responsive Registration Form | CodingLab </title>--->
      <link href="StyleSheet2.css" rel="stylesheet" />
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
      <style type="text/css">
          .auto-style1 {
              color: #FFFFFF;
          }
          .auto-style2 {
              color: #FF0000;
          }
      </style>
    
   </head>
<body>
        

  <div class="container">

    <div class="title">Cambiar contraseña</div>

    <div class="content">
      <form action="#" runat="server">
    

            <div class="input-box">
                <asp:Label ID="LabelUser" runat="server" Text="Label" CssClass="auto-style1"></asp:Label>
              </div>
              <div class="user-details">
          <div class="input-box">
            <span class="details">Nueva contraseña</span>

     
<asp:TextBox ID="TextBoxContrasena" runat="server" TextMode="Password" placeholder="Digite la contraseña" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>


          </div>
          <div class="input-box">
          
            <span class="details">Confirmar contraseña</span>
            <asp:TextBox ID="TextBoxcontrasenaC" runat="server" TextMode="Password" placeholder="Digite de nuevo la contraseña" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>

          </div>
                     <div class="input-box">
                         <asp:Label ID="Info" runat="server" Text="*La nueva contraseña no coincide con la confirmación de esta*" CssClass="auto-style2" Visible="False"></asp:Label>
                         </div>
          
        <div class="input-box button">
        
              <asp:Button ID="ButtonAceptar" runat="server" Text="Aceptar" OnClick="ButtonAceptar_Click"  />
        </div>
      </form>
    </div>
  </div>

</body>
</html>
