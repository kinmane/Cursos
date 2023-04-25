/*
5. Um motorista deseja colocar no seu tanque X reais de gasolina.
Escreva um algoritmo para ler o preço do litro da gasolina
e o valor do pagamento, e exibir quantos litros
ele conseguiu colocar no tanque.
*/

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer05 {
    public static void main(String[] args) {
        double price, payment, liters;
        Scanner sc = new Scanner(System.in);

        System.out.println("Quanto está o valor da gasolina: ");
        price = sc.nextDouble();
        System.out.println("Qual foi o valor do pagamento:");
        payment = sc.nextDouble();

        liters = price * payment;

        System.out.println("Você conseguiu colocar " + liters + " litros de gasolina");

        sc.close();
    }
}
