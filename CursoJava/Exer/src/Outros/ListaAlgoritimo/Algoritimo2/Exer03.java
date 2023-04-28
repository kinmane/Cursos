/*
3) Faça um algoritmo para receber um número qualquer
e informar na tela se é par ou ímpar.
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer03 {
    public static void main(String[] args) {
        int number;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe um número: ");
        number = sc.nextInt();

        if (number % 2 == 0) {
            System.out.println("Número é par.");
        }
        else {
            System.out.println("Número é impar.");
        }

        sc.close();
    }
}
