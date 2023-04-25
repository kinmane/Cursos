package Exer.EstruturaSequencial;

import java.util.Scanner;

public class Exer05 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite o código da peça, seu número, o valor un da peça 1: ");
	    int cod1 = sc.nextInt();
	    int qty1 = sc.nextInt();
	    double price1 = sc.nextDouble();
	    
	    System.out.print("Digite o código da peça, seu número, o valor un da peça 2: ");
	    int cod2 = sc.nextInt();
	    int qty2 = sc.nextInt();
	    double price2 = sc.nextDouble();

	    double total = price1 * qty1 + price2 * qty2;

	    System.out.printf("VALOR A PAGAR: R$ %.2f%n", total);
	    System.out.println("Peças compradas: ");
	    System.out.println("ID peça: " + cod1 + " // " + "Quantidade " + qty1);
	    System.out.println("ID peça: " + cod2 + " // " + "Quantidade " + qty2);
	    
		sc.close();
	}

}
