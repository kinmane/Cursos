package com.br.softeli.exemplos.loops;

import java.util.Scanner;
/* Faça um programa que peça N números inteiros,
 * calcule e mostre a quantidade de números pares
 * e a quantidade de números impares. */

public class Ex_ParEImpar {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int quantidadeDeNumeros;
        int numero;
        int quantidadeImpar = 0;
        int quantidadePar = 0;
        int contador = 0;

        System.out.println("Deseja inserir quantos números?");
        quantidadeDeNumeros = scan.nextInt();

        do {
            System.out.println("Insira um número:");
            numero = scan.nextInt();
            if((numero % 2) == 0)
                quantidadePar ++;
            else
                quantidadeImpar ++;
            contador ++;
        } while (contador < quantidadeDeNumeros);
        
        System.out.println("Quantidade de número par: " + quantidadePar);
        System.out.println("Quantidade de número impar: " + quantidadeImpar);
    }
}
