
/*******************************************************************************
* 25) Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um
* programa que calcule seu peso ideal, utilizando as seguintes fórmulas:
* (h = altura)
*   - Para homens: (72.7*h) - 58
*   - Para mulheres: (62.1 *h) - 44.7
*******************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer25 {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Informe sua altura, em metros: ");
		double height = sc.nextDouble();

		System.out.print("Informe seu sexo: (M - F) ");
		char sex = sc.next().toLowerCase().charAt(0);

		double man = (72.7 * height) - 58;
		double woman = (62.1 * height) - 44.7;

		if (sex == 'm') {
			System.out.println("Seu peso ideal é: " + man);
		} else {
			System.out.println("Seu peso ideal é: " + woman);
		}

		sc.close();
	}

}
