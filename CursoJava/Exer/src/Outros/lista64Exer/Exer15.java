import java.util.Locale;
import java.util.Scanner;

public class Exer15 {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Informe sua primeira nota: ");
		double grade1 = sc.nextDouble();

		System.out.print("Informe sua segunda nota: ");
		double grade2 = sc.nextDouble();

		System.out.print("Informe sua terceira nota: ");
		double grade3 = sc.nextDouble();

		System.out.print("Informe sua quarta nota: ");
		double grade4 = sc.nextDouble();

		double media = (grade1 + grade2 + grade3 + grade4) / 4;

		if (media >= 7) {
			System.out.println("Você passou com media " + media);
		} else {
			System.out.print("Prova de recuperação, informe a nota: ");
			double retakeGrade = sc.nextDouble();
			double newMedia = (media + retakeGrade) / 2;
			if (newMedia >= 7) {
				System.out.println("Você passou pela recuperação, com media " + newMedia);
			} else {
				System.out.println("Reprovou em tudo que é possivel, por favor, não se reproduza!");
			}
		}

		sc.close();
	}

}
