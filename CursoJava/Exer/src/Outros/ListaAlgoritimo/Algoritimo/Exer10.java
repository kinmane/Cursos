/*
10. Construa um algoritmo para calcular a distância
entre dois pontos do plano cartesiano.
Cada ponto é um par ordenado (x,y).
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer10 {
    public static void main(String[] args) {
        double x1, x2, y1, y2, distance;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o valor de x1: ");
        x1 = sc.nextDouble();
        System.out.println("Informe o valor de x2: ");
        x2 = sc.nextDouble();
        System.out.println("Informe o valor de y1: ");
        y1 = sc.nextDouble();
        System.out.println("Informe o valor de y2: ");
        y2 = sc.nextDouble();

        distance = Math.sqrt(Math.pow((x2 - x1), 2) + Math.pow((y2 - y1), 2));

        System.out.println("A distância entre os pontos é de: " + distance);

        sc.close();
    }
}
