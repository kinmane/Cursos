
/*******************************************************************************
* 21) Faça um programa que leia um número inteiro e mostre uma mensagem na tela
* indicando se este número é positivo ou negativo. Pare a execução do programa
* quando o usuário requisitar.
*******************************************************************************/

import java.util.Scanner;

public class Exer21 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.println("Informe um número inteiro: ");
		int number = sc.nextInt();

		if (number >= 0) {
			System.out.println("Número positivo");
		} else {
			System.out.println("Número negativo");
		}

		sc.close();
	}

}
