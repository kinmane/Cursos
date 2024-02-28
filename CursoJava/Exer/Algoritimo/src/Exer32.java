/*
32. Faça um algoritmo que receba o peso de uma pessoa em quilos, calcule e mostre esse peso
em gramas.
 */

import java.util.Scanner;

public class Exer32 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o peso da pessoa em quilos: ");

        double peso = sc.nextDouble();
        double pesoEmGramas = peso * 1000;

        System.out.println("O peso da pessoa em gramas é: " + pesoEmGramas);

        sc.close();
    }
}
