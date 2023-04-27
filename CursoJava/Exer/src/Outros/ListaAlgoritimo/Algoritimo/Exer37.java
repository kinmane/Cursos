/*
37. Faça um algoritmo que calcule e mostre a tabuada de um número
digitado pelo usuário.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer37 {
    public static void main(String[] args) {
        int number;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número: ");
        number = sc.nextInt();

        for (int i = 1; i <= 10; i++) {
            System.out.println(number + " x " + i + " = " + (number * i));
        }

        sc.close();
    }
}
