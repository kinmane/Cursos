
/*****************************************************************************************************************
* 5) Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
* 	12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
* 	Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
* 	Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
* 	fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média,
* 	tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.
*****************************************************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer05 {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Informe o tempo de viagem em horas: ");
		double time = sc.nextDouble();

		System.out.print("Informe sua velocidade media: ");
		double speed = sc.nextDouble();

		double distance = time * speed;

		int kmL = 12;

		double litersUsed = distance / kmL;

		System.out.println("Velocidade média: " + speed);
		System.out.println("Tempo gasto: " + time);
		System.out.println("Distância: " + distance);
		System.out.printf("Litros usados: %.2f%n", litersUsed);

		sc.close();
	}

}
