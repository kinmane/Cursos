/*
18. A empresa Hipotheticus paga R$10,00 por hora normal trabalhada, e R$15,00 por hora extra.
Faça um algoritmo para calcular e imprimir o salário bruto e o salário líquido de um determinado
funcionário. Considere que o salário líquido é igual ao salário bruto descontando-se 10% de
impostos.
 */

import java.util.Scanner;

public class Exer18 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de horas normais trabalhadas: ");
        double horasNormais = sc.nextDouble();

        System.out.println("Digite a quantidade de horas extras trabalhadas: ");
        double horasExtras = sc.nextDouble();

        double salarioBruto = (horasNormais * 10) + (horasExtras * 15);
        double imposto = salarioBruto * 0.10;
        double salarioLiquido = salarioBruto - imposto;

        System.out.println("Salário bruto: R$" + salarioBruto);
        System.out.println("Salário líquido: R$" + salarioLiquido);

        sc.close();
    }
}
