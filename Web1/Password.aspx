<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Password.aspx.cs" Inherits="Web1.WebForm6" %>

<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="UTF-8">
      <link href="StyleSheet5.css" rel="stylesheet" />
   </head>
<body>
  <div class="main_div">
    <div class="title">CAMBIAR CONTRASEÑA</div>
      <form id="form1" runat="server">

      <div class="input_box">
          <asp:TextBox ID="TextBoxE2" requerid="" runat="server" placeholder="Usuario / Email" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
      </div>
        
      <div  class="input_box">
          <asp:TextBox ID="TextBoxP2" runat="server" placeholder="Ingrese su nueva contraseña" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
     </div>
          
       <br />

     
      <div class="input_box button">
          <asp:Button ID="ButtonA2" runat="server" Text="Aceptar" OnClick="ButtonA2_Click"  />
      </div>
      </form>
  </div>
  
</body>
</html>