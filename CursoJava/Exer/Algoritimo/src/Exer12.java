/*
12. Faça um algoritmo para ler o salário de um funcionário e aumentá-Io em 15%. Após o aumento,
desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento e o salário final.
 */

import java.util.Scanner;

public class Exer12 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o salário do funcionário: ");
        double salario = sc.nextDouble();

        double aumento = salario * 0.15;
        double salarioComAumento = salario + aumento;
        double imposto = salarioComAumento * 0.08;
        double salarioFinal = salarioComAumento - imposto;

        System.out.println("Salário inicial: R$" + salario);
        System.out.println("Salário com aumento: R$" + salarioComAumento);
        System.out.println("Salário final: R$" + salarioFinal);

        sc.close();
    }
}
