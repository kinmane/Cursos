/*
28. Faça um algoritmo que receba duas notas, calcule e mostre a média ponderada dessas notas,
considerando peso 2 para a primeira nota e peso 3 para a segunda nota.
 */

import java.util.Scanner;

public class Exer28 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a primeira nota: ");
        double nota1 = sc.nextDouble();

        System.out.println("Digite a segunda nota: ");
        double nota2 = sc.nextDouble();

        double mediaPonderada = ((nota1 * 2) + (nota2 * 3)) / 5;

        System.out.println("A média ponderada das notas é " + mediaPonderada);

        sc.close();
    }
}
