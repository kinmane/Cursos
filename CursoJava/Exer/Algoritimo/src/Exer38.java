/*
38. Faça um algoritmo que receba o ano de nascimento de uma pessoa e o ano atual, calcule e
mostre:
a) a idade dessa pessoa em anos;
b) a idade dessa pessoa em meses;
c) a idade dessa pessoa em dias;
d) a idade dessa pessoa em semanas.
 */

import java.util.Scanner;

public class Exer38 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o ano de nascimento da pessoa: ");
        int anoNascimento = sc.nextInt();

        System.out.print("Digite o ano atual: ");
        int anoAtual = sc.nextInt();

        int idadeAnos = anoAtual - anoNascimento;
        int idadeMeses = idadeAnos * 12;
        int idadeDias = idadeAnos * 365;
        int idadeSemanas = idadeDias / 7;

        System.out.println("A idade dessa pessoa em anos é: " + idadeAnos);
        System.out.println("A idade dessa pessoa em meses é: " + idadeMeses);
        System.out.println("A idade dessa pessoa em dias é: " + idadeDias);
        System.out.println("A idade dessa pessoa em semanas é: " + idadeSemanas);

        sc.close();
    }
}
