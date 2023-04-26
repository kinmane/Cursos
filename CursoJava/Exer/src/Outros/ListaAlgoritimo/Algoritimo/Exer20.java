/*
20. Uma confecção produz X blusas de lã e para isto
gasta uma certa quantidade de novelos.
Faça um algoritmo para calcular quantos novelos de lã ela gasta por blusa.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer20 {
    public static void main(String[] args) {
        double blouses, balls, ballsPerBlouse;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de blusas: ");
        blouses = sc.nextDouble();
        System.out.println("Digite a quantidade de novelos: ");
        balls = sc.nextDouble();

        ballsPerBlouse = balls / blouses;

        System.out.println("A quantidade de novelos por blusa é: " + ballsPerBlouse);

        sc.close();
    }
}
