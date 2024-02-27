/*
Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
 */

import java.util.Scanner;

public class Exer05 {
    public static void main(String[] args) {

         Scanner sc = new Scanner(System.in);

         int codigoPeca01, numeroPecas01, codigoPeca02, numeroPecas02;
         double valorUnitarioPeca01, valorUnitarioPeca02, valorTotal;

         System.out.println("Digite o código da peça 1: ");
         codigoPeca01 = sc.nextInt();
         System.out.println("Digite o número de peças 1: ");
         numeroPecas01 = sc.nextInt();
         System.out.println("Digite o valor unitário da peça 1: ");
         valorUnitarioPeca01 = sc.nextDouble();

         System.out.println("Digite o código da peça 2: ");
         codigoPeca02 = sc.nextInt();
         System.out.println("Digite o número de peças 2: ");
         numeroPecas02 = sc.nextInt();
         System.out.println("Digite o valor unitário da peça 2: ");
         valorUnitarioPeca02 = sc.nextDouble();

         valorTotal = (numeroPecas01 * valorUnitarioPeca01) + (numeroPecas02 * valorUnitarioPeca02);

        System.out.println("VALOR A PAGAR: R$ " + String.format("%.2f", valorTotal));
    }
}
