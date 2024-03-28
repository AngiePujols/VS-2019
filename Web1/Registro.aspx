<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Web1.WebForm3" %>
<!DOCTYPE html>

<html lang="en" dir="ltr">
  <head>
    <meta charset="UTF-8">

      <link href="StyleSheet3.css" rel="stylesheet" />
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
   </head>
<body>
  <div class="container">
    <div class="title">Registro</div>
    <div class="content">
      <form action="#" runat="server">
        <div class="user-details">
          <div class="input-box">
            <span class="details">Nombre</span>
              <asp:TextBox ID="TextBoxNo" runat="server" placeholder="Entre su nombre" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
          </div>
          <div class="input-box">
            <span class="details">Apellidos</span>
              <asp:TextBox ID="TextBoxAp" runat="server" placeholder="Entre sus apellidos" autocomplete="off" required=""
                  oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
                  oninput="this.setCustomValidity('')"></asp:TextBox>
          </div>
          <div class="input-box">
            <span class="details">Cedula</span>
            <asp:TextBox ID="TextBoxCedu" runat="server" placeholder="Entre su cedula" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
          </div>
          <div class="input-box">
            <span class="details">Fecha de Nacimiento</span>
           <asp:TextBox ID="TextBoxFechNa" runat="server" placeholder="Entre su fecha de nacimiento" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
          </div>
          <div class="input-box">
            <span class="details">Telefono</span>
            <asp:TextBox ID="TextBoxTel" runat="server" placeholder="Entre su telefono" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
          </div>
          <div class="input-box">
            <span class="details">Direccion</span>
            <asp:TextBox ID="TextBoxDir" runat="server" placeholder="Entre su direccion" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
          </div>
            <div class="input-box">
            <span class="details">Email</span>
            <asp:TextBox ID="TextBoxEmail" runat="server" placeholder="Entre su email" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
          </div>
        </div>
        <div class="button">
            <asp:Button ID="Aceptar" runat="server" Text="Aceptar" OnClick="Aceptar_Click" />
        </div>
      </form>
    </div>
  </div>

</body>
</html>
