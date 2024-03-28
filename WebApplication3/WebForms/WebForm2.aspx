<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForms.WebForm2" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="icon" href="calculator (1).png"/>
    <title>Calculadora </title>

    <style type="text/css">
        @font-face {
  font-family: Clip;
  src: url("https://acupoftee.github.io/fonts/Clip.ttf");
}

body {
  background-color: #141114;
  background-image: linear-gradient(335deg, black 23px, transparent 23px),
    linear-gradient(155deg, black 23px, transparent 23px),
    linear-gradient(335deg, black 23px, transparent 23px),
    linear-gradient(155deg, black 23px, transparent 23px);
  background-size: 58px 58px;
  background-position: 0px 2px, 4px 35px, 29px 31px, 34px 6px;
}

.sign {
  position: absolute;
  display: flex;
  justify-content: center;
  align-items: center;
  width: 50%;
  height: 50%;
  background-image: radial-gradient(
    ellipse 50% 35% at 50% 50%,
    #6b1839,
    transparent
  );
  transform: translate(-50%, -50%);
  letter-spacing: 2px;
  left: 50%;
  top: 10%;
  font-family:'Budmo Jiggler';
  text-transform: uppercase;
  font-size: 6em;
  color: #ffe6ff;
  text-shadow: 0 0 0.6rem #ffe6ff, 0 0 1.5rem #ff65bd,
    -0.2rem 0.1rem 1rem #ff65bd, 0.2rem 0.1rem 1rem #ff65bd,
    0 -0.5rem 2rem #ff2483, 0 0.5rem 3rem #ff2483;
  animation: shine 2s forwards, flicker 3s infinite;
}

@keyframes blink {
  0%,
  22%,
  36%,
  75% {
    color: #ffe6ff;
    text-shadow: 0 0 0.6rem #ffe6ff, 0 0 1.5rem #ff65bd,
      -0.2rem 0.1rem 1rem #ff65bd, 0.2rem 0.1rem 1rem #ff65bd,
      0 -0.5rem 2rem #ff2483, 0 0.5rem 3rem #ff2483;
  }
  28%,
  33% {
    color: #ff65bd;
    text-shadow: none;
  }
  82%,
  97% {
    color: #ff2483;
    text-shadow: none;
  }
}

.flicker {
  animation: shine 2s forwards, blink 3s 2s infinite;
}

.fast-flicker {
  animation: shine 2s forwards, blink 10s 1s infinite;
}

@keyframes shine {
  0% {
    color: #6b1839;
    text-shadow: none;
  }
  100% {
    color: #ffe6ff;
    text-shadow: 0 0 0.6rem #ffe6ff, 0 0 1.5rem #ff65bd,
      -0.2rem 0.1rem 1rem #ff65bd, 0.2rem 0.1rem 1rem #ff65bd,
      0 -0.5rem 2rem #ff2483, 0 0.5rem 3rem #ff2483;
  }
}

@keyframes flicker {
  from {
    opacity: 1;
  }

  4% {
    opacity: 0.9;
  }

  6% {
    opacity: 0.85;
  }

  8% {
    opacity: 0.95;
  }

  10% {
    opacity: 0.9;
  }

  11% {
    opacity: 0.922;
  }

  12% {
    opacity: 0.9;
  }

  14% {
    opacity: 0.95;
  }

  16% {
    opacity: 0.98;
  }

  17% {
    opacity: 0.9;
  }

  19% {
    opacity: 0.93;
  }

  20% {
    opacity: 0.99;
  }

  24% {
    opacity: 1;
  }

  26% {
    opacity: 0.94;
  }

  28% {
    opacity: 0.98;
  }

  37% {
    opacity: 0.93;
  }

  38% {
    opacity: 0.5;
  }

  39% {
    opacity: 0.96;
  }

  42% {
    opacity: 1;
  }

  44% {
    opacity: 0.97;
  }

  46% {
    opacity: 0.94;
  }

  56% {
    opacity: 0.9;
  }

  58% {
    opacity: 0.9;
  }

  60% {
    opacity: 0.99;
  }

  68% {
    opacity: 1;
  }

  70% {
    opacity: 0.9;
  }

  72% {
    opacity: 0.95;
  }

  93% {
    opacity: 0.93;
  }

  95% {
    opacity: 0.95;
  }

  97% {
    opacity: 0.93;
  }

  to {
    opacity: 1;
  }
}
        
        .auto-style1 {
            width: 424px;
        }
        
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: center;
        }
        
        .auto-style4 {
            height: 393px;
        }
        
        </style>

