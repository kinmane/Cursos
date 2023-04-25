/*
13. Ler um número inteiro (assuma até três dígitos)
e imprimir a saída da seguinte forma:
CENTENA = x
DEZENA = x
UNIDADE = x
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer13 {
    public static void main(String[] args) {
        int number;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite um número inteiro de até três dígitos: ");
        number = sc.nextInt();

        System.out.println("CENTENA = " + (number / 100));
        System.out.println("DEZENA = " + ((number % 100) / 10));
        System.out.println("UNIDADE = " + (number % 10));

        sc.close();
    }
}
