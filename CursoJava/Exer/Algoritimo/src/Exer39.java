/*
39. João recebeu seu salário de R$ 1200,00 e precisa pagar duas contas (C1=R$ 200,00 e
C2=R$120,00) que estão atrasadas. Como as contas estão atrasadas, João terá de pagar multa de
2% sobre cada conta. Faça um algoritmo que calcule e mostre quanto restará do salário do João
 */

import java.util.Scanner;

public class Exer39 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        double salario = 1200.00;
        double conta1 = 200.00;
        double conta2 = 120.00;
        double multa = 0.02;

        double totalContas = conta1 + conta2;
        double multaConta1 = conta1 * multa;
        double multaConta2 = conta2 * multa;
        double totalMulta = multaConta1 + multaConta2;
        double totalPagar = totalContas + totalMulta;
        double saldo = salario - totalPagar;

        System.out.println("O total a pagar é: " + totalPagar);
        System.out.println("O saldo restante é: " + saldo);

        sc.close();
    }
}
