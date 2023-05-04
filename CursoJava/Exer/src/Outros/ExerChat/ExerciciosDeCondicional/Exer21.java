/*
21. Escreva um programa que determine se um número é múltiplo de 7.
 */

package Outros.ExerChat.ExerciciosDeCondicional;

import java.util.Scanner;

public class Exer21 {
    public static void main(String[] args) {
        int num;

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite um número: ");
        num = sc.nextInt();

        if (num % 7 == 0) {
            System.out.println("O número é múltiplo de 7.");
        } else {
            System.out.println("O número não é múltiplo de 7.");
        }
    }
}
