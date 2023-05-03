/*
3. Escreva um programa que determine se um número é positivo ou negativo.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer03 {
    public static void main(String[] args) {
        int num;

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite um número: ");
        num = sc.nextInt();

        if (num > 0) {
            System.out.println("O número é positivo.");
        }
        else if (num < 0) {
            System.out.println("O número é negativo.");
        }
        else {
            System.out.println("O número é zero.");
        }
    }
}
