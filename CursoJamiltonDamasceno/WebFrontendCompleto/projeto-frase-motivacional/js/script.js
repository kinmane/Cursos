function gerarFraseMotivacional() {
    const frases = [
        "Acredite em você!",
        "Nunca desista dos seus sonhos.",
        "O sucesso é a soma de pequenos esforços.",
        "Você é mais forte do que imagina.",
        "Faça acontecer!",
        "Cada dia é uma nova chance.",
        "Seja a mudança que você deseja.",
        "Desafios te tornam mais forte.",
        "A persistência leva ao sucesso.",
        "Confie no seu potencial!"
    ]

    const numeroAleatorio = Math.floor(Math.random() * 10)
    const frase = frases[numeroAleatorio]

    document.getElementById('frase').innerHTML = frase
}
