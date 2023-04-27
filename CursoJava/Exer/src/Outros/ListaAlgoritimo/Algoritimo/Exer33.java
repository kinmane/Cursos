/*
33. Faça um algoritmo que calcule e mostre a área de um trapézio.
Sabe-se que: A = (base maior + base menor)* altura)/2 ;
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer33 {
    public static void main(String[] args) {
        double heigh, area, largeBase, smallBase;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe a altura do trapézio: ");
        heigh = sc.nextDouble();
        System.out.println("Informe a base maior do trapézio: ");
        largeBase = sc.nextDouble();
        System.out.println("Informe a base menor do trapézio: ");
        smallBase = sc.nextDouble();

        area = ((largeBase + smallBase) * heigh) / 2;

        System.out.println("A área do trapézio é: " + area);

        sc.close();
    }
}
