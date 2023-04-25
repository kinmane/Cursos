
/*******************************************************************************
* 22) Faça um programa que leia um número. Se positivo armazene-o em A, se for
* negativo, em B. No final mostrar o resultado.
*******************************************************************************/

import java.util.Scanner;

public class Exer22 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.println("Informe um número: ");
		int number = sc.nextInt();

		int a = 0;
		int b = 0;

		if (number >= 0) {
			a = number;
			System.out.println("O número era positivo e foi armazenado na variável 'A' " + a);
		} else {
			b = number;
			System.out.println("O número era positivo e foi armazenado na variável 'B' " + b);
		}

		sc.close();
	}

}
