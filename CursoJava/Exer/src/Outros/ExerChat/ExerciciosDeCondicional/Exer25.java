/*
25. Escreva um programa que determine se um número é divisível por 2 e por 3.
 */

package Outros.ExerChat.ExerciciosDeCondicional;

import java.util.Scanner;

public class Exer25 {
    public static void main(String[] args) {
        int num;

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número: ");
        num = sc.nextInt();

        if (num % 2 == 0 && num % 3 == 0) {
            System.out.println("O número " + num + " é divisível por 2 e por 3.");
        } else {
            System.out.println("O número " + num + " não é divisível por 2 e por 3.");
        }
    }
}
