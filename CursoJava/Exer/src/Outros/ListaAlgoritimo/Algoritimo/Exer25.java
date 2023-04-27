/*
25. Calcule o volume de uma caixa d'água cilíndrica.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer25 {
    public static void main(String[] args) {
        double radius, height, volume;
        Scanner sc = new Scanner(System.in);

        System.out.print("Qual o raio da caixa d'água? ");
        radius = sc.nextDouble();
        System.out.print("Qual a altura da caixa d'água? ");
        height = sc.nextDouble();

        volume = Math.PI * Math.pow(radius, 2) * height;

        System.out.printf("O volume da caixa d'água é %.2f", volume);

        sc.close();
    }
}
