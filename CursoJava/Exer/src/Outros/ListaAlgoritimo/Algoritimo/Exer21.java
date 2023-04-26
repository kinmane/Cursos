/*
21. A fábrica de refrigerantes Meia-Cola
vende seu produto em três formatos: lata de 350 ml,
garrafa de 600 ml e garrafa de 2 litros.
Se um comerciante compra uma determinada quantidade de cada formato,
faça um algoritmo para calcular quantos litros de refrigerante ele comprou.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer21 {
    public static void main(String[] args) {
        double can, bottle600, bottle2, total;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de latas: ");
        can = sc.nextInt();
        System.out.println("Digite a quantidade de garrafas de 600ml: ");
        bottle600 = sc.nextInt();
        System.out.println("Digite a quantidade de garrafas de 2L: ");
        bottle2 = sc.nextInt();

        total = can * 0.35 + bottle600 * 0.6 + bottle2 * 2;

        System.out.println("A quantidade total de litros é: " + total);

        sc.close();
    }
}
