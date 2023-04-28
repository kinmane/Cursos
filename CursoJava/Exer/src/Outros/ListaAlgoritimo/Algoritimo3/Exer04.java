/*
4) Escrever um algoritmo que leia uma quantidade desconhecida de números e conte quantos deles
estão nos seguintes intervalos: [0-25], [26-50], [51-75] e [76-100]. A entrada de dados deve
terminar quando for lido um número negativo.
 */

package Outros.ListaAlgoritimo.Algoritimo3;

import java.util.Scanner;

public class Exer04 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int num, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0;

        do {
            System.out.print("Digite um número: ");
            num = sc.nextInt();

            if (num >= 0 && num <= 25) {
                cont1++;
            } else if (num >= 26 && num <= 50) {
                cont2++;
            } else if (num >= 51 && num <= 75) {
                cont3++;
            } else if (num >= 76 && num <= 100) {
                cont4++;
            }
        } while (num >= 0);

        System.out.println("Quantidade de números no intervalo [0-25]: " + cont1);
        System.out.println("Quantidade de números no intervalo [26-50]: " + cont2);
        System.out.println("Quantidade de números no intervalo [51-75]: " + cont3);
        System.out.println("Quantidade de números no intervalo [76-100]: " + cont4);

        sc.close();
    }
}
