/*
11. Uma fábrica controla o tempo de trabalho
sem acidentes pela quantidade de dias.
Faça um algoritmo para converter este tempo em anos, meses e dias.
Assuma que cada mês possui sempre 30 dias.
*/

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer11 {
    public static void main(String[] args) {
        int days, years, months, restDays;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de dias: ");
        days = sc.nextInt();

        years = days / 365;
        restDays = days % 365;
        months = restDays / 30;
        restDays = restDays % 30;

        System.out.println("Anos: " + years);
        System.out.println("Meses: " + months);
        System.out.println("Dias: " + restDays);

        sc.close();
    }
}
