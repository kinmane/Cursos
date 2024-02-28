/*
10. Construa um algoritmo para calcular a distância entre dois pontos do plano cartesiano. Cada
ponto é um par ordenado (x,y).
 */

import java.util.Scanner;

public class Exer10 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a coordenada x do primeiro ponto: ");
        double x1 = sc.nextDouble();

        System.out.println("Digite a coordenada y do primeiro ponto: ");
        double y1 = sc.nextDouble();

        System.out.println("Digite a coordenada x do segundo ponto: ");
        double x2 = sc.nextDouble();

        System.out.println("Digite a coordenada y do segundo ponto: ");
        double y2 = sc.nextDouble();

        double distancia = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));

        System.out.println("A distância entre os dois pontos é: " + distancia);

        sc.close();
    }
}
