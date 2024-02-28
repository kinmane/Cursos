/*
Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159
*/

import java.util.Scanner;

public class Exer02 {
    public static void main(String[] args) {

            Scanner sc = new Scanner(System.in);

            double raio, area;

            System.out.println("Digite o valor do raio do círculo: ");
            raio = sc.nextDouble();

            area = 3.14159 * Math.pow(raio, 2);

            System.out.printf("A = %.4f%n", area);
			
			sc.close();
    }
}
