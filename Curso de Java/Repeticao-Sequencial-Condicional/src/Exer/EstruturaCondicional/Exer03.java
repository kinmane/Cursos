package Exer.EstruturaCondicional;

import java.util.Scanner;

public class Exer03 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite o primeiro valor: ");
        int numberA = sc.nextInt();
        System.out.print("Digite o segundo valor: ");
        int numberB = sc.nextInt();
		
		if(numberA % numberB == 0 || numberB % numberA == 0) {
			System.out.println("São multiplos");
		} else {
			System.out.println("Não são multiplos");
		}		
		
		sc.close();
	}

}
