/*
12) Escreva um algoritmo que leia o número de identificação,
as 3 notas obtidas por um aluno nas 3 verificações
e a média dos exercícios que fazem parte da avaliação,
e calcule a média de aproveitamento, usando a fórmula:
MA := (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/7
A atribuição dos conceitos obedece a tabela abaixo.
O algoritmo deve escrever o número do aluno,
suas notas, a média dos exercícios, a média de aproveitamento,
o conceito correspondente e a mensagem 'Aprovado' se o conceito for A, B ou C,
e 'Reprovado' se o conceito for D ou E.
Média de aproveitamento Conceito
>= 90 A
>= 75 e < 90 B
>= 60 e < 75 C
>= 40 e < 60 D
< 40 E
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer12 {
    public static void main(String[] args) {
        double grade1, grade2, grade3, exercises, average;
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o número de identificação: ");
        int id = sc.nextInt();
        System.out.println("Digite as 3 notas obtidas por um aluno nas 3 verificações: ");
        grade1 = sc.nextDouble();
        grade2 = sc.nextDouble();
        grade3 = sc.nextDouble();
        System.out.print("Digite a média dos exercícios que fazem parte da avaliação: ");
        exercises = sc.nextDouble();

        average = (grade1 + grade2 * 2 + grade3 * 3 + exercises) / 7;

        System.out.println("Número do aluno: " + id);
        System.out.println("Notas: " + grade1 + ", " + grade2 + ", " + grade3);
        System.out.println("Média dos exercícios: " + exercises);
        System.out.printf("Média de aproveitamento: %.2f\n", average);

        sc.close();
    }
}
