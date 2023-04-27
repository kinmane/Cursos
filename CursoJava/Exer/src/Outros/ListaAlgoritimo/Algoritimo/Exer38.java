/*
38. Faça um algoritmo que receba o ano de nascimento
de uma pessoa e o ano atual, calcule e mostre:
a) a idade dessa pessoa em anos;
b) a idade dessa pessoa em meses;
c) a idade dessa pessoa em dias;
d) a idade dessa pessoa em semanas.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer38 {
    public static void main(String[] args) {
        int yearOfBirth, currentYear, ageInYears, ageInMonths, ageInDays, ageInWeeks;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o ano de nascimento: ");
        yearOfBirth = sc.nextInt();
        System.out.print("Digite o ano atual: ");
        currentYear = sc.nextInt();

        ageInYears = currentYear - yearOfBirth;
        ageInMonths = ageInYears * 12;
        ageInDays = ageInYears * 365;
        ageInWeeks = ageInYears * 52;

        System.out.println("A idade dessa pessoa em anos é: " + ageInYears);
        System.out.println("A idade dessa pessoa em meses é: " + ageInMonths);
        System.out.println("A idade dessa pessoa em dias é: " + ageInDays);
        System.out.println("A idade dessa pessoa em semanas é: " + ageInWeeks);

        sc.close();
    }
}
