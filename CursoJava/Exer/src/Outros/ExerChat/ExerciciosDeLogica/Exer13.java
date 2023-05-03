/*
13. Escreva um programa que determine se um número é uma potência de 2.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer13 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num, numDiv = 0;

        System.out.print("Digite um número: ");
        num = sc.nextInt();

        for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
                numDiv++;
            }
        }

        if (numDiv == 2) {
            System.out.println("O número " + num + " é uma potência de 2.");
        } else {
            System.out.println("O número " + num + " não é uma potência de 2.");
        }
    }
}
