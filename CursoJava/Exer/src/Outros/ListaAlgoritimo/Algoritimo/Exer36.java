/*
36. Faça um algoritmo que receba o valor do salário mínimo
e o valor do salário de um funcionário,
calcule e mostre a quantidade de salários mínimos que ganha esse funcionário.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer36 {
    public static void main(String[] args) {
        double minimumSalary, salary, salaryMinimums;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o valor do salário mínimo: ");
        minimumSalary = sc.nextDouble();
        System.out.print("Digite o valor do salário do funcionário: ");
        salary = sc.nextDouble();

        salaryMinimums = salary / minimumSalary;

        System.out.println("O funcionário ganha " + salaryMinimums + " salários mínimos.");

        sc.close();
    }
}
