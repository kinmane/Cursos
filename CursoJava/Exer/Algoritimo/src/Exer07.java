/*
7. Entrar com o dia e o mês de uma data e informar quantos dias se passaram desde o início do
ano. Esqueça a questão dos anos bissextos e considere sempre que um mês possui 30 dias.
 */

import java.util.Scanner;

public class Exer07 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o dia: ");
        int dia = sc.nextInt();

        System.out.println("Digite o mês: ");
        int mes = sc.nextInt();

        int dias = (mes - 1) * 30 + dia;

        System.out.println("Já se passaram " + dias + " dias desde o início do ano");

        sc.close();
    }
}
