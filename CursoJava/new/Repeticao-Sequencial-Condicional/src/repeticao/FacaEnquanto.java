package repeticao;

import java.util.Scanner;

public class FacaEnquanto {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int numero;
        int soma = 0;

        do {
            System.out.println("Digite um número inteiro: ");
            numero = sc.nextInt();

            soma += numero;
        } while (numero != 0);

        System.out.println("A soma dos números digitados é: " + soma);

        System.out.println("Programa finalizado!");

    }
}
