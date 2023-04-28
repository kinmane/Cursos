/*
1) Faça um algoritmo que leia os valores A, B, C
e imprima na tela se a soma de A + B é menor que C
*/

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer01 {
    public static void main(String[] args) {
        int a, b, c;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o valor de A: ");
        a = sc.nextInt();
        System.out.println("Informe o valor de B: ");
        b = sc.nextInt();
        System.out.println("Informe o valor de C: ");
        c = sc.nextInt();

        if ((a + b) < c) {
            System.out.println("A some de A + B é menor que C");
        }
        else {
            System.out.println("A soma de A + B é maior que C");
        }

        sc.close();
    }
}
