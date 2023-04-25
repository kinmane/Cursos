/*
9. Uma fábrica de camisetas produz os tamanhos pequeno, médio e grande,
cada uma sendo vendida respectivamente por 10, 12 e 15 reais.
Construa um algoritmo em que o usuário forneça
a quantidade de camisetas pequenas, médias e grandes referentes a uma venda,
e a máquina informe quanto será o valor arrecadado.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer09 {
    public static void main(String[] args) {
        int small, medium, large, total;
        Scanner sc = new Scanner(System.in);

        System.out.println("Quantas camisetas pequenas foram vendidas?");
        small = sc.nextInt();
        System.out.println("Quantas camisetas médias foram vendidas?");
        medium = sc.nextInt();
        System.out.println("Quantas camisetas grandes foram vendidas?");
        large = sc.nextInt();

        total = small * 10 + medium * 12 + large * 15;

        System.out.println("O valor arrecadado foi de R$" + total);

        sc.close();
    }
}
