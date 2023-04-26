/*
17. Alguns países medem temperaturas em graus Celsius,
e outros em graus Fahrenheit.
Faça um algoritmo para ler uma temperatura Celsius
e imprimi-Ia em Fahrenheit
(pesquise como fazer este tipo de conversão).
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer17 {
    public static void main(String[] args) {
        double celsius, fahrenheit;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a temperatura em Celsius: ");
        celsius = sc.nextDouble();

        fahrenheit = (celsius * 1.8) + 32;

        System.out.println("A temperatura em Fahrenheit é: " + fahrenheit);

        sc.close();
    }
}
