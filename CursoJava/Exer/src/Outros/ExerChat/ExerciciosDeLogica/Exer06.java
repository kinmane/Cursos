/*
6. Escreva um programa que calcule a área de um retângulo.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer06 {
    public static void main(String[] args) {
        double height, width, area;

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a base do retângulo: ");
        width = sc.nextDouble();
        System.out.println("Digite a altura do retângulo: ");
        height = sc.nextDouble();

        area = width * height;

        System.out.println("A área do retângulo é: " + area);
    }
}
