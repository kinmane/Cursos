/*
25. Calcule o volume de uma caixa d'água cilíndrica.
 */

import java.util.Scanner;

public class Exer25 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o raio da caixa d'água cilíndrica: ");
        double raio = sc.nextDouble();

        System.out.println("Digite a altura da caixa d'água cilíndrica: ");
        double altura = sc.nextDouble();

        double volume = Math.PI * Math.pow(raio, 2) * altura;

        System.out.println("O volume da caixa d'água cilíndrica é " + volume + "m³");

        sc.close();
    }
}
