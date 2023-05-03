/*
11. Escreva um programa que calcule o fatorial de um número.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer11 {
    public static void main(String[] args) {
        int num, fat = 1;

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número: ");
        num = sc.nextInt();

        for (int i = 1; i <= num; i++) {
            fat *= i;
        }

        System.out.println("O fatorial de " + num + " é " + fat);
    }
}
