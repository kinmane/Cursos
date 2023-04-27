/*
28. Faça um algoritmo que receba duas notas,
calcule e mostre a média ponderada dessas notas,
considerando peso 2 para a primeira nota e peso 3 para a segunda nota.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer28 {
    public static void main(String[] args) {
        double grade1, grade2, result;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe a primeira nota: ");
        grade1 = sc.nextDouble();
        System.out.println("Informe a segunda nota: ");
        grade2 = sc.nextDouble();

        result = (grade1 * 2 + grade2 * 3) / 5;

        System.out.println("A média ponderada dessas notas é " + result);

        sc.close();
    }
}
