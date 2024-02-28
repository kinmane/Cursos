/*
33. Faça um algoritmo que calcule e mostre a área de um trapézio. Sabe-se que: A = (base maior +
base menor)* altura)/2 ;
 */

import java.util.Scanner;

public class Exer33 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite a base maior do trapézio: ");
        double baseMaior = sc.nextDouble();

        System.out.print("Digite a base menor do trapézio: ");
        double baseMenor = sc.nextDouble();

        System.out.print("Digite a altura do trapézio: ");
        double altura = sc.nextDouble();

        double area = ((baseMaior + baseMenor) * altura) / 2;

        System.out.println("A área do trapézio é: " + area);

        sc.close();
    }
}
