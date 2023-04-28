/*
8) Escreva um algoritmo que leia três valores inteiros
e diferentes e mostre-os em ordem decrescente.
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer08 {
    public static void main(String[] args) {
        int num1, num2, num3;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o primeiro número: ");
        num1 = sc.nextInt();
        System.out.print("Digite o segundo número: ");
        num2 = sc.nextInt();
        System.out.print("Digite o terceiro número: ");
        num3 = sc.nextInt();

        if (num1 > num2 && num1 > num3) {
            if (num2 > num3) {
                System.out.println(num1 + " " + num2 + " " + num3);
            } else {
                System.out.println(num1 + " " + num3 + " " + num2);
            }
        } else if (num2 > num1 && num2 > num3) {
            if (num1 > num3) {
                System.out.println(num2 + " " + num1 + " " + num3);
            } else {
                System.out.println(num2 + " " + num3 + " " + num1);
            }
        } else {
            if (num1 > num2) {
                System.out.println(num3 + " " + num1 + " " + num2);
            } else {
                System.out.println(num3 + " " + num2 + " " + num1);
            }
        }

        sc.close();
    }
}
