from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import pyautogui
import time

driver = webdriver.Edge()

def enviar_mensagem(numero, mensagem):
    driver.get('https://web.whatsapp.com')

    input("Pressione Enter após fazer o login no WhatsApp Web...")

    campo_pesquisa = driver.find_element(By.XPATH, '//div[@contenteditable="true"][@data-tab="3"]')
    campo_pesquisa.send_keys(numero)
    campo_pesquisa.send_keys(Keys.ENTER)

    WebDriverWait(driver, 30).until(EC.presence_of_element_located((By.XPATH, '//div[@contenteditable="true"][@data-tab="1"]')))

    campo_mensagem = driver.find_element(By.XPATH, '//div[@contenteditable="true"][@data-tab="1"]')

    campo_mensagem.click()
    time.sleep(2)

    pyautogui.typewrite(mensagem, interval=0.1)

    pyautogui.press("enter")

numero_cliente = 'Jonvitu'
mensagem_inicial = "Olá! Escolha uma opção:\n1 - Opção 1\n2 - Opção 2\n3 - Opção 3\n"

enviar_mensagem(numero_cliente, mensagem_inicial)
