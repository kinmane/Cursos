package Exer.EstruturaRepetitiva;

import java.util.Locale;
import java.util.Scanner;

public class Exer01 {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Senha: ");
		int senha = sc.nextInt();

		while (senha != 2002) {
			System.out.println("Senha Invalida.");
			senha = sc.nextInt();
		}

		System.out.println("Acesso Permitido.");

		sc.close();

	}

}
