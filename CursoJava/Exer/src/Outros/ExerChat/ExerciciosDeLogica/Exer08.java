/*
8. Escreva um programa que determine se um ano é bissexto ou não.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer08 {
    public static void main(String[] args) {
        int year;

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o ano: ");
        year = sc.nextInt();

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
            System.out.println("O ano " + year + " é bissexto.");
        } else {
            System.out.println("O ano " + year + " não é bissexto.");
        }
    }
}
