/*
16. A lanchonete Gostosura vende apenas um tipo de sanduíche, cujo recheio inclui duas fatias de
queijo, uma fatia de presunto e uma rodela de hambúrguer. Sabendo que cada fatia de queijo ou
presunto pesa 50 gramas, e que a rodela de hambúrguer pesa 100 gramas, faça um algoritmo em
que o dono forneça a quantidade de sanduíches a fazer, e a máquina informe as quantidades (em
quilos) de queijo, presunto e carne necessários para compra.
 */

import java.util.Scanner;

public class Exer16 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de sanduíches a fazer: ");
        int quantidade = sc.nextInt();

        double queijo = quantidade * 0.1;
        double presunto = quantidade * 0.05;
        double carne = quantidade * 0.1;

        System.out.println("Você precisará comprar " + queijo + "kg de queijo, " + presunto + "kg de presunto e " + carne + "kg de carne");

        sc.close();
    }
}
