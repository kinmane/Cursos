
/*******************************************************************************
 * 31) Escrever um programa que leia um conjunto de números positivos, e exiba
 * se o número lido é par ou ímpar. Exiba ao final a soma total dos números
 * pares lidos e também a soma dos números ímpares lidos. Suporemos que o número
 * de elementos deste conjunto não é conhecido, e que um número negativo será
 * utilizado para sinalizar o fim dos dados.
 *******************************************************************************/

import java.util.Scanner;

public class Exer31 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int sumEven = 0;
        int sumOdd = 0;

        while (true) {
            System.out.print("Digite um número positivo (ou um número negativo para encerrar): ");
            int number = sc.nextInt();

            if (number < 0) {
                break;
            }

            if (number % 2 == 0) {
                System.out.println(number + " é par.");
                sumEven += number;
            } else {
                System.out.println(number + " é ímpar.");
                sumOdd += number;
            }
        }

        System.out.println("Soma dos números pares: " + sumEven);
        System.out.println("Soma dos números ímpares: " + sumOdd);

        sc.close();
    }

}
