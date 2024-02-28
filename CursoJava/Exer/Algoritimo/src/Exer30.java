/*
30. Um funcionário recebe um salário fixo mais 4% de comissão sobre as vendas. Faça um
algoritmo que receba o salário fixo de um funcionário e o valor de suas vendas, calcule e mostre a comissão e o salário final do funcionário.
 */

import java.util.Scanner;

public class Exer30 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o salário fixo do funcionário: ");
        double salarioFixo = sc.nextDouble();

        System.out.println("Digite o valor das vendas do funcionário: ");
        double valorVendas = sc.nextDouble();

        double comissao = valorVendas * 0.04;
        double salarioFinal = salarioFixo + comissao;

        System.out.println("A comissão do funcionário é " + comissao);
        System.out.println("O salário final do funcionário é " + salarioFinal);

        sc.close();
    }
}
