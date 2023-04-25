/*
14. Calcule a área de uma pizza que possui um raio R (pi=3.14).
*/

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer14 {
    public static void main(String[] args) {
        double radius, area;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o raio da pizza: ");
        radius = sc.nextDouble();

        area = 3.14 * (radius * radius);

        System.out.println("A área da pizza é: " + area);

        sc.close();
    }
}
