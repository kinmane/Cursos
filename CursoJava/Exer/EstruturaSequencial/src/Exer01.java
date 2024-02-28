/*
Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
mensagem explicativa, conforme exemplos
*/

import java.util.Scanner;

public class Exer01 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int numero01, numero02;

        System.out.println("Digite o primeiro valor inteiro: ");
        numero01 = sc.nextInt();

        System.out.println("Digite o segundo valor inteiro: ");
        numero02 = sc.nextInt();

        System.out.println("SOMA = " + (numero01 + numero02));
		
		sc.close();

    }
}