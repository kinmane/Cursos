package com.br.softeli.exemplos.loops;

import java.util.Scanner;
/* - Desenvolva um gerador de tabuada, capaz de gerar a tabuada
 * de qualquer número inteiro entre 1 e 10.
 * - O usuário deve informar de qual número ele deseja ver na
 * tabuada.
 * 
 * A saída deve ser conforme o exemplo abaixo:
 * Tabuada de 5:
 * 5 x 1 = 5
 * 5 x 2 = 10
 * ...
 * 5 x 10 = 50
*/

public class Ex_Tabuada {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int numero;

        System.out.println("Tabuada:");
        numero = scan.nextInt();

        System.out.println("Tabuada de " + numero + ":");

        for (int index = 1; index <= 10; index+=1) {
            int multiplicacao = numero * index;
            
            System.out.println(numero + " x " + index + " = " + multiplicacao);
        }
    }
}
