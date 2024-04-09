function clock() {
  function getTimeFromSeconds(segundos) {
    const data = new Date(segundos * 1000);
    return data.toLocaleTimeString('pt-BR', {
      hour12: false,
      timeZone: 'GMT'
    });
  }

  const relogio = document.querySelector('.relogio');
  let segundos = 0;
  let timer;

  function timeStart() {
    timer = setInterval(function() {
      segundos++;
      relogio.innerHTML = getTimeFromSeconds(segundos);
    }, 1000);
  }

  document.addEventListener('click', function(event) {
    const element = event.target;

    if (element.classList.contains('iniciar')) {
      relogio.classList.remove('pausado');
      clearInterval(timer);
      timeStart();
    }

    if (element.classList.contains('pausar')) {
      clearInterval(timer);
      relogio.classList.add('pausado');
    }

    if (element.classList.contains('zerar')) {
      relogio.classList.remove('pausado');
      clearInterval(timer);
      relogio.innerHTML = '00:00:00';
      segundos = 0;
    }
  });
}
clock();