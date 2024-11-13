
/*******************************************************************************
 * 12) Escreva um programa que leia um número inteiro e exiba o seu módulo.
 *   O módulo de um número x é:
 *   x se x é maior ou igual a zero
 *   x * (-1) se x é menor que zero
 *******************************************************************************/

import java.util.Scanner;

public class Exer12 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número inteiro: ");
        int number = sc.nextInt();

        if (number >= 0) {
            System.out.println("Módulo: " + number);
        } else {
            System.out.println("Módulo: " + (-number));
        }

        sc.close();
    }

}
