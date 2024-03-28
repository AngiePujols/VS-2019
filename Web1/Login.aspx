<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web1.WebForm5" %>

<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="UTF-8">
   
      <link href="StyleSheet4.css" rel="stylesheet" />
   </head>
<body>
  <div class="main_div">
    <div class="title">Login</div>
      <form id="form1" runat="server">
      <div class="input_box">
          <asp:TextBox ID="TextBoxEmail" requerid="" runat="server" placeholder="Usuario / Email" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
      </div>
        
      <div  class="input_box">
          <asp:TextBox ID="TextBoxPass" runat="server"  TextMode="Password" placeholder="Contraseña" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
     </div>
       <br />
        <input type="checkbox" onclick="myFunction()"> Mostrar Contraseña
   
  <script>
        function myFunction() {
            var x = document.getElementById("TextBoxPass");
            if (x.type === "password") {
                x.type = "text";
            } else {
                x.type = "password";
            }
        }

</script>
     
      <div class="input_box button">
          <asp:Button ID="ButtonAceptar" runat="server" Text="Login" OnClick="ButtonAceptar_Click" />
      </div>
      <div class="sign_up">
        No tienes cuenta? <a href="Registro.aspx">Registrate</a>
      </div>
      </form>
  </div>
  
</body>
</html>
