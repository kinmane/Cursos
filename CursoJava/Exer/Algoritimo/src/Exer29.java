/*
29. Faça um algoritmo que receba o preço de um produto, calcule e mostre o novo preço,
sabendo-se que este sofreu um desconto de 10%.
 */

import java.util.Scanner;

public class Exer29 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o preço do produto: ");
        double precoProduto = sc.nextDouble();

        double novoPreco = precoProduto - (precoProduto * 0.10);

        System.out.println("O novo preço do produto é " + novoPreco);

        sc.close();
    }
}
