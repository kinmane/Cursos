/*
5. Escreva um programa que determine se um número é primo ou não.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer05 {

        public static void main(String[] args) {
            int n, i, cont = 0;

            Scanner sc = new Scanner(System.in);

            System.out.println("Digite um número: ");
            n = sc.nextInt();

            for (i = 1; i <= n; i++) {
                if (n % i == 0) {
                    cont++;
                }
            }

            if (cont == 2) {
                System.out.println("O número " + n + " é primo.");
            } else {
                System.out.println("O número " + n + " não é primo.");
            }
        }
}
