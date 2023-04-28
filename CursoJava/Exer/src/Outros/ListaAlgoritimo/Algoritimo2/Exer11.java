/*
11) Elabore um algoritmo que calcule o que deve ser pago por um produto,
considerando o preço normal de etiqueta e a escolha da condição de pagamento.
Utilize os códigos da tabela a seguirpara ler
qual a condição de pagamento escolhida e efetuar o cálculo adequado.
Código Condição de pagamento
1 À vista em dinheiro ou cheque, recebe 10% de desconto
2 À vista no cartão de crédito, recebe 15% de desconto
3 Em duas vezes, preço normal de etiqueta sem juros
4 Em duas vezes, preço normal de etiqueta mais juros de 10%
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer11 {
    public static void main(String[] args) {
        double price, priceDiscount;
        int cod;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o preço do produto: ");
        price = sc.nextDouble();
        System.out.println("Digite o código da condição de pagamento: ");
        System.out.println("1 - À vista em dinheiro ou cheque, recebe 10% de desconto");
        System.out.println("2 - À vista no cartão de crédito, recebe 15% de desconto");
        System.out.println("3 - Em duas vezes, preço normal de etiqueta sem juros");
        System.out.println("4 - Em duas vezes, preço normal de etiqueta mais juros de 10%");
        cod = sc.nextInt();

        switch (cod) {
            case 1 -> {
                priceDiscount = price - (price * 0.1);
                System.out.printf("O preço do produto com desconto é: %.2f", priceDiscount);
            }
            case 2 -> {
                priceDiscount = price - (price * 0.15);
                System.out.printf("O preço do produto com desconto é: %.2f", priceDiscount);
            }
            case 3 -> System.out.printf("O preço do produto é: %.2f", price);
            case 4 -> {
                priceDiscount = price + (price * 0.1);
                System.out.printf("O preço do produto com desconto é: %.2f", priceDiscount);
            }
            default -> System.out.println("Código inválido!");
        }

        sc.close();
    }
}
