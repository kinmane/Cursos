/*
8. Faça um algoritmo para ler três notas de um aluno
em uma disciplina e imprimir a sua média ponderada
(as notas tem pesos respectivos de 1, 2 e 3).
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer08 {
    public static void main(String[] args) {
        int grade1, grade2, grade3, media;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe a primeira nota: ");
        grade1 = sc.nextInt();
        System.out.println("Informe a segunda nota: ");
        grade2 = sc.nextInt();
        System.out.println("Informe a terceira nota: ");
        grade3 = sc.nextInt();

        media = (grade1 + grade2 * 2 + grade3 * 3) / 6;

        System.out.println("Sua média ponderada é " + media);

        sc.close();
    }
}
