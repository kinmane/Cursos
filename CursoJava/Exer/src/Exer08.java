
/*****************************************************************************************************************
* 8) Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
* 		V = 3.14159 * R * R * A
* 		Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.
*****************************************************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer08 {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Informe o raio: ");
		double radius = sc.nextDouble();

		System.out.print("Informe a altura: ");
		double height = sc.nextDouble();

		double volume = 3.14159 * radius * radius * height;

		System.out.printf("O vokume dessa lata de óleo é: %.2f%n", volume);

		sc.close();
	}

}
