/*
35. Faça um algoritmo que calcule e mostre a área de um losango. Sabe-se que: A =
(diagonal_maior * diagonal_menor)/2;
 */

import java.util.Scanner;

public class Exer35 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite a diagonal maior do losango: ");
        double diagonalMaior = sc.nextDouble();

        System.out.print("Digite a diagonal menor do losango: ");
        double diagonalMenor = sc.nextDouble();

        double area = (diagonalMaior * diagonalMenor) / 2;

        System.out.println("A área do losango é: " + area);

        sc.close();
    }
}
