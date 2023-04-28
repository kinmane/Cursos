/*
7) Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de
N. Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N = 10N.
 */

package Outros.ListaAlgoritimo.Algoritimo3;

public class Exer07 {
    public static void main(String[] args) {
        int n = 5;
        for (int i = 0; i <= 10; i++) {
            System.out.println(i + " x " + n + " = " + (i * n));
        }
    }
}
