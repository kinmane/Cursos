/*
4. Escreva um programa que calcule a média aritmética de três números.
 */

package Outros.ExerChat.ExerciciosDeLogica;

import java.util.Scanner;

public class Exer04 {

    public static void main(String[] args) {
        double n1, n2, n3, media;

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o primeiro número: ");
        n1 = sc.nextDouble();
        System.out.println("Digite o segundo número: ");
        n2 = sc.nextDouble();
        System.out.println("Digite o terceiro número: ");
        n3 = sc.nextDouble();

        media = (n1 + n2 + n3) / 3;

        System.out.println("A média aritmética dos números é: " + media);
    }

}
