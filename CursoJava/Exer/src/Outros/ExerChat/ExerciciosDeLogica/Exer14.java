/*
14. Escreva um programa que determine se dois números são amigos.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer14 {
    public static void main(String[] args) {
        int num1, num2, soma1 = 0, soma2 = 0;

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o primeiro número: ");
        num1 = sc.nextInt();
        System.out.println("Digite o segundo número: ");

        num2 = sc.nextInt();

        for (int i = 1; i < num1; i++) {
            if (num1 % i == 0) {
                soma1 += i;
            }
        }

        for (int i = 1; i < num2; i++) {
            if (num2 % i == 0) {
                soma2 += i;
            }
        }

        if (soma1 == num2 && soma2 == num1) {
            System.out.println("Os números são amigos.");
        }
        else {
            System.out.println("Os números não são amigos.");
        }
    }
}
