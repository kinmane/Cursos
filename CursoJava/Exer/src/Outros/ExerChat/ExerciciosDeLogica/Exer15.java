/*
15. Escreva um programa que determine se um número é triangular.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer15 {
    public static void main(String[] args) {
        int num, numSum = 0, i = 1;

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite um número: ");
        num = sc.nextInt();

        while (numSum < num) {
            numSum += i;
            i++;
        }

        if (numSum == num) {
            System.out.println("O número é triangular.");
        }
        else {
            System.out.println("O número não é triangular.");
        }
    }
}
