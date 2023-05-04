/*
24. Escreva um programa que determine se um número é maior que 100 e menor que 200.
 */

package Outros.ExerChat.ExerciciosDeCondicional;

import java.util.Scanner;

public class Exer24 {
    public static void main(String[] args) {
        int num;

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número: ");
        num = sc.nextInt();

        if (num > 100 && num < 200) {
            System.out.println("O número " + num + " está entre 100 e 200.");
        } else {
            System.out.println("O número " + num + " não está entre 100 e 200.");
        }
    }
}
