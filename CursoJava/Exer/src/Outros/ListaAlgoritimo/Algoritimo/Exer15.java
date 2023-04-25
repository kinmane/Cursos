/*
15. Três amigos, Carlos, André e Felipe.
decidiram rachar igualmente a conta de um bar.
Faça um algoritmo para ler o valor total da conta
e imprimir quanto cada um deve pagar,
mas faça com que Carlos e André não paguem centavos.
Ex: uma conta de R$101,53 resulta em R$33,00 para Carlos,
R$33,00 para André e R$35,53 para Felipe.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer15 {
    public static void main(String[] args) {
        double total, carlos, andre, felipe;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o valor total da conta: ");
        total = sc.nextDouble();

        carlos = (int) (total / 3);
        andre = (int) (total / 3);
        felipe = total - (carlos + andre);

        System.out.println("Carlos deve pagar: " + carlos);
        System.out.println("André deve pagar: " + andre);
        System.out.printf("Felipe deve pagar: %.2f", felipe);

        sc.close();
    }
}
