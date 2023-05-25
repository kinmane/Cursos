
/*******************************************************************************
 * 44) Faça um programa que exiba as opções:
 * 	1 – Conversão de Graus Celsius em Graus Fahrenheit
 * 	2 – Conversão de Graus Fahrenheit em Graus Celsius
 * 	3 – Peso ideal do homem
 * 	4 – Peso ideal da mulher
 * O programa só deve encerrar quando o usuário digitar  ́S ́ para a pergunta
 *  “Deseja encerrar o programa?”
 * Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.
 *******************************************************************************/

import java.util.Scanner;

public class Exer44 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        char continuar;
        do {
            System.out.println("Escolha uma opção:");
            System.out.println("1 - Conversão de Graus Celsius em Graus Fahrenheit");
            System.out.println("2 - Conversão de Graus Fahrenheit em Graus Celsius");
            System.out.println("3 - Peso ideal do homem");
            System.out.println("4 - Peso ideal da mulher");
            int opcao = sc.nextInt();
            switch (opcao) {
                case 1:
                    System.out.print("Digite a temperatura em graus Celsius: ");
                    double celsius = sc.nextDouble();
                    double fahrenheit = (9.0 / 5.0) * celsius + 32;
                    System.out.println("Temperatura em graus Fahrenheit: " + fahrenheit);
                    break;
                case 2:
                    System.out.print("Digite a temperatura em graus Fahrenheit: ");
                    fahrenheit = sc.nextDouble();
                    celsius = (5.0 / 9.0) * (fahrenheit - 32);
                    System.out.println("Temperatura em graus Celsius: " + celsius);
                    break;
                case 3:
                    System.out.print("Digite a altura em metros: ");
                    double altura = sc.nextDouble();
                    double pesoIdealHomem = 72.7 * altura - 58;
                    System.out.println("Peso ideal do homem: " + pesoIdealHomem + " kg");
                    System.out.print("Digite o peso atual em kg: ");
                    double pesoAtualHomem = sc.nextDouble();
                    if (pesoAtualHomem < pesoIdealHomem) {
                        System.out.println("Você está abaixo do peso ideal.");
                    } else if (pesoAtualHomem > pesoIdealHomem) {
                        System.out.println("Você está acima do peso ideal.");
                    } else {
                        System.out.println("Você está no peso ideal.");
                    }
                    break;
                case 4:
                    System.out.print("Digite a altura em metros: ");
                    altura = sc.nextDouble();
                    double pesoIdealMulher = 62.1 * altura - 44.7;
                    System.out.println("Peso ideal da mulher: " + pesoIdealMulher + " kg");
                    System.out.print("Digite o peso atual em kg: ");
                    double pesoAtualMulher = sc.nextDouble();
                    if (pesoAtualMulher < pesoIdealMulher) {
                        System.out.println("Você está abaixo do peso ideal.");
                    } else if (pesoAtualMulher > pesoIdealMulher) {
                        System.out.println("Você está acima do peso ideal.");
                    } else {
                        System.out.println("Você está no peso ideal.");
                    }
                    break;
                default:
                    System.out.println("Opção inválida.");
                    break;
            }
            System.out.print("Deseja encerrar o programa? (S/N) ");
            continuar = sc.next().charAt(0);
        } while (continuar != 'S' && continuar != 's');

        sc.close();

    }

}
