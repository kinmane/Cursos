/*
6. O restaurante a quilo Bem-Bão cobra R$12,00 por cada quilo de refeição. Escreva um algoritmo
que leia o peso do prato montado pelo cliente (em quilos) e imprima o valor a pagar. Assuma que a balança já desconte o peso do prato.
 */

import java.util.Scanner;

public class Exer06 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o peso do prato montado pelo cliente (em quilos): ");
        double peso = sc.nextDouble();

        double valor = peso * 12.00;

        System.out.println("O valor a pagar é: R$" + valor);

        sc.close();
    }
}
