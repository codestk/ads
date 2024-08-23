// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




document.addEventListener('DOMContentLoaded', function () {
 //Validate Dude
  const blockInvalidChar = (e) => {
    if (['e', 'E', '+', '-'].includes(e.key)) {
      e.preventDefault();
    }
  };

  document.querySelector('input[type="number"]').addEventListener('keydown', blockInvalidChar);

});
 