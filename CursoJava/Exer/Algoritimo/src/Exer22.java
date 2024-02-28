/*
22. Pedrinho tem um cofrinho com muitas moedas, e deseja saber quantos reais conseguiu
poupar. Faça um algoritmo para ler a quantidade de cada tipo de moeda, e imprimir o valor total
economizado, em reais. Considere que existam moedas de 1, 5, 10, 25 e 50 centavos, e ainda
moedas de 1 real. Não havendo moeda de um tipo, a quantidade respectiva é zero.
 */

import java.util.Scanner;

public class Exer22 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de moedas de 1 centavo: ");
        int moeda1 = sc.nextInt();

        System.out.println("Digite a quantidade de moedas de 5 centavos: ");
        int moeda5 = sc.nextInt();

        System.out.println("Digite a quantidade de moedas de 10 centavos: ");
        int moeda10 = sc.nextInt();

        System.out.println("Digite a quantidade de moedas de 25 centavos: ");
        int moeda25 = sc.nextInt();

        System.out.println("Digite a quantidade de moedas de 50 centavos: ");
        int moeda50 = sc.nextInt();

        System.out.println("Digite a quantidade de moedas de 1 real: ");
        int moeda1Real = sc.nextInt();

        double total = (moeda1 * 0.01) + (moeda5 * 0.05) + (moeda10 * 0.10) + (moeda25 * 0.25) + (moeda50 * 0.50) + moeda1Real;

        System.out.println("O valor total economizado é de R$" + total);

        sc.close();
    }
}
