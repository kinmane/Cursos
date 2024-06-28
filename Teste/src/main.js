
function calcular() {
  const homens = parseInt(document.getElementById('homens').value);
  const mulheres = parseInt(document.getElementById('mulheres').value);
  const criancas = parseInt(document.getElementById('criancas').value);

  const carne = (homens * 0.5) + (mulheres * 0.3) + (criancas * 0.2);
  const frango = (homens * 0.2) + (mulheres * 0.2) + (criancas * 0.1);
  const linguica = (homens * 0.2) + (mulheres * 0.2) + (criancas * 0.2);
  const refrigerante = (homens * 0.3) + (mulheres * 0.4) + (criancas * 0.2);
  const cerveja = (homens * 0.8) + (mulheres * 0.5);

  document.getElementById('carne').innerText = carne.toFixed(2) + ' kg de carne bovina';
  document.getElementById('frango').innerText = frango.toFixed(2) + ' kg de frango';
  document.getElementById('linguica').innerText = linguica.toFixed(2) + ' kg de linguiça';
  document.getElementById('refrigerante').innerText = refrigerante.toFixed(2) + ' l de refrigerante';
  document.getElementById('cerveja').innerText = cerveja.toFixed(2) + ' l de cerveja';
}
