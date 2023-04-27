/*
39. João recebeu seu salário de R$ 1200,00 e precisa pagar duas contas
(C1=R$ 200,00 e C2=R$120,00) que estão atrasadas.
Como as contas estão atrasadas, João terá de pagar multa de 2% sobre cada conta.
Faça um algoritmo que calcule e mostre quanto restará do salário do João
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer39 {
    public static void main(String[] args) {
        double salary, bill1, bill2, bill1Fine, bill2Fine, rest;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o salário de João: ");
        salary = sc.nextDouble();
        System.out.print("Digite o valor da primeira conta: ");
        bill1 = sc.nextDouble();
        System.out.print("Digite o valor da segunda conta: ");
        bill2 = sc.nextDouble();

        bill1Fine = bill1 + (bill1 * 0.02);
        bill2Fine = bill2 + (bill2 * 0.02);
        rest = salary - (bill1Fine + bill2Fine);

        System.out.println("O restante do salário de João é: " + rest);

        sc.close();
    }
}
