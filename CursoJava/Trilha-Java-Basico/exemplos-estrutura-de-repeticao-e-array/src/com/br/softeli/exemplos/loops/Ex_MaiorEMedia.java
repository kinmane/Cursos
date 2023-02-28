package com.br.softeli.exemplos.loops;

import java.util.Scanner;
/*
- Faça um programa que leia 5 números
e informe o maior número
e a média desses números
*/

public class Ex_MaiorEMedia {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int numero;
        int contador = 0;
        int maior = 0;
        int soma = 0;

        do {            
            System.out.println("Número:");
            numero = scan.nextInt();
            
            if(numero > maior)
                maior = numero;
            
            soma = soma + numero;
            
            contador ++;
        } while (contador < 5);

        System.out.println("Maior: " + maior);
        System.out.println("Média: " + (soma/5));
    };
};
