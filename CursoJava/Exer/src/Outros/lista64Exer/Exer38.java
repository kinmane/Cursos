
/*******************************************************************************
* 38) Faça um programa que leia as variáveis C e N, respectivamente código e
* número de horas trabalhadas de um operário. E calcule o salário sabendo-se que
* ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o
* excesso de pagamento armazenando-o na variável E, caso contrário zerar tal
* variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento
* imprimir o salário total e o salário excedente. O programa só deve parar de
* rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
* programa?".
*******************************************************************************/

import java.util.Scanner;

public class Exer38 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		int code, hours;
		double salary, extraPayment = 0;

		do {
			System.out.print("Digite o código do trabalhador: ");
			code = sc.nextInt();
			if (code == 0) {
				break;
			}

			System.out.print("Digite o número de horas trabalhadas: ");
			hours = sc.nextInt();

			if (hours > 50) {
				extraPayment = (hours - 50) * 20.0;
				hours = 50;
			} else {
				extraPayment = 0;
			}

			salary = hours * 10.0 + extraPayment;
			System.out.printf("O salário do trabalhador é de R$ %,2f. O pagamento extra é R$ %.2f.%n", salary,
					extraPayment);

			System.out.print("Você quer continuar (S/N)? ");
		} while (sc.next().equalsIgnoreCase("S"));

		sc.close();
	}

}
