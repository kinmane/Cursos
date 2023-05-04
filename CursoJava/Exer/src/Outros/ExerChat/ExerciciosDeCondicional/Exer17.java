/*
17. Escreva um programa que determine o menor de três números.
 */

package Outros.ExerChat.ExerciciosDeCondicional;

import java.util.Scanner;

public class Exer17 {
    public static void main(String[] args) {
        int num1, num2, num3;

        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o primeiro valor: ");
        num1 = sc.nextInt();
        System.out.println("Informe o segundo valor: ");
        num2 = sc.nextInt();
        System.out.println("Informe o terceiro valor: ");
        num3 = sc.nextInt();

        if (num1 < num2 && num1 < num3) {
            System.out.println("O menor número é o " + num1);
        }
        else if (num2 < num1 && num2 < num3) {
            System.out.println("O menor número é o " + num2);
        }
        else {
            System.out.println("O menor número é o " + num3);
        }
    }
}
