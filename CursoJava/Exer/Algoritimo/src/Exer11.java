/*
11. Uma fábrica controla o tempo de trabalho sem acidentes pela quantidade de dias. Faça um
algoritmo para converter este tempo em anos, meses e dias. Assuma que cada mês possui sempre
30 dias.
 */

import java.util.Scanner;

public class Exer11 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de dias sem acidentes: ");
        int dias = sc.nextInt();

        int anos = dias / 365;
        int meses = (dias % 365) / 30;
        int diasRestantes = (dias % 365) % 30;

        System.out.println("O tempo sem acidentes é de " + anos + " anos, " + meses + " meses e " + diasRestantes + " dias");

        sc.close();
    }
}
