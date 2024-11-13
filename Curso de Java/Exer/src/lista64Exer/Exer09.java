package lista64Exer;
/*******************************************************************************
 * 9) Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e
 * dias e escreva a idade dessa pessoa expressa apenas em dias. Considerar ano
 * com 365 dias e mês com 30 dias.
 *******************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer09 {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe sua idade: ");
        int age = sc.nextInt();

        System.out.println("E quantos meses: ");
        int month = sc.nextInt();

        System.out.println("E por ultimo, os dias: ");
        int days = sc.nextInt();

        int totalDays = (age * 365) + (month * 30) + days;

        System.out.println("Total de dias: " + totalDays);

        sc.close();
    }

}
