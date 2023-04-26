/*
19. A granja Frangotech possui um controle automatizado
de cada frango da sua produção.
No pé direito do frango há um anel com um chip de identificação;
no pé esquerdo são dois anéis para indicar
o tipo de alimento que ele deve consumir.
Sabendo que o anel com chip custa
R$4,00 e o anel de alimento custa R$3,50,
faça um algoritmo para calcular o gasto total da granja
para marcar todos os seus frangos.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer19 {
    public static void main(String[] args) {
        int qty;
        double costChicken, total;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de frangos: ");
        qty = sc.nextInt();

        costChicken = 4 + 2 * 3.5;
        total = qty + costChicken;

        System.out.println("O gasto total da granja é: " + total);

        sc.close();
    }
}
