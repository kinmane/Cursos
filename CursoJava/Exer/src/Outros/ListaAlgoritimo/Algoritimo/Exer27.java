/*
27. Faça um algoritmo que receba dois números,
calcule e mostre a divisão do primeiro número pelo segundo.
Sabe-se que o segundo número não pode ser zero,
portanto não é necessário se preocupar com validações.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer27 {
    public static void main(String[] args) {
        int num1, num2, result;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o primeiro número: ");
        num1 = sc.nextInt();
        System.out.print("Digite o segundo número: ");
        num2 = sc.nextInt();

        result = num1 / num2;

        System.out.println("O resultado da divisão é " + result);

        sc.close();
    }
}
