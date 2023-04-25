
/*************************************************************************
 *  1-)Faça um programa para calcular o estoque médio de uma peça, sendo que:
 *  ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.
 *
 *************************************************************************/

import java.util.Scanner;

public class Exer01 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Entre com a quantidade mínima: ");
		int qtyMin = sc.nextInt();

		System.out.print("Entre com a quantidade máxima: ");
		int qtyMax = sc.nextInt();

		int stock = (qtyMin + qtyMax) / 2;

		System.out.println("Quantidade média de estoque: " + stock);

		sc.close();
	}

}
