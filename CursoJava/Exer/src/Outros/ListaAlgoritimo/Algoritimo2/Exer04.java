/*
4) Faça um algoritmo que leia dois valores inteiros A e B
se os valores forem iguais deverá se somar os dois,
caso contrário multiplique A por B.
Ao final de qualquer um dos cálculos deve-se atribuir
o resultado para uma variável C e mostrar seu conteúdo na tela.
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer04 {
    public static void main(String[] args) {
        int a, b;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o valor de A: ");
        a = sc.nextInt();
        System.out.println("Informe o valor de B: ");
        b = sc.nextInt();

        if (a == b) {
            System.out.println("A + B = " + (a + b));
        }
        else {
            System.out.println("A * B = " + (a * b));
        }

        sc.close();
    }
}
