
/*******************************************************************************
 * 27) Escreva um programa que leia: - a quantidade de números que deverá
 * processar; - os números que deverá processar,e calcule e exiba, para cada
 * número a ser processado o seu fatorial. Lembrete: O fatorial de um número N é
 * dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N
 *******************************************************************************/

import java.util.Scanner;

public class Exer27 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite a quantidade de números a serem processados: ");
        int qty = sc.nextInt();

        for (int i = 1; i <= qty; i++) {
            System.out.print("Digite o número #" + i + ": ");
            int number = sc.nextInt();
            long factorial = 1;

            for (int j = 2; j <= number; j++) {
                factorial *= j;
            }

            System.out.println(number + "! = " + factorial);
        }

        sc.close();
    }

}
