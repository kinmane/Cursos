package com.br.softeli.exemplos.loops;

import java.util.Scanner;
/* - Faça um programa que leia conjunto de dois valores, o
primeiro representando o nome do aluno e o segundo a sua idade.
- (Pare o programa inserindo o valor 0 no campo nome.) */

public class Ex_NomeIdade {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        
        String nome;
        int idade;
            
        while(true) {
            System.out.println("DIGITE SEU NOME:");
            
            nome = scan.next();
            // Responsável por capturar o nome pelo terminal.
            
            if (nome.equals("0")) break;
            
            System.out.println("DIGITE SUA IDADE:");
            
            idade = scan.nextInt();
            // Responsável por capturar a idade pelo terminal.
   
            System.out.println(nome + " tem " + idade + " anos.");
        };
    };
};

