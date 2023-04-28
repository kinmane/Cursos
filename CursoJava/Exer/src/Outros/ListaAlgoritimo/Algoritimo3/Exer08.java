/*
8) Escreva um algoritmo que leia um valor inicial A e uma razão R e imprima uma seqüência em
P.A. contendo 10 valores.
 */

package Outros.ListaAlgoritimo.Algoritimo3;

public class Exer08 {
    public static void main(String[] args) {
        int a = 1;
        int r = 2;
        for (int i = 0; i < 10; i++) {
            System.out.println(a + (i * r));
        }
    }
}
