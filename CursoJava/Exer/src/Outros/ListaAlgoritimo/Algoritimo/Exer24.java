/*
24. Um tonel de refresco é feito com 8 partes de água mineral
e 2 partes de suco de maracujá.
Faça um algoritmo para calcular quantos litros de água
e de suco são necessários para se fazer X
litros de refresco (informados pelo usuário).
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer24 {
    public static void main(String[] args) {
        double water, juice, total;
        Scanner sc = new Scanner(System.in);

        System.out.println("Quantos litros de refresco você quer fazer?");
        total = sc.nextDouble();

        water = (total * 8) / 10;
        juice = (total * 2) / 10;

        System.out.println("Você vai precisar de " + water + " litros de água e " + juice + " litros de suco.");

        sc.close();
    }
}
