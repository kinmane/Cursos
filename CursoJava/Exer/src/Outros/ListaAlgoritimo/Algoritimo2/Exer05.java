/*
5) Encontrar o dobro de um número caso ele seja positivo
e o seu triplo caso seja negativo, imprimindo o resultado.
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer05 {
    public static void main(String[] args) {
        int num;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número: ");
        num = sc.nextInt();

        if (num > 0) {
            System.out.println("O dobro de " + num + " é " + (num * 2));
        } else {
            System.out.println("O triplo de " + num + " é " + (num * 3));
        }

        sc.close();
    }
}
