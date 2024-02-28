/*
Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1.
 */

import java.util.Scanner;

public class Exer05 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite um número: ");
        int n = sc.nextInt();

        int fatorial = 1;
        for (int i = n; i > 0; i--) {
            fatorial *= i;
        }

        System.out.println("Fatorial de " + n + " é " + fatorial);

        sc.close();
    }
}
