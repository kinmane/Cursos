
/*******************************************************************************
 * 34) Escreva um programa que leia um conjunto de números positivos e exiba o
 * menor e o maior. Suporemos que o número de elementos deste conjunto não é
 * conhecido, e que um número negativo será utilizado para sinalizar o fim dos
 * dados.
 *******************************************************************************/

import java.util.Scanner;

public class Exer34 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int min = Integer.MAX_VALUE;
        int max = Integer.MIN_VALUE;

        while (true) {
            System.out.print("Digite um número positivo (ou um número negativo para terminar): ");
            int number = sc.nextInt();

            if (number < 0) {
                break;
            }

            if (number < min) {
                min = number;
            }

            if (number > max) {
                max = number;
            }
        }

        System.out.println("O menor número é: " + min);
        System.out.println("O maior número é: " + max);

        sc.close();
    }

}
