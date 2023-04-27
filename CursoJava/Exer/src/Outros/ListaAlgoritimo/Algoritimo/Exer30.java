/*
30. Um funcionário recebe um salário fixo mais 4% de comissão sobre as vendas.
Faça um algoritmo que receba o salário fixo de um funcionário
e o valor de suas vendas, calcule e mostre a
comissão e o salário final do funcionário.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer30 {
    public static void main(String[] args) {
        double salary, sales, result;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o salário fixo do funcionário: ");
        salary = sc.nextDouble();
        System.out.println("Informe o valor das vendas do funcionário: ");
        sales = sc.nextDouble();

        result = salary + (sales * 0.04);

        System.out.println("O salário final do funcionário é R$" + result);

        sc.close();
    }
}
