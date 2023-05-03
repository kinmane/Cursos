/*
9. Escreva um programa que calcule o máximo divisor comum (MDC) de dois números.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer09 {
    public static void main(String[] args) {
        int num1, num2, mdc = 0;

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o primeiro número: ");
        num1 = sc.nextInt();

        System.out.print("Digite o segundo número: ");
        num2 = sc.nextInt();

        for (int i = 1; i <= num1; i++) {
            if (num1 % i == 0 && num2 % i == 0) {
                mdc = i;
            }
        }

        System.out.println("O MDC de " + num1 + " e " + num2 + " é " + mdc + ".");
    }
}
