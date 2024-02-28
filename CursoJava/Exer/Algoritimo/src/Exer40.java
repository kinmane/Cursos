/*
40. Faça um algoritmo que receba o valor dos catetos de um triângulo, calcule e mostre o valor da hipotenusa.
 */

import java.util.Scanner;

public class Exer40 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o valor do cateto oposto: ");
        double catetoOposto = sc.nextDouble();

        System.out.print("Digite o valor do cateto adjacente: ");
        double catetoAdjacente = sc.nextDouble();

        double hipotenusa = Math.sqrt(Math.pow(catetoOposto, 2) + Math.pow(catetoAdjacente, 2));

        System.out.println("O valor da hipotenusa é: " + hipotenusa);

        sc.close();
    }
}
