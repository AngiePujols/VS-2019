<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Calculadora1.WebForms.WebForm4" %>

<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">

    <title>Numeros Game</title>

    <style>
      html {
        font-family: sans-serif;

      }

      body {
        width: 50%;
        max-width: 800px;
        min-width: 480px;
        margin: 0 auto;
       
      }

      .lastResult {
        color: white;
        padding: 3px;
      }

     
    </style>
  </head>

  <body style="background-color:lavenderblush">
    
  
      <h1 style="font-size: 40px">Adivina El Número</h1>
    <p style="font-size:18px;align-content:center;color:black">Hemos seleccionado un número aleatorio entre 1 y 10. Vea si puede adivinarlo en 3 turnos o menos. Le diremos si su conjetura fue demasiado alta o demasiado baja.</p>

    <div class="form">
      <label for="guessField">Entre Una Adivinanza: </label><input type="text" onkeypress="if ( isNaN(this.value + String.fromCharCode(event.keyCode) )) return false;" id     ="guessField" class="guessField">
      <input type="submit" value="Aceptar" class="guessSubmit">
    </div>

    <div class="resultParas">
      <p class="guesses"></p>
      <p class="lastResult"></p>
      <p class="lowOrHi"></p>
    </div>
       
    <script>
        let randomNumber = Math.floor(Math.random() * 10) + 1;
        const guesses = document.querySelector('.guesses');

        const lastResult = document.querySelector('.lastResult');
        const lowOrHi = document.querySelector('.lowOrHi');
        const guessSubmit = document.querySelector('.guessSubmit');
        const guessField = document.querySelector('.guessField');
        let guessCount = 1;
        let resetButton;

        function checkGuess() {
            const userGuess = Number(guessField.value);
            if (guessCount === 1) {
                guesses.textContent = 'Adivinanzas Anteriores: ';
            }

            guesses.textContent += userGuess + ' ';

            if (userGuess === randomNumber) {
                lastResult.textContent = 'Felicidades!!! Lo conseguiste!';
                lastResult.style.backgroundColor = 'green';
                lowOrHi.textContent = '';
                setGameOver();
            } else if (guessCount === 5) {
                lastResult.textContent = '!!!ACABÓ EL JUEGO!!!';
                lowOrHi.textContent = '';
                setGameOver();
            } else {
                lastResult.textContent = 'Incorrecto!';
                lastResult.style.backgroundColor = 'red';
                if (userGuess < randomNumber) {
                    lowOrHi.textContent = 'El último intento fue muy bajo!';
                } else if (userGuess > randomNumber) {
                    lowOrHi.textContent = 'El último intento fue muy alto!';
                }
            }

            guessCount++;
            guessField.value = '';
            guessField.focus();
        }

        guessSubmit.addEventListener('click', checkGuess);

        function setGameOver() {
            guessField.disabled = true;
            guessSubmit.disabled = true;
            resetButton = document.createElement('button');
            resetButton.textContent = 'Empezar un nuevo juego?';
            document.body.appendChild(resetButton);
            resetButton.addEventListener('click', resetGame);
        }

        function resetGame() {
            guessCount = 1;
            const resetParas = document.querySelectorAll('.resultParas p');
            for (const resetPara of resetParas) {
                resetPara.textContent = '';
            }

            resetButton.parentNode.removeChild(resetButton);
            guessField.disabled = false;
            guessSubmit.disabled = false;
            guessField.value = '';
            guessField.focus();
            lastResult.style.backgroundColor = 'white';
            randomNumber = Math.floor(Math.random() * 10) + 1;
        }
    </script>
  </body>
</html>