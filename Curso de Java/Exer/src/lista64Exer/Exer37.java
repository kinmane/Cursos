
/*******************************************************************************
 * 37) Faça um programa de conversão de base numérica. O programa deverá
 * apresentar uma tela de entrada com as seguintes opções:
 *		1 – Adição
 *		2 – Subtração
 *		3 – Multiplicação
 *		4 – Divisão
 * Informe a opção:
 * A partir da opção escolhida, o programa deverá solicitar para que o usuário
 * digite dois números. Em seguida, o programa deve exibir o resultado da opção
 * indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao menu
 * principal. Caso a resposta seja  ́S ́ ou  ́s ́, deverá voltar ao menu, caso
 * contrário deverá encerrar o programa.
 *******************************************************************************/

import java.util.Scanner;

public class Exer37 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int operation = 0;

        do {
            System.out.println("Selecione a operação desejada:");
            System.out.println("1 - Adição");
            System.out.println("2 - Subtração");
            System.out.println("3 - Multiplicação");
            System.out.println("4 - Divisão");
            System.out.println("5 - Sair");

            operation = sc.nextInt();

            if (operation == 1) {
                System.out.print("Digite o primeiro número: ");
                double num1 = sc.nextDouble();

                System.out.print("Digite o segundo número: ");
                double num2 = sc.nextDouble();

                double resultado = num1 + num2;

                System.out.println("Resultado: " + resultado);
            } else if (operation == 2) {
                System.out.print("Digite o primeiro número: ");
                double num1 = sc.nextDouble();

                System.out.print("Digite o segundo número: ");
                double num2 = sc.nextDouble();

                double resultado = num1 - num2;

                System.out.println("Resultado: " + resultado);
            } else if (operation == 3) {
                System.out.print("Digite o primeiro número: ");
                double num1 = sc.nextDouble();

                System.out.print("Digite o segundo número: ");
                double num2 = sc.nextDouble();

                double resultado = num1 * num2;

                System.out.println("Resultado: " + resultado);
            } else if (operation == 4) {
                System.out.print("Digite o primeiro número: ");
                double num1 = sc.nextDouble();

                System.out.print("Digite o segundo número: ");
                double num2 = sc.nextDouble();

                if (num2 == 0) {
                    System.out.println("Não é possível dividir por zero!");
                } else {
                    double resultado = num1 / num2;
                    System.out.println("Resultado: " + resultado);
                }
            } else if (operation == 5) {
                System.out.println("Encerrando o programa...");
            } else {
                System.out.println("Opção inválida! Tente novamente.");
            }

            System.out.println();

        } while (operation != 5);

        sc.close();

    }

}
