/*
32. Faça um algoritmo que receba o peso de uma pessoa em quilos,
calcule e mostre esse peso em gramas.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer32 {
    public static void main(String[] args) {
        double weight, grams;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o peso: ");
        weight = sc.nextDouble();

        grams = weight * 1000;

        System.out.printf("Peso em gramas: %.2f\n", grams);

        sc.close();
    }
}
