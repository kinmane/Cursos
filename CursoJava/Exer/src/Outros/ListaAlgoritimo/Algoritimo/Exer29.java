/*
29. Faça um algoritmo que receba o preço de um produto,
calcule e mostre o novo preço,
sabendo-se que este sofreu um desconto de 10%.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer29 {
    public static void main(String[] args) {
        double price, result;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o preço do produto: ");
        price = sc.nextDouble();

        result = price - (price * 0.1);

        System.out.println("O novo preço do produto é R$" + result);

        sc.close();
    }
}
