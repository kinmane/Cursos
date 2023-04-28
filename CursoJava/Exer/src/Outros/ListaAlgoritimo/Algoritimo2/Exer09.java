/*
9) Tendo como dados de entrada a altura e o sexo de uma pessoa,
construa um algoritmo que calcule seu peso ideal,
utilizando as seguintes fórmulas:
● para homens: (72.7 * h) – 58;
● para mulheres: (62.1 * h) – 44.7.
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer09 {
    public static void main(String[] args) {
        double height, width;
        char sex;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a altura (em metros): ");
        height = sc.nextDouble();
        System.out.println("Digite seu sexo (M / F)");
        sex = sc.next().toLowerCase().charAt(0);

        if (sex == 'm') {
            width = (72.7 * height) - 58;
            System.out.printf("Seu peso ideal é %.2f", width);
        } else if (sex == 'f') {
            width = (62.1 * height) - 44.7;
            System.out.printf("Seu peso ideal é %.2f", width);
        } else {
            System.out.println("Sexo inválido");
        }

        sc.close();
    }
}
