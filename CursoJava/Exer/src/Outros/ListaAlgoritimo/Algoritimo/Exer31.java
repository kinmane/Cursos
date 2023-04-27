/*
31. Faça um algoritmo que receba o peso de uma pessoa, calcule e mostre:
a) o novo peso se a pessoa engordar 15% sobre o peso digitado;
b) o novo peso se a pessoa emagrecer 20% sobre o peso digitado.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer31 {
    public static void main(String[] args) {
        double weight, lowWeight, highWeight;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o peso: ");
        weight = sc.nextDouble();

        lowWeight = weight - (weight * 0.2);
        highWeight = weight + (weight * 0.15);

        System.out.printf("Peso se emagrecer 20%%: %.2f\n", lowWeight);
        System.out.printf("Peso se engordar 15%%: %.2f\n", highWeight);

        sc.close();
    }
}
