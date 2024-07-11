package lista64Exer;
/*************************************************************************
 *  2) Faça um programa que:
 *    - Leia a cotação do dólar
 *    - Leia um valor em dólares
 *    - Converta esse valor para Real
 *    - Mostre o resultado
 *
 *************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer02 {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Informe a cotação do dolar atualmente: ");
        double quotation = sc.nextDouble();

        System.out.println("Informe seu salário: ");
        double salary = sc.nextDouble();

        double convert = quotation * salary;

        System.out.printf("Seu salário em real, seria R$%.2f%n", convert);

        sc.close();
    }

}
