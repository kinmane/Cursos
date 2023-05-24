import java.util.Locale;
import java.util.Scanner;

public class Exer10 {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		int PrimeiroNumero, SegundoNumero;
		boolean Igual = false, NaoIgual = false, Maior = false, Menor = false, MaiorOuIgual = false,
				MenorOuIgual = false;

		System.out.print("Mostrador de relacionamentos\n\n"); // Mais um exercício away

		System.out.print("Digite o primeiro número:  ");
		PrimeiroNumero = sc.nextInt();

		System.out.print("Digite o segundo número: ");
		SegundoNumero = sc.nextInt();

		if (PrimeiroNumero == SegundoNumero)
			Igual = true;
		if (PrimeiroNumero != SegundoNumero)
			NaoIgual = true;
		if (PrimeiroNumero > SegundoNumero)
			Maior = true;
		if (PrimeiroNumero < SegundoNumero)
			Menor = true;
		if (PrimeiroNumero >= SegundoNumero)
			MaiorOuIgual = true;
		if (PrimeiroNumero <= SegundoNumero)
			MenorOuIgual = true;

		System.out.println("\nIgual = " + Igual);
		System.out.println("Não Igual = " + NaoIgual);
		System.out.println("Maior = " + Maior);
		System.out.println("Menor = " + Menor);
		System.out.println("Maior ou igual = " + MaiorOuIgual);
		System.out.println("Menor ou igual = " + MenorOuIgual);

		sc.close();
	}

}
