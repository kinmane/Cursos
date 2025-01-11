/*
1. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as
dimensões de um terreno e depois exibir a área do terreno.
 */

package listaAlgoritimos.algoritmo1;

import java.util.Scanner;

public class Exer01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double width, height, area;

        System.out.println("Digite a largura do terreno: ");
        width = sc.nextDouble();

        System.out.println("Digite a altura do terreno: ");
        height = sc.nextDouble();

        area = width * height;

        System.out.println("A área do terreno é: " + area);

        sc.close();
    }
}
