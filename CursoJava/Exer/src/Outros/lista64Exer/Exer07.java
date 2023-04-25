
/*****************************************************************************************************************
* 7) Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de
* 		temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
* 		variável C é a temperatura em graus Celsius.
*****************************************************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer07 {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Temperatura em °F: ");
		double tempF = sc.nextDouble();

		double tempC = (tempF - 32) * 5 / 9;

		System.out.printf("A temperatura " + tempF + "°F seria ", tempC + "°C");

		sc.close();
	}

}
