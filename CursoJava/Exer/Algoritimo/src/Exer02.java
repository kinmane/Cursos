/*
2. Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os
cavalos comprados para um haras.
 */

import java.util.Scanner;

public class Exer02 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de cavalos: ");
        int cavalos = sc.nextInt();

        int ferraduras = cavalos * 4;

        System.out.println("A quantidade de ferraduras necessárias é: " + ferraduras);

        sc.close();
    }
}
