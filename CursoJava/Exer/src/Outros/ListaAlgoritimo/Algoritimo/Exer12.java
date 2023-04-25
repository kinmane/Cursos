/*
12. Faça um algoritmo para ler o salário de um funcionário
e aumentá-Io em 15%. Após o aumento, desconte 8% de impostos.
Imprima o salário inicial, o salário com o aumento e o salário final.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer12 {
    public static void main(String[] args) {
        double salary, salaryIncrease, salaryFinal;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o salário: ");
        salary = sc.nextDouble();

        salaryIncrease = salary * 1.15;
        salaryFinal = salaryIncrease * 0.92;

        System.out.println("Salário inicial: " + salary);
        System.out.println("Salário com aumento: " + salaryIncrease);
        System.out.println("Salário final: " + salaryFinal);

        sc.close();
    }
}
