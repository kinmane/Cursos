package com.br.softeli.exemplos.loops;

import java.util.Scanner;
/* Faça um programa que calcule o fatorial
de um número inteiro fornecido pelo usuário. */

public class Ex_Fatorial {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int fatorial;
        int multiplicacao = 1;
        
        System.out.println("Fatorial:");
        fatorial = scan.nextInt();
    
        for(int index = fatorial; index >= 1; index -= 1) {
            multiplicacao = multiplicacao * index;
        }  

        System.out.println(fatorial + "! = " + multiplicacao);
    }
}
