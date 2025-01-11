
/*******************************************************************************
 * 17) Escreva um programa que leia um número inteiro. Verificar por meio de
 * condição se o valor fornecido está na faixa entre 0 (zero) e 9 (nove). Caso o
 * valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
 * Caso contrário, apresentar a mensagem “valor inválido”.
 *******************************************************************************/

import java.util.Scanner;

public class Exer17 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Informe um número inteiro: ");
        int number = sc.nextInt();

        if (number >= 0 && number <= 9) {
            System.out.println("Número válido.");
        } else {
            System.out.println("Número inválido.");
        }

        sc.close();
    }

}
