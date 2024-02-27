/*
Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.
 */

import java.util.Scanner;

public class Exer04 {
    public static void main(String[] args) {

         Scanner sc = new Scanner(System.in);

         int numeroFuncionario, horasTrabalhadas;
         double valorHora, salario;

         System.out.println("Digite o número do funcionário: ");
         numeroFuncionario = sc.nextInt();
         System.out.println("Digite o número de horas trabalhadas: ");
         horasTrabalhadas = sc.nextInt();
         System.out.println("Digite o valor que recebe por hora: ");
         valorHora = sc.nextDouble();

         salario = horasTrabalhadas * valorHora;

         System.out.println("NUMBER = " + numeroFuncionario);
         System.out.printf("SALARY = U$ %.2f%n", salario);
    }
}
