package Exer;

import java.util.Scanner;

public class Exer04 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Digite o ID do funcionário: ");
		int id = sc.nextInt();
		System.out.println("Digite o número de horas trabalhadas: ");
		double hours = sc.nextDouble();
		
		sc.close();
	}

}
