/*
12. Escreva um programa que determine se um número é perfeito ou não.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer12 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num, numSum = 0;

        System.out.print("Digite um número: ");
        num = sc.nextInt();

        for (int i = 1; i < num; i++) {
            if (num % i == 0) {
                numSum += i;
            }
        }

        if (numSum == num) {
            System.out.println("O número " + num + " é perfeito.");
        } else {
            System.out.println("O número " + num + " não é perfeito.");
        }
    }
}