</head>
<body style="background-image: url('Background.jpg'); height: 214px; text-align: center;">
    <div class="sign">
      <span class="fast-flicker">Cal</span>cul<span class="flicker">ado</span>ra
       </div>
         
       <form id="form1" runat="server">
        
             <div >
            <h1 style="height: 134px; width: 2000px; background-color:#2B2B2B; margin-left: -10px;" class="auto-style2"> <span class="auto-style3"></span> </h1>
        </div>

        <div style="text-align: center; background-color:antiquewhite;" class="auto-style4">
            <span class="auto-style1">
            <br />
                <label style="font-family:'Area Neu'; font-size:22px"> Primer Número</label></span>
            <br />

                    <asp:TextBox ID="TextBoxNum1" runat="server" Font-Names="Bree Serif" Font-Size="Medium" Height="26px" Width="135px" onkeypress='return event.charCode >= 45 && event.charCode <= 57'></asp:TextBox>   

               


            <br />
            <br />
            <span class="auto-style1">
            <label style="font-family:'Area Neu'; font-size:22px"> Segundo Número</label></span>

            <br /> 
                <asp:TextBox ID="TextBoxNum2" runat="server" Font-Names="Bree Serif" Font-Size="Medium" Height="26px" Width="135px" onkeypress='return event.charCode >= 45 && event.charCode <= 57'></asp:TextBox>
            <br />
            <br />

            <fieldset class="auto-style1" style="text-align: center; margin-left: 530px;">
        <legend class="auto-style3">Elige una Operación</legend>
        <label>
            <asp:RadioButton ID="RadioSuma" runat="server" type="radio"  GroupName="Opera" value="Suma" Text="Suma" OnCheckedChanged="RadioSuma_CheckedChanged" > </asp:RadioButton>
            <asp:RadioButton ID="RadioResta" runat="server" type="radio" GroupName="Opera" value="Resta" Text="Resta" OnCheckedChanged="RadioResta_CheckedChanged"></asp:RadioButton>
            <asp:RadioButton ID="RadioMulti" type="radio" runat="server" GroupName="Opera" value="Multiplicación" Text="Multiplicación" OnCheckedChanged="RadioMulti_CheckedChanged"></asp:RadioButton>
            <asp:RadioButton  ID="RadioDivi" type="radio" runat="server" GroupName="Opera" value="División" Text="División" OnCheckedChanged="RadioDivi_CheckedChanged"></asp:RadioButton>
                    
                </label>
    </fieldset>
   
   
            <br />

            <asp:Button ID="Button" runat="server" Text="Calcular" Height="29px" Width="109px" BackColor="#FFFF99" BorderStyle="Dashed" Font-Bold="False" Font-Names="LEMON MILK" Font-Size="Medium" meta:resourcekey="ButtonResource1" OnClick="Button_Click" />
            
         
            <br />
            <br />
            <asp:Label ID="LabelResultado" runat="server" Text="Resultado" Font-Italic="False" Font-Names="lemon milk,medium" Font-Size="23px" meta:resourcekey="LabelResultadoResource1" ></asp:Label>
            
           

        </div>

        <br /> 

        <hr />
        <br class="auto-style1" />

    </form>
</body>
</html>

