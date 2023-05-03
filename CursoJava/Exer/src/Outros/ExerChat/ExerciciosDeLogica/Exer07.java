/*
7. Escreva um programa que calcule a raiz quadrada de um número.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer07 {
    public static void main(String[] args) {
        double num, squareRoot;

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite um número: ");
        num = sc.nextDouble();

        squareRoot = Math.sqrt(num);

        System.out.println("A raiz quadrada de " + num + " é " + squareRoot);
    }
}
