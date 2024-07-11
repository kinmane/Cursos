package lista64Exer;
/*****************************************************************************************************************
 * 6) Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
 * 	temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
 * 	Fahrenheit e a variável C representa é a temperatura em graus Celsius.
 *****************************************************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer06 {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("Temperatuda em °C: ");
        double tempC = sc.nextDouble();

        double tempF = (9 * tempC + 160) / 5;

        System.out.println("A temperatura " + tempC + "°C seria " + tempF + "°F");

        sc.close();
    }

}
