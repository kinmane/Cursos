/*
36. Faça um algoritmo que receba o valor do salário mínimo e o valor do salário de um funcionário,
calcule e mostre a quantidade de salários mínimos que ganha esse funcionário.
 */

import java.util.Scanner;

public class Exer36 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o valor do salário mínimo: ");
        double salarioMinimo = sc.nextDouble();

        System.out.print("Digite o valor do salário do funcionário: ");
        double salarioFuncionario = sc.nextDouble();

        double quantidadeSalariosMinimos = salarioFuncionario / salarioMinimo;

        System.out.println("A quantidade de salários mínimos que o funcionário ganha é: " + quantidadeSalariosMinimos);

        sc.close();
    }
}
