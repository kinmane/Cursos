/*
20. Uma confecção produz X blusas de lã e para isto gasta uma certa quantidade de novelos. Faça
um algoritmo para calcular quantos novelos de lã ela gasta por blusa.
 */

import java.util.Scanner;

public class Exer20 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de blusas de lã produzidas: ");
        int blusas = sc.nextInt();

        System.out.println("Digite a quantidade de novelos de lã gastos: ");
        int novelos = sc.nextInt();

        int novelosPorBlusa = novelos / blusas;

        System.out.println("A quantidade de novelos de lã gastos por blusa é " + novelosPorBlusa);

        sc.close();
    }
}
