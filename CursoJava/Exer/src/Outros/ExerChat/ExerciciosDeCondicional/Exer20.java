/*
20. Escreva um programa que determine se um número é par e positivo.
 */

package Outros.ExerChat.ExerciciosDeCondicional;

import java.util.Scanner;

public class Exer20 {
    public static void main(String[] args) {
            int num;

            Scanner sc = new Scanner(System.in);

            System.out.println("Digite um número: ");
            num = sc.nextInt();

            if (num > 0 && num % 2 == 0) {
                System.out.println("O número é par e positivo.");
            } else {
                System.out.println("O número não é par e positivo.");
            }
    }
}
