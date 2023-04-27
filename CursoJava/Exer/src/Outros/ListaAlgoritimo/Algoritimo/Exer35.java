/*
35. Faça um algoritmo que calcule e mostre a área de um losango. Sabe-se que:
A = (diagonal_maior * diagonal_menor)/2;
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer35 {
    public static void main(String[] args) {
        double area, largerDiagonal, smallerDiagonal;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a diagonal maior: ");
        largerDiagonal = sc.nextDouble();
        System.out.println("Digite a diagonal menor: ");
        smallerDiagonal = sc.nextDouble();

        area = (largerDiagonal * smallerDiagonal) / 2;

        System.out.println("A área do losango é: " + area);

        sc.close();
    }
}
