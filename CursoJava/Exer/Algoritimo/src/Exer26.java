/*
26. Faça um algoritmo que receba três números, calcule e mostre a multiplicação desses números.
 */

import java.util.Scanner;

public class Exer26 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o primeiro número: ");
        double num1 = sc.nextDouble();

        System.out.println("Digite o segundo número: ");
        double num2 = sc.nextDouble();

        System.out.println("Digite o terceiro número: ");
        double num3 = sc.nextDouble();

        double multiplicacao = num1 * num2 * num3;

        System.out.println("A multiplicação dos números é " + multiplicacao);

        sc.close();
    }
}
