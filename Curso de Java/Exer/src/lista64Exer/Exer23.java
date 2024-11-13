
/*******************************************************************************
 * 23) Escreva um programa que exiba as seguintes opções e realize os que se pede em cada
 * uma delas:
 *		1 – Adição
 *		2 – Subtração
 *		3 – Multiplicação
 *		4 – Divisão
 *******************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer23 {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        int option = 0;
        double result = 0;

        do {
            System.out.println("Escolha uma opção:");
            System.out.println("1 - Adição");
            System.out.println("2 - Subtração");
            System.out.println("3 - Multiplicação");
            System.out.println("4 - Divisão");
            System.out.println("0 - Sair");
            System.out.print("Opção escolhida: ");

            option = sc.nextInt();

            switch (option) {
                case 1:
                    System.out.print("Digite o primeiro número: ");
                    double number1 = sc.nextDouble();
                    System.out.print("Digite o segundo número: ");
                    double number2 = sc.nextDouble();
                    result = number1 + number2;
                    System.out.println("Resultado: " + result);
                    break;
                case 2:
                    System.out.print("Digite o primeiro número: ");
                    number1 = sc.nextDouble();
                    System.out.print("Digite o segundo número: ");
                    number2 = sc.nextDouble();
                    result = number1 - number2;
                    System.out.println("Resultado: " + result);
                    break;
                case 3:
                    System.out.print("Digite o primeiro número: ");
                    number1 = sc.nextDouble();
                    System.out.print("Digite o segundo número: ");
                    number2 = sc.nextDouble();
                    result = number1 * number2;
                    System.out.println("Resultado: " + result);
                    break;
                case 4:
                    System.out.print("Digite o primeiro número: ");
                    number1 = sc.nextDouble();
                    System.out.print("Digite o segundo número: ");
                    number2 = sc.nextDouble();
                    if (number2 == 0) {
                        System.out.println("Não é possível dividir por zero.");
                    } else {
                        result = number1 / number2;
                        System.out.println("Resultado: " + result);
                    }
                    break;
                case 0:
                    System.out.println("Saindo...");
                    break;
                default:
                    System.out.println("Opção inválida.");
                    break;
            }
        } while (option != 0);

        sc.close();
    }

}
