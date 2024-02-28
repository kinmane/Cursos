/*
Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
 */

import java.util.Scanner;

public class Exer04 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        double[] divisao = new double[n];

        for (int i = 0; i < n; i++) {
            double a = sc.nextDouble();
            double b = sc.nextDouble();
            if (b == 0) {
                System.out.println("divisao impossivel");
            } else {
                divisao[i] = a / b;
                System.out.printf("%.1f%n", divisao[i]);
            }
        }

        sc.close();
    }
}
