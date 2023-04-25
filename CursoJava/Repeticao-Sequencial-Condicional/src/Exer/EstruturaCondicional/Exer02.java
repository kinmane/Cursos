package Exer.EstruturaCondicional;

import java.util.Scanner;

public class Exer02 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Digite um número inteiro: ");
		int number = sc.nextInt();
		
		if(number % 2 == 0) {
			System.out.println(number + " é par.");
		} else {
			System.out.println(number + " é impar.");
		}		
		
		sc.close();
	}

}
