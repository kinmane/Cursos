/*
1. Escreva um programa que determine se um número é par ou ímpar.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer01 {
    public static void main(String[] args) {
        int num;

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite um número: ");
        num = sc.nextInt();

        if (num % 2 == 0) {
            System.out.println("O número é par.");
        }
        else {
            System.out.println("O número é ímpar.");
        }
    }
}
