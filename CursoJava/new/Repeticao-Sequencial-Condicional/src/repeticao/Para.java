package repeticao;

import java.util.Scanner;

public class Para {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite um número inteiro: ");
        int numero = sc.nextInt();
        int soma = 0;

        for (int i = 0; i < numero; i++) {
            System.out.println("Digite outro número inteiro: ");
            numero = sc.nextInt();

            soma += numero;
        }

        System.out.println("A soma dos números digitados é: " + soma);

        System.out.println("Programa finalizado!");

        sc.close();

    }
}
