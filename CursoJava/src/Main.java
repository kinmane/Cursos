import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("Por favor, informe as horas (0-23):");
		int hours = sc.nextInt();

		if (hours >= 0 && hours <= 23) {
			if (hours >= 6 && hours <= 11) {
				System.out.println("Bom dia!");
			} else if (hours >= 12 && hours <= 18) {
				System.out.println("Boa tarde!");
			} else {
				System.out.println("Boa noite!");
			}
		} else {
			System.out.println("Horário inválido.");
		}

		sc.close();
	}

}
