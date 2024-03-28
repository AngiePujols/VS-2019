<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro11.aspx.cs" Inherits="Cajero.Registro11" %>


<!DOCTYPE html>
<!-- Created By CodingLab - www.codinglabweb.com -->
<html lang="en" dir="ltr">
  <head>
    <meta charset="UTF-8">
    <!---<title> Responsive Registration Form | CodingLab </title>--->
      <link href="StyleSheet2.css" rel="stylesheet" />
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

     
<asp:TextBox ID="TextBoxNombre" runat="server" placeholder="Digite su nombre" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>


          </div>
          <div class="input-box">

            <span class="details">Apellido</span>
            <asp:TextBox ID="TextBoxApellido" runat="server" placeholder="Digite su apellido" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>

          </div>

          <div class="input-box">

            <span class="details">Cédula</span>
    <asp:TextBox ID="TextBoxCedula" runat="server" placeholder="Digite su cédula" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
          </div>

          <div class="input-box">

            <span class="details">Fecha de nacimiento</span>
                  <asp:TextBox ID="TextBoxFechaN" runat="server" placeholder="Digite su fecha de nacimiento" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
           
          </div>

          <div class="input-box">
            <span class="details">Teléfono</span>
           
          <asp:TextBox ID="TextBoxTelefono" runat="server" placeholder="Digite su teléfono" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>
              
          </div>
          <div class="input-box">
            <span class="details">Dirección</span>
         
 <asp:TextBox ID="TextBoxDireccion" runat="server" placeholder="Digite su dirección" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>

          </div>

                      <div class="input-box">
            <span class="details">Email</span>
         
 <asp:TextBox ID="TextBoxEmail" runat="server" placeholder="Digite su email" autocomplete="off" required=""
    oninvalid="this.setCustomValidity('No pude dejar ningun campo vacio.')"
    oninput="this.setCustomValidity('')"></asp:TextBox>

          </div>
        </div>
        
        <div class="button">
        
              <asp:Button ID="ButtonAceptar" runat="server" Text="Aceptar" OnClick="ButtonAceptar_Click"  />
        </div>
      </form>
    </div>
  </div>

</body>
</html>
