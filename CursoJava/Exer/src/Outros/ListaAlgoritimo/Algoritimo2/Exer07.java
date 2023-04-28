/*
7) Faça um algoritmo que leia uma variável e some 5 caso seja par
ou some 8 caso seja ímpar,imprimir o resultado desta operação.
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer07 {
    public static void main(String[] args) {
        int num;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número: ");
        num = sc.nextInt();

        if (num % 2 == 0) {
            num += 5;
            System.out.println("O número somado com 5 é: " + num);
        } else {
            num += 8;
            System.out.println("O número somado com 8 é: " + num);
        }

        sc.close();
    }
}
