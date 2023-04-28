/*
1) Desenvolver um algoritmo que efetue a soma de todos os números ímpares
que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500.
 */

package Outros.ListaAlgoritimo.Algoritimo3;

import java.util.Scanner;

public class Exer01 {
    public static void main(String[] args) {
        int totalSum = 0, n, i, j;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o valor de N: ");
        n = sc.nextInt();

        for (i = 1; i <= n; i++) {
            if (i % 2 != 0) {
                for (j = 1; j <= i; j++) {
                    if (j % 3 == 0) {
                        totalSum += j;
                    }
                }
            }
        }

        System.out.println("Total da soma: " + totalSum);

        sc.close();
    }
}
