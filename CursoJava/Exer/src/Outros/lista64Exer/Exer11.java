
/*******************************************************************************
* 11) Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos
* valores de modo que a variável A passe a possuir o valor da variável B, e a
* variável B passe a possuir o valor da variável A. Apresentar os valores
* trocados.
*******************************************************************************/

import java.util.Scanner;

public class Exer11 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.print("Digite o valor de A: ");
		int a = sc.nextInt();

		System.out.print("Digite o valor de B: ");
		int b = sc.nextInt();

		int temp = a;
		a = b;
		b = temp;

		System.out.println("Valor de A após a troca: " + a);
		System.out.println("Valor de B após a troca: " + b);

		sc.close();
	}

}
