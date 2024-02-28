/*
1. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as
dimensões de um terreno e depois exibir a área do terreno.
 */

import java.util.Scanner;

public class Exer01 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a largura do terreno: ");
        double largura = sc.nextDouble();

        System.out.println("Digite o comprimento do terreno: ");
        double comprimento = sc.nextDouble();

        double area = largura * comprimento;

        System.out.println("A área do terreno é: " + area);

        sc.close();
    }
}