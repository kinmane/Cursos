const puppeteer = require('puppeteer');

async function enviarMensagem(numero, mensagem) {
    const browser = await puppeteer.launch({ headless: false }); // Abre o navegador visível para interação
    const page = await browser.newPage();
    await page.goto('https://web.whatsapp.com/', { waitUntil: 'networkidle0' });

    // Aguarde o usuário fazer o login escaneando o código QR manualmente
    console.log('Aguardando o login. Escaneie o código QR manualmente no WhatsApp Web.');
    await page.waitForFunction('document.querySelector("._2aBzC")');

    console.log('Login concluído. Enviando mensagem...');
    await page.waitForTimeout(2000);

    // Busca o campo de pesquisa
    const campoPesquisa = await page.$('._2_1wd[data-tab="3"]');
    await campoPesquisa.click();

    // Digita o número do contato
    await page.keyboard.type(numero);
    await page.waitForTimeout(1000);

    // Clica no contato
    await page.keyboard.press('Enter');
    await page.waitForTimeout(1000);

    // Busca o campo de mensagem
    const campoMensagem = await page.$('div[contenteditable="true"][data-tab="1"]');
    await campoMensagem.click();

    // Digita a mensagem
    await page.keyboard.type(mensagem);
    await page.waitForTimeout(1000);

    // Clica no botão de enviar
    await page.keyboard.press('Enter');
    await page.waitForTimeout(2000);

    console.log('Mensagem enviada com sucesso!');

    // Fechar o navegador
    await browser.close();
}

// Número do cliente e mensagem inicial
const numeroCliente = 'Jonvitu';
const mensagemInicial = 'teste';

// Chamar a função para enviar a mensagem
enviarMensagem(numeroCliente, mensagemInicial);
