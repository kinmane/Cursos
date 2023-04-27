/*
26. Faça um algoritmo que receba três números,
calcule e mostre a multiplicação desses números.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer26 {
    public static void main(String[] args) {
        int num1, num2, num3, result;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o primeiro número: ");
        num1 = sc.nextInt();
        System.out.print("Digite o segundo número: ");
        num2 = sc.nextInt();
        System.out.print("Digite o terceiro número: ");
        num3 = sc.nextInt();

        result = num1 * num2 * num3;

        System.out.println("O resultado da multiplicação é " + result);

        sc.close();
    }
}
