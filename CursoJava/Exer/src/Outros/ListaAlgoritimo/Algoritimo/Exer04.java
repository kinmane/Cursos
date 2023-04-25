/*
4. Escreva um algoritmo para ler o nome e a idade de uma pessoa,
e exibir quantos dias de vida ela possui.
Considere sempre anos completos, e que um ano possui 365 dias.
Ex: uma pessoa com 19 anos possui 6935 dias de vida;
veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer04 {
    public static void main(String[] args) {
        int age, days;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe sua idade: ");
        age = sc.nextInt();

        days = age * 365;

        System.out.println("Você já viveu " + days + " dias.");

        sc.close();
    }
}
