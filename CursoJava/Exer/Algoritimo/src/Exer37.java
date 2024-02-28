/*
37. Faça um algoritmo que calcule e mostre a tabuada de um número digitado pelo usuário.
 */

import java.util.Scanner;

public class Exer37 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número para ver a tabuada: ");
        int numero = sc.nextInt();

        for (int i = 1; i <= 10; i++) {
            System.out.println(numero + " x " + i + " = " + (numero * i));
        }

        sc.close();
    }
}
