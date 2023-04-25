
/*******************************************************************************
* 14) Escreva um programa que leia dois números e apresente a diferença do
* maior para o menor.
*******************************************************************************/

import java.util.Scanner;

public class Exer14 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.println("Primeiro número: ");
		int number1 = sc.nextInt();

		System.out.println("Segundo número: ");
		int number2 = sc.nextInt();

		double diferenca = Math.abs(number1 - number2);
		if (number1 > number2) {
			System.out.printf("A diferença entre %.2f e %.2f é %.2f.%n", number1, number2, diferenca);
		} else if (number2 > number1) {
			System.out.printf("A diferença entre %.2f e %.2f é %.2f.%n", number2, number1, diferenca);
		} else {
			System.out.println("Os números são iguais, não há diferença.");
		}

		sc.close();
	}

}
