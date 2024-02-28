/*
17. Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Faça um
algoritmo para ler uma temperatura Celsius e imprimi-Ia em Fahrenheit (pesquise como fazer este
tipo de conversão).
 */

import java.util.Scanner;

public class Exer17 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a temperatura em Celsius: ");
        double celsius = sc.nextDouble();

        double fahrenheit = (celsius * 9/5) + 32;

        System.out.println("A temperatura em Fahrenheit é " + fahrenheit + "°F");

        sc.close();
    }
}
