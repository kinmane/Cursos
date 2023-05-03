/*
10. Escreva um programa que determine se uma string é um palíndromo.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer10 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String word = "", wordInverted = "";

        System.out.println("Digite uma palavra: ");
        word = sc.nextLine();

        for (int i = word.length() - 1; i >= 0; i--) {
            wordInverted += word.charAt(i);
        }

        if (word.equals(wordInverted)) {
            System.out.println("A palavra " + word + " é um palíndromo.");
        } else {
            System.out.println("A palavra " + word + " não é um palíndromo.");
        }
    }
}
