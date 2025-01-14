﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Web1.WebForm3" %>

<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
    <meta name="generator" content="Hugo 0.88.1">
    <title>Fixed top navbar example · Bootstrap v5.1</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/5.1/examples/navbar-fixed/">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="StyleSheet2.css" rel="stylesheet" />

    <!-- Bootstrap core CSS -->
<link href="/docs/5.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
     <link href="StyleSheet2.css" rel="stylesheet" />

    <!-- Favicons -->
<link rel="apple-touch-icon" href="/docs/5.1/assets/img/favicons/apple-touch-icon.png" sizes="180x180">
<link rel="icon" href="/docs/5.1/assets/img/favicons/favicon-32x32.png" sizes="32x32" type="image/png">
<link rel="icon" href="/docs/5.1/assets/img/favicons/favicon-16x16.png" sizes="16x16" type="image/png">
<link rel="manifest" href="/docs/5.1/assets/img/favicons/manifest.json">
<link rel="mask-icon" href="/docs/5.1/assets/img/favicons/safari-pinned-tab.svg" color="#7952b3">
<link rel="icon" href="/docs/5.1/assets/img/favicons/favicon.ico">
<meta name="theme-color" content="#7952b3">


    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
      }

      @media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }
    </style>

    
    <!-- Custom styles for this template -->
    <link href="navbar-top-fixed.css" rel="stylesheet">
  </head>
  <body>
    
<nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">INICIO</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarCollapse">
      <ul class="navbar-nav me-auto mb-2 mb-md-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">NOSOTROS</a>
        </li>
        <li class="nav-item">
          <a class="nav-link active" href="#">CONTACTO</a>
        </li>
        <li class="nav-item">
          <a class="nav-link active">ACERCA DE</a>
        </li>
      </ul>
      <form class="d-flex">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav>

<main class="container">
  <div class="container bg-light p-5 rounded">
    <h1>BANCO INTERNACIONAL LUNA</h1>
    <p class="lead">This example is a quick exercise to illustrate how fixed to top navbar works. As you scroll, it will remain fixed to the top of your browser’s viewport.</p>
    
  </div>

</main>
          <form id="form1" runat="server" class="wrapper">
      <div class="contenedor">
          <div class="row">
              <div Class="gpderecha"> 
              <div class="input-group mb-5">
          
          <asp:Button ID="Aceptar" runat="server" Text="Aceptar"  CssClass="btn btn-success"/>
          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                  </div>

                    <div class="input-group mb-5">
          
          <asp:Button ID="Button1" runat="server" Text="Aceptar" CssClass="btn btn-success"/>
          <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                  </div>

                    <div class="input-group mb-5">
          
          <asp:Button ID="Button2" runat="server" Text="Aceptar" CssClass="btn btn-success"/>
          <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                  </div>

                    <div class="input-group mb-5">
          
          <asp:Button ID="Button3" runat="server" Text="Aceptar" CssClass="btn btn-success"/>
          <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                  </div>

                  </div>


                  

                        <div class="gpizquierda"> 

                     <div class="input-group mb-5">

          <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
          <asp:Button ID="Button4" runat="server" Text="Aceptar" CssClass="btn btn-success"/>

                  </div>

                    <div class="input-group mb-5">
           <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>         
          <asp:Button ID="Button5" runat="server" Text="Aceptar" CssClass="btn btn-success"/>

                  </div>

                    <div class="input-group mb-5">

          <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>          
          <asp:Button ID="Button6" runat="server" Text="Aceptar" CssClass="btn btn-success"/>

                  </div>

                    <div class="input-group mb-5">
           <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>         
          <asp:Button ID="Button7" runat="server" Text="Aceptar" CssClass="btn btn-success"/>

                  </div>
                   </div>

            
  
        

              </div>
      </div>

              </form>
    <script src="/docs/5.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

      
  </body>
</html>