package Exer.EstruturaSequencial;
import java.util.Scanner;

public class Exer01 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite o primeiro número: ");
		int x = sc.nextInt();
		System.out.print("Digite o segundo número: ");
		int y = sc.nextInt();
		
		int soma = x + y;
		
		System.out.println("A soma dos numeros é: " + soma);
		
		
		sc.close();
		
	}

}
