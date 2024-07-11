/*
2. Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os
cavalos comprados para um haras.
 */

package listaAlgoritimos.algoritmo1;

import java.util.Scanner;

public class Exer02 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int horses, horseshoes;

        System.out.println("Quantos cavalos você comprou? ");
        horses = sc.nextInt();

        horseshoes = horses * 4;

        System.out.println("Será necessarios " + horseshoes + " ferraduras para equipar todos os cavalos.");

        sc.close();
    }
}
