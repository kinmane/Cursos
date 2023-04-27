/*
22. Pedrinho tem um cofrinho com muitas moedas,
e deseja saber quantos reais conseguiu poupar.
Faça um algoritmo para ler a quantidade de cada tipo de moeda,
e imprimir o valor total economizado, em reais.
Considere que existam moedas de 1, 5, 10, 25 e 50 centavos,
e ainda moedas de 1 real. Não havendo moeda de um tipo,
a quantidade respectiva é zero.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer22 {
    public static void main(String[] args) {
        double coin1, coin5, coin10, coin25, coin50, coin1real, total;
        Scanner sc = new Scanner(System.in);

        System.out.print("Quantas moedas de 1 centavo você tem? ");
        coin1 = sc.nextInt();
        System.out.print("Quantas moedas de 5 centavos você tem? ");
        coin5 = sc.nextInt();
        System.out.print("Quantas moedas de 10 centavos você tem? ");
        coin10 = sc.nextInt();
        System.out.print("Quantas moedas de 25 centavos você tem? ");
        coin25 = sc.nextInt();
        System.out.print("Quantas moedas de 50 centavos você tem? ");
        coin50 = sc.nextInt();
        System.out.print("Quantas moedas de 1 real você tem? ");
        coin1real = sc.nextInt();

        total = (coin1 * 0.01) + (coin5 * 0.05) + (coin10 * 0.1) + (coin25 * 0.25) + (coin50 * 0.5) + (coin1real * 1);

        System.out.println("Você tem R$" + total + " no seu cofrinho.");

        sc.close();
    }
}
