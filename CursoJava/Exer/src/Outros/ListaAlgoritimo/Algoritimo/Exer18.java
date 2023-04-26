/*
18. A empresa Hipotheticus paga R$10,00 por hora normal trabalhada,
e R$15,00 por hora extra.
Faça um algoritmo para calcular e imprimir
o salário bruto e o salário líquido de um determinado funcionário.
Considere que o salário líquido é igual ao salário bruto
descontando-se 10% de impostos.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer18 {
    public static void main(String[] args) {
        double normalHour, extraHour, grossSalary, netSalary;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de horas trabalhadas: ");
        normalHour = sc.nextDouble();
        System.out.println("Digite a quantidade de horas extras trabalhadas: ");
        extraHour = sc.nextDouble();

        grossSalary = (normalHour * 10) + (extraHour * 15);
        netSalary = grossSalary - (grossSalary * 0.1);

        System.out.println("O salário bruto é: " + grossSalary);
        System.out.println("O salário líquido é: " + netSalary);

        sc.close();
    }
}
