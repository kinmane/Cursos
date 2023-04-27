/*
34. Faça um algoritmo que calcule e mostre a área de um quadrado.
Sabe-se que: A = lado * lado;
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer34 {
    public static void main(String[] args) {
        double side, area;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o lado do quadrado: ");
        side = sc.nextDouble();

        area = side * side;

        System.out.println("A área do quadrado é: " + area);

        sc.close();
    }
}
