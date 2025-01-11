package Exer.EstruturaSequencial;

import java.util.Scanner;

public class Exer03 {

	public static void main(String[] args) {
	
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Primeiro valor: ");
		int a = sc.nextInt();
		System.out.print("Segundo valor: ");
		int b = sc.nextInt();
		System.out.print("Terceiro valor: ");
		int c = sc.nextInt();
		System.out.print("Quarto valor: ");
		int d = sc.nextInt();
		
		int diferenca = a * b - c * d;
		
		System.out.println("A diferença entre é: " + diferenca);
		
		sc.close();
	}

}
