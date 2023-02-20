package Exer.EstruturaSequencial;

import java.util.Scanner;

public class Exer04 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite o ID do funcionário: ");
		int id = sc.nextInt();
		System.out.print("Digite o número de horas trabalhadas: ");
		double hours = sc.nextDouble();
		System.out.print("Digite o valor da hora trabalhada: ");
		double cash = sc.nextDouble();
		
		double salary = hours * cash;
		
		System.out.println("------------");
		System.out.println("ID: " + id);
		System.out.println("Salário: U$ " + salary);
		
		sc.close();
	}

}
