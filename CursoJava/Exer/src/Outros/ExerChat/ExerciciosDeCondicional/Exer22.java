/*
22. Escreva um programa que determine se uma string é um palíndromo.
 */

package Outros.ExerChat.ExerciciosDeCondicional;

import java.util.Scanner;

public class Exer22 {
    public static void main(String[] args) {
        String word, reverse = "";

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite uma palavra: ");
        word = sc.nextLine();

        reverse = "";

        for (int i = word.length() - 1; i >= 0; i--) {
            reverse += word.charAt(i);
        }

        if (word.equals(reverse)) {
            System.out.println("A palavra é um palíndromo.");
        } else {
            System.out.println("A palavra não é um palíndromo.");
        }
    }
}
