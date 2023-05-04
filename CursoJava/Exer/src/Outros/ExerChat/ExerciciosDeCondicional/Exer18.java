/*
18. Escreva um programa que determine se um número é divisível por 3 e por 5.
 */

package Outros.ExerChat.ExerciciosDeCondicional;

import java.util.Scanner;

public class Exer18 {
    public static void main(String[] args) {
        double num1;

        Scanner sc = new Scanner(System.in);

        System.out.println("Informe um valor: ");
        num1 = sc.nextDouble();

        if (num1 % 3 == 0 && num1 % 5 == 0) {
            System.out.println("O número é divisível por 3 e por 5.");
        }
        else {
            System.out.println("O número não é divisível por 3 e por 5.");
        }
    }
}
