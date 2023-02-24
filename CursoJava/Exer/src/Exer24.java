
/*******************************************************************************
* 24) Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja
* realizar:
* 1 – Verificar se um dos números lidos é ou não múltiplo do outro
* 2 – Verificar se os dois números lidos são pares
* 3 – Verificar se a média dos dois números é maior ou igual a 7.
* 4 – Sair
*******************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer24 {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		int option = 0;
		double result = 0;

		do {
			System.out.println("Escolha uma opção:");
			System.out.println("1 - Verificar se um dos números lidos é ou não múltiplo do outro");
			System.out.println("2 - Verificar se os dois números lidos são pares");
			System.out.println("3 - Verificar se a média dos dois números é maior ou igual a 7");
			System.out.println("0 - Sair");
			System.out.print("Opção escolhida: ");

			option = sc.nextInt();

			switch (option) {
			case 1:
				System.out.print("Digite o primeiro número: ");
				double number1 = sc.nextDouble();
				System.out.print("Digite o segundo número: ");
				double number2 = sc.nextDouble();
				if (number1 % number2 == 0) {
					System.out.println(number1 + " é múltiplos de " + number2);
				} else if (number2 % number1 == 0) {
					System.out.println(number2 + " é múltiplos de " + number1);
				} else {
					System.out.println("Não são múltiplos");
				}
				break;
			case 2:
				System.out.print("Digite o primeiro número: ");
				number1 = sc.nextDouble();
				System.out.print("Digite o segundo número: ");
				number2 = sc.nextDouble();
				boolean part1 = (number1 % 2 == 0);
				boolean part2 = (number2 % 2 == 0);
				if (part1 && part2) {
					System.out.println("Os números são pares.");
				} else {
					System.out.println("Um ou ambos os números são impares");
				}
				break;
			case 3:
				System.out.print("Digite o primeiro número: ");
				number1 = sc.nextDouble();
				System.out.print("Digite o segundo número: ");
				number2 = sc.nextDouble();
				result = (number1 + number2) / 2;
				if (result >= 7) {
					System.out.println("A média dos dois números é maior ou igual a 7.");
				} else {
					System.out.println("A média dos dois números é menor que 7.");
				}
				break;
			case 0:
				System.out.println("Saindo...");
				break;
			default:
				System.out.println("Opção inválida.");
				break;
			}
		} while (option != 0);

		sc.close();
	}

}
