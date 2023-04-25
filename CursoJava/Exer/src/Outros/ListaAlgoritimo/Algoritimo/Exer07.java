/*
7. Entrar com o dia e o mês de uma data
e informar quantos dias se passaram desde o início do ano.
Esqueça a questão dos anos bissextos
e considere sempre que um mês possui 30 dias.
*/

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer07 {
    public static void main(String[] args) {
        int days, month, daysPassed;
        Scanner sc = new Scanner(System.in);

        System.out.println("Que dia é hoje?");
        days = sc.nextInt();
        System.out.println("E o mês?");
        month = sc.nextInt();

        daysPassed = (month - 1) * 30 + days;

        System.out.println("Já se passaram " + daysPassed + " dias desde o início do ano.");

        sc.close();
    }
}
