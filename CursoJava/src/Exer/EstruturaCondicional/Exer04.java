package Exer.EstruturaCondicional;

import java.util.Scanner;

public class Exer04 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.print("Digite a hora inicial do jogo (0 a 23): ");
		int horaInicial = sc.nextInt();

		System.out.print("Digite a hora final do jogo (0 a 23): ");
		int horaFinal = sc.nextInt();

		int duracao;

		if (horaInicial < horaFinal) {
			duracao = horaFinal - horaInicial;
		} else {
			duracao = 24 - horaInicial + horaFinal;
		}

		System.out.println("Duracao do jogo: " + duracao + " hora(s)");

		sc.close();
	}
}
