
/*******************************************************************************
* 32) Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros
* números inteiros positivos ímpares a partir do número informado pelo usuário menor que 10
* e maior que zero.
*******************************************************************************/

import java.util.Scanner;

public class Exer32 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Enter a positive integer less than 10 and greater than zero: ");
		int number = sc.nextInt();

		int sumSquares = 0;
		int countOdd = 0;

		for (int i = number; countOdd < 20; i++) {
			if (i % 2 == 1) {
				sumSquares += i * i;
				countOdd++;
			}
		}

		System.out.println(
				"Sum of squares of the first 20 odd positive integers starting from " + number + ": " + sumSquares);

		sc.close();
	}

}
