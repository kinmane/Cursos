/*
31. Faça um algoritmo que receba o peso de uma pessoa, calcule e mostre:
a) o novo peso se a pessoa engordar 15% sobre o peso digitado;
b) o novo peso se a pessoa emagrecer 20% sobre o peso digitado.
 */

import java.util.Scanner;

public class Exer31 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o peso da pessoa: ");

        double peso = sc.nextDouble();
        double engordar = peso + (peso * 0.15);
        double emagrecer = peso - (peso * 0.20);

        System.out.println("Se a pessoa engordar 15% sobre o peso digitado, o novo peso será: " + engordar);

        System.out.println("Se a pessoa emagrecer 20% sobre o peso digitado, o novo peso será: " + emagrecer);

        sc.close();
    }
}
