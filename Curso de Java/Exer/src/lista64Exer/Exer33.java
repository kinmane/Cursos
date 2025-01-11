
/*******************************************************************************
 * 33) Escreva um programa que calcule e exiba a média da nota dos alunos de uma
 * turma em uma prova. O número de alunos é desconhecido. Os dados de um aluno
 * são: número de matrícula e a sua nota na prova em questão.
 *******************************************************************************/

import java.util.Scanner;

public class Exer33 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double sumGrades = 0;
        int countGrades = 0;

        while (true) {
            System.out.print("Enter the student's grade (or a negative number to end): ");
            double grade = sc.nextDouble();

            if (grade < 0) {
                break;
            }

            sumGrades += grade;
            countGrades++;
        }

        double avgGrade = (countGrades > 0) ? (sumGrades / countGrades) : 0;

        System.out.println("Average grade of the class: " + avgGrade);

        sc.close();
    }

}
