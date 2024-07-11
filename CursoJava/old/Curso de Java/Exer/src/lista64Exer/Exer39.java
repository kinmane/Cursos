
/*******************************************************************************
 * 39) Faça um programa que leia um número inteiro e mostre uma mensagem
 * indicando se este número é par ou ímpar, e se é positivo ou negativo. O
 * programa só deve parar de rodar quando o usuário responder "S" na seguinte
 * pergunta, "Deseja encerrar o programa?" .
 *******************************************************************************/

import java.util.Scanner;

public class Exer39 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num;

        do {
            System.out.print("Digite um número inteiro: ");
            num = sc.nextInt();

            if (num % 2 == 0) {
                System.out.print("O número " + num + " é par e ");
            } else {
                System.out.print("O número " + num + " é ímpar e ");
            }

            if (num > 0) {
                System.out.println("positivo.");
            } else if (num < 0) {
                System.out.println("negativo.");
            } else {
                System.out.println("zero.");
            }

            System.out.print("Deseja encerrar o programa? (S/N) ");
        } while (!sc.next().equalsIgnoreCase("S"));

        sc.close();
    }

}
