/*
6) Escreva um algoritmo que lê dois valores booleanos (lógicos)
e então determina se ambos são VERDADEIROS ou FALSOS.
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer06 {
    public static void main(String[] args) {
        boolean a, b;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o primeiro valor booleano (true/false): ");
        a = sc.nextBoolean();

        System.out.print("Digite o segundo valor booleano (true/false): ");
        b = sc.nextBoolean();

        if (a && b) {
            System.out.println("Ambos são verdadeiros.");
        } else if (!a && !b) {
            System.out.println("Ambos são falsos.");
        } else {
            System.out.println("Um dos valores é falso.");
        }

        sc.close();
    }
}
