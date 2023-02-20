package Exer.EstruturaCondicional;

import java.util.Scanner;

public class Exer01 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Digite um numero inteiro: ");
		int number = sc.nextInt();
		
		if (number == 0) {
			System.out.println("Zero é um número neutro.");
		} else if (number > 0 ) {
			System.out.println("Seu numero é positivo.");
		} else {
			System.out.println("Seu numero é negativo.");
		}
		
		sc.close();
	}

}
