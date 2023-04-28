/*
6) Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
 */

package Outros.ListaAlgoritimo.Algoritimo3;

public class Exer06 {
    public static void main(String[] args) {
        for (int i = 100; i <= 200; i++) {
            if (i % 2 != 0) {
                System.out.println(i);
            }
        }
    }
}
