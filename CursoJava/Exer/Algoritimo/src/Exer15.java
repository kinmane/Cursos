/*
15. Três amigos, Carlos, André e Felipe. decidiram rachar igualmente a conta de um bar. Faça um
algoritmo para ler o valor total da conta e imprimir quanto cada um deve pagar, mas faça com que
Carlos e André não paguem centavos. Ex: uma conta de R$101,53 resulta em R$33,00 para
Carlos, R$33,00 para André e R$35,53 para Felipe.
 */

import java.util.Scanner;

public class Exer15 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o valor total da conta: ");
        double valorTotal = sc.nextDouble();

        double valorDividido = valorTotal / 3;
        double carlos = (int) valorDividido;
        double andre = (int) valorDividido;
        double felipe = valorTotal - (carlos + andre);

        System.out.println("Carlos deve pagar R$" + carlos);
        System.out.println("André deve pagar R$" + andre);
        System.out.println("Felipe deve pagar R$" + felipe);

        sc.close();
    }
}
