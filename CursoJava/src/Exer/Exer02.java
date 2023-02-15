package Exer;

import java.util.Scanner;

public class Exer02 {

	public static void main(String[] args) {
	
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Qual o raio do círculo: ");
		double raio = sc.nextDouble();
		double pi = 3.14159;		
		double area = pi * (raio * raio);

		System.out.printf("O valor da área é: %.4f%n", area);
		
		sc.close();
	}

}
