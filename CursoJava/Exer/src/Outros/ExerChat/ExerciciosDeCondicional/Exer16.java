/*
16. Escreva um programa que determine o maior de dois números.
 */

package Outros.ExerChat.ExerciciosDeCondicional;

import java.util.Scanner;

public class Exer16 {
    public static void main(String[] args) {
        int num1, num2;

        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o primeiro valor: ");
        num1 = sc.nextInt();
        System.out.println("Informe o segundo valor: ");
        num2 = sc.nextInt();

        if (num1 > num2) {
            System.out.println("O maior número é o " + num1);
        }
        else {
            System.out.println("O maior número é o " + num2);
        }
    }
}
