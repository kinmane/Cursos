/*
34. Faça um algoritmo que calcule e mostre a área de um quadrado.
Sabe-se que: A = lado * lado;
 */

import java.util.Scanner;

public class Exer34 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o lado do quadrado: ");
        double lado = sc.nextDouble();

        double area = lado * lado;

        System.out.println("A área do quadrado é: " + area);

        sc.close();
    }
}
