import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.println("Enter three numbers for X: ");
		double a = sc.nextDouble();
		double b = sc.nextDouble();
		double c = sc.nextDouble();

		System.out.println("Enter three numbers for Y: ");
		double x = sc.nextDouble();
		double y = sc.nextDouble();
		double z = sc.nextDouble();

		double pX = (a + b + c) / 2;
		double pY = (x + y + z) / 2;

		double areaX = Math.sqrt(pX * (pX - a) * (pX - b) * (pX - c));
		double areaY = Math.sqrt(pY * (pY - x) * (pY - y) * (pY - z));

		System.out.printf("Triangle X area: %.4f%n", areaX);
		System.out.printf("Triangle Y area: %.4f%n", areaY);

		if (areaX > areaY) {
			System.out.printf("Large area: %.4f%n", areaX);
		} else {
			System.out.printf("Large area: %.4f%n", areaY);
		}

		sc.close();
	}

}
