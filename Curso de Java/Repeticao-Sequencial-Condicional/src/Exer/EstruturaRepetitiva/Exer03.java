package Exer.EstruturaRepetitiva;

import java.util.Locale;
import java.util.Scanner;

public class Exer03 {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		int id = sc.nextInt();

		int alcool = 0;
		int gasolina = 0;
		int diesel = 0;

		while (id != 4) {
			if (id == 1) {
				alcool++;
			} else if (id == 2) {
				gasolina++;
			} else {
				diesel++;
			}

			id = sc.nextInt();
		}

		System.out.println("Muito Obrigado!");
		System.out.println("Alcool: " + alcool);
		System.out.println("Gasolina: " + gasolina);
		System.out.println("Diesel: " + diesel);

		sc.close();

	}

}
