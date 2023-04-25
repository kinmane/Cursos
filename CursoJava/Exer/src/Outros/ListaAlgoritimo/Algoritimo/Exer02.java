/*
2. Faça um algoritmo para calcular quantas ferraduras
são necessárias para equipar todos os cavalos comprados para um haras.
*/

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer02 {
    public static void main(String[] args) {
        int horses, horseshoes;
        Scanner sc = new Scanner(System.in);

        System.out.println("Quantos cavalos foram comprados? ");
        horses = sc.nextInt();

        horseshoes = horses * 4;

        System.out.println("Será necessario " + horseshoes + " ferraduras.");

        sc.close();
    }
}
