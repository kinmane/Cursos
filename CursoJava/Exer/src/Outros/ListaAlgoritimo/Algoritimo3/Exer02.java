/*
2) Desenvolver um algoritmo que leia a altura de 15 pessoas. Este programa deverá calcular e
mostrar :
a. A menor altura do grupo;
b. A maior altura do grupo;
 */

package Outros.ListaAlgoritimo.Algoritimo3;

import java.util.Scanner;

public class Exer02 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double altura, menor = 0, maior = 0;

        for (int i = 0; i < 15; i++) {
            System.out.print("Digite a altura: ");
            altura = sc.nextDouble();

            if (i == 0) {
                menor = altura;
                maior = altura;
            } else {
                if (altura < menor) {
                    menor = altura;
                }
                if (altura > maior) {
                    maior = altura;
                }
            }
        }
        System.out.println("Menor altura: " + menor);
        System.out.println("Maior altura: " + maior);

        sc.close();
    }
}
