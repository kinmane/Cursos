/*
23. Escreva um programa que determine se um número é primo ou não.
 */

package Outros.ExerChat.ExerciciosDeCondicional;

import java.util.Scanner;

public class Exer23 {
    public static void main(String[] args) {
        int num, cont = 0;

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número: ");
        num = sc.nextInt();

        for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
                cont++;
            }
        }

        if (cont == 2) {
            System.out.println("O número " + num + " é primo.");
        } else {
            System.out.println("O número " + num + " não é primo.");
        }
    }
}
