
/*******************************************************************************
 * 36) Faça um programa que leia 10 valores inteiros e positivos e: - Encontre o
 * maior valor - Encontre o menor valor - Calcule a média dos números lidos
 *******************************************************************************/

import java.util.Scanner;

public class Exer36 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int sum = 0;
        int min = Integer.MAX_VALUE;
        int max = Integer.MIN_VALUE;

        for (int i = 1; i <= 10; i++) {
            System.out.print("Enter integer #" + i + ": ");
            int number = sc.nextInt();

            while (number <= 0) {
                System.out.println("O número deve ser positivo! Tente novamente.");
                System.out.print("Insira o número inteiro #" + i + ": ");
                number = sc.nextInt();
            }

            if (number < min) {
                min = number;
            }
            if (number > max) {
                max = number;
            }
            sum += number;
        }

        double average = (double) sum / 10;

        System.out.println("Valor minimo: " + min);
        System.out.println("Valor maximo: " + max);
        System.out.println("Valor medio: " + average);

        sc.close();

    }

}
