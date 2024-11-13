
/*******************************************************************************
 * 13) Escreva um programa que leia 3 números inteiros e imprima na tela os
 * valores em ordem decrescente.
 *******************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer13 {

    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe o primeiro número: ");
        int number1 = sc.nextInt();

        System.out.println("Informe o segundo número: ");
        int number2 = sc.nextInt();

        System.out.println("Informe o terceiro número: ");
        int number3 = sc.nextInt();

        int bigger, middle, smaller;

        if (number1 >= number2 && number1 >= number3) {
            bigger = number1;
            if (number2 >= number3) {
                middle = number2;
                smaller = number3;
            } else {
                middle = number3;
                smaller = number2;
            }
        } else if (number2 >= number1 && number2 >= number3) {
            bigger = number2;
            if (number1 >= number3) {
                middle = number1;
                smaller = number3;
            } else {
                middle = number3;
                smaller = number1;
            }
        } else {
            bigger = number3;
            if (number1 >= number2) {
                middle = number1;
                smaller = number2;
            } else {
                middle = number2;
                smaller = number1;
            }
        }

        System.out.println("Números em ordem decrescente: " + bigger + ", " + middle + ", " + smaller);

        sc.close();
    }

}
