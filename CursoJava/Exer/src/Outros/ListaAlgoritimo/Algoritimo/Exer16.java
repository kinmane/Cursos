/*
16. A lanchonete Gostosura vende apenas um tipo de sanduíche,
cujo recheio inclui duas fatias de queijo,
uma fatia de presunto e uma rodela de hambúrguer.
Sabendo que cada fatia de queijo ou presunto pesa 50 gramas,
e que a rodela de hambúrguer pesa 100 gramas,
faça um algoritmo em que o dono forneça a quantidade de sanduíches a fazer,
e a máquina informe as quantidades (em quilos) de queijo,
presunto e carne necessários para compra.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer16 {
    public static void main(String[] args) {
        double cheese, ham, meat;
        int sandwich;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de sanduíches a fazer: ");
        sandwich = sc.nextInt();

        cheese = sandwich * 2 * 0.05;
        ham = sandwich * 0.05;
        meat =sandwich * 0.1;

        System.out.println("Quantidade de queijo: " + cheese + "kg");
        System.out.println("Quantidade de presunto: " + ham + "kg");
        System.out.println("Quantidade de carne: " + meat + "kg");

        sc.close();
    }
}
