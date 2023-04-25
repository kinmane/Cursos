/*
1. A imobiliária Imóbilis vende apenas terrenos retangulares.
Faça um algoritmo para ler as dimensões de um terreno
e depois exibir a área do terreno.
*/

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer01 {
    public static void main(String[] args) {
        double height, length, area;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a largura do terreno: ");
        height = sc.nextDouble();
        System.out.println("Digite o comprimento do terreno: ");
        length = sc.nextDouble();

        area = height * length;

        System.out.println("A área do terreno é: " + area);

        sc.close();
    }
}
