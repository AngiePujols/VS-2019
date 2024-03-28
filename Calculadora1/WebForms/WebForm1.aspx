<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculadora1.WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="icon" href="calculator (1).png"/>
    <title>Calculadora</title>
    <style type="text/css">
        
        html, body {
  width: 100%;
  height:100%;
}

body {
    background: linear-gradient(-45deg, #ee7752, #e73c7e, #23a6d5, #23d5ab);
    background-size: 400% 400%;
    animation: gradient 15s ease infinite;
}

@keyframes gradient {
    0% {
        background-position: 0% 50%;
    }
    50% {
        background-position: 100% 50%;
    }
    100% {
        background-position: 0% 50%;
    }
}

        *{
            margin:0;
            padding:0;
            box-sizing:border-box;
           
            font-family:sans-serif;
            outline:none;
        }

        .container {
            width: 360px;
            padding: 15px;
            margin:auto;
            margin-top:100px;
            justify-content:center;
            background: rgba(255, 255, 255, 0.05);
            border-radius: 6px;
            overflow: hidden;
            backdrop-filter: blur(15px);
            border-top: 1px solid rgba(255, 255, 255, 0.2);
            border-left: 1px solid rgba(255, 255, 255, 0.2);
            box-shadow: 5px 5px 30px rgba(0, 0, 0, 0.2);
           
        }

        .text{
            width:100%;
            height:100px;
            margin:0 3px;
            outline: none;
            border: none;
            background: transparent;
            color:#fff;
            text-align:right;
            font-size: 20px;
            padding-right:10px;




        }

       .calculadora {
    background-color: #5f635d;
    padding: 60px;
    border-radius: 30px;
    box-shadow: inset 5px 5px 12px #ffffff, 5px 5px 12px rgb(0 0 0 / 16%);
    display: grid;
    grid-template-columns: repeat(4,68px);
}

       

        .BtCL{

          height:65px;
          width: calc(100% / 5 - 6px);
          color:#fff;
          background:transparent;
          border-radius: 12px;
          outline:none;
          border:none;
          font-size:20px;
          cursor:pointer;
          transition:all 0.3s ease;
         
        }

        .BtCL:hover{

            background: #444444;

        }

        ::-webkit-input-placeholder { 
            color: white;
        }

        .Resultado{
           
        }

    </style>
    <script>
        
    </script>

</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <asp:TextBox ID="TextBox1" placeholder="0" runat="server" CssClass="text"></asp:TextBox>

            <div class="Botones">
                <asp:Button ID="BtRaiz" runat="server" Text="√" CssClass="BtCL" />
                <asp:Button ID="BtPorci" runat="server" Text="%" CssClass="BtCL" />
                <asp:Button ID="BtCL" runat="server" Text="C" CssClass="BtCL" OnClick="BtCL_Click" />
                <asp:Button ID="BtDEL" runat="server" Text="DEL" CssClass="BtCL" OnClick="BtDEL_Click" />
                <asp:Button ID="BtDiv" runat="server" Text="/" CssClass="BtCL" OnClick="BtDiv_Click" />


            </div>
            <div class="Botones">
                <asp:Button ID="Btx2" runat="server" Text= "X²" CssClass="BtCL" />
                <asp:Button ID="Bt7" runat="server" Text="7" CssClass="BtCL" OnClick="Bt7_Click"   />
                <asp:Button ID="Bt8" runat="server" Text="8" CssClass="BtCL" OnClick="Bt8_Click"  />
                <asp:Button ID="Bt9" runat="server" Text="9" CssClass="BtCL" OnClick="Bt9_Click"   />
                <asp:Button ID="BtPor" runat="server" Text="*" CssClass="BtCL" OnClick="BtPor_Click"  />


            </div>
            <div class="Botones">
                <asp:Button ID="Btx3" runat="server" Text= "X³" CssClass="BtCL" />
                <asp:Button ID="Bt4" runat="server" Text="4" CssClass="BtCL" OnClick="Bt4_Click" />
                <asp:Button ID="Bt5" runat="server" Text="5" CssClass="BtCL" OnClick="Bt5_Click"   />
                <asp:Button ID="Bt6" runat="server" Text="6" CssClass="BtCL" OnClick="Bt6_Click"  />
                <asp:Button ID="BtResta" runat="server" Text="-" CssClass="BtCL" OnClick="BtResta_Click"   />

            </div>
            <div class="Botones">
                <asp:Button ID="Bt1x" runat="server" Text= "1/x" CssClass="BtCL" />
                <asp:Button ID="Bt1" runat="server" Text="1" CssClass="BtCL" OnClick="Bt1_Click" />
                <asp:Button ID="Bt2" runat="server" Text="2" CssClass="BtCL" OnClick="Bt2_Click" />
                <asp:Button ID="Bt3" runat="server" Text="3" CssClass="BtCL" OnClick="Bt3_Click" />
                <asp:Button ID="BtSuma" runat="server" Text="+" CssClass="BtCL" OnClick="BtSuma_Click"   />

            </div>
            <div class="Botones">
                   <asp:Button ID="BtPi" runat="server" Text= "π" CssClass="BtCL" OnClick="BtPi_Click" />
                <asp:Button ID="BtSigno" runat="server" Text="±" CssClass="BtCL" OnClick="BtSigno_Click" />
                <asp:Button ID="Bt0" runat="server" Text="0" CssClass="BtCL" OnClick="Bt0_Click"   />
                <asp:Button ID="BtPunto" runat="server" Text="." CssClass="BtCL" OnClick="BtPunto_Click"   />
                <asp:Button ID="BtResultado" runat="server" Text="=" CssClass="BtCL" OnClick=" BtResultado_Click" />
            </div>
   
            
    </form>
  </div>
</body>
</html>

