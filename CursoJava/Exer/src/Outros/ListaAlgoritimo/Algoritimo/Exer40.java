/*
40. Faça um algoritmo que receba o valor dos catetos de um triângulo,
calcule e mostre o valor da hipotenusa.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer40 {
    public static void main(String[] args) {
        double cathetus1, cathetus2, hypotenuse;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o valor do primeiro cateto: ");
        cathetus1 = sc.nextDouble();
        System.out.print("Digite o valor do segundo cateto: ");
        cathetus2 = sc.nextDouble();

        hypotenuse = Math.sqrt(Math.pow(cathetus1, 2) + Math.pow(cathetus2, 2));

        System.out.println("O valor da hipotenusa é: " + hypotenuse);

        sc.close();
    }
}
