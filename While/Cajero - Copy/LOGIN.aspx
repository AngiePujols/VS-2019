<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN.aspx.cs" Inherits="Cajero.WebForm1" %>

<!DOCTYPE html>
<!-- Coding by CodingLab | www.codinglabweb.com-->
<html lang="en" dir="ltr">
  <head>
    <meta charset="UTF-8">
    <!--<title> Login and Registration Form in HTML & CSS | CodingLab </title>-->
      <link href="StyleSheet1.css" rel="stylesheet" />

    <!-- Fontawesome CDN Link -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <style type="text/css">
          .auto-style1 {
              color: #FF0000;
          }
      </style>
   </head>

<body>
  <div class="container">
    <input type="checkbox" id="flip">
    <div class="cover">
      <div class="front">

        <!--<img src="images/frontImg.jpg" alt="">-->
        <div class="text">
          <span class="text-1">Todo nuevo amigo es una <br> nueva aventura</span>
          <span class="text-2">¡Vamos a conectarnos!</span>
        </div>
      </div>
      <div class="back">

        <!--<img class="backImg" src="images/backImg.jpg" alt="">-->
     

      </div>
    </div>

    <div class="forms">
        <div class="form-content">
          <div class="login-form">
            <div class="title">Login</div>
          <form action="#" runat="server">
            <div class="input-boxes">
              <div class="input-box">
                <i class="fas fa-envelope"></i>

  
                  <asp:TextBox ID="TextBoxUser" runat="server" placeholder="Digite su usuario" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>

              </div>
              <div class="input-box">
                <i class="fas fa-lock"></i>
                                 <asp:TextBox ID="TextBoxContraseña" TextMode="Password" runat="server" placeholder="Digite su contraseña" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>


              </div>

                 <div class="text sign-up-text"> 
                     <asp:Label ID="Info" runat="server" Text="" CssClass="auto-style1"></asp:Label>
                     </div>
              <div class="button input-box">
        
                  <asp:Button ID="ButtonAceptar" runat="server" Text="Aceptar" OnClick="ButtonAceptar_Click" />
            </div>
              <div class="text sign-up-text">No tienes una cuenta? <a href="Registro11.aspx">Registrate ahora</a>
                
            </div>
        </form>
      </div>
    </div>
    </div>
  </div>
</body>
</html>
