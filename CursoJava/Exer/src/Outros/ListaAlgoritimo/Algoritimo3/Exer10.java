/*
10) Escreva um algoritmo que leia um valor inicial A e imprima a seqüência de valores do cálculo de
A! e o seu resultado. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
 */

package Outros.ListaAlgoritimo.Algoritimo3;

public class Exer10 {
    public static void main(String[] args) {
        int a = 5;
        int fatorial = 1;
        for (int i = a; i > 0; i--) {
            fatorial *= i;
            if (i == 1) {
                System.out.print(i + " = ");
            } else {
                System.out.print(i + " x ");
            }
        }
        System.out.println(fatorial);
    }
}
