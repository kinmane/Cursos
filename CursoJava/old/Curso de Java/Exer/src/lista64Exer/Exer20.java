
/*******************************************************************************
 * 20) Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor
 * maior que zero para cada variável (se o valor digitado não é válido, mostrar mensagem e ler
 * novamente). Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo
 * menor.
 *******************************************************************************/

import java.util.Scanner;

public class Exer20 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a, b, c;

        System.out.print("Digite um valor maior que zero para a: ");
        a = sc.nextInt();

        if (a <= 0) {
            System.out.println("Valor inválido. Digite novamente.");
            a = sc.nextInt();
        }

        System.out.print("Digite um valor maior que zero para b: ");
        b = sc.nextInt();

        if (b <= 0) {
            System.out.println("Valor inválido. Digite novamente.");
            b = sc.nextInt();
        }

        System.out.print("Digite um valor maior que zero para c: ");
        c = sc.nextInt();

        if (c <= 0) {
            System.out.println("Valor inválido. Digite novamente.");
            c = sc.nextInt();
        }

        sc.close();

        int menor = a;
        int maior = a;

        if (b < menor) {
            menor = b;
        } else if (b > maior) {
            maior = b;
        }

        if (c < menor) {
            menor = c;
        } else if (c > maior) {
            maior = c;
        }

        System.out.println("Menor valor lido multiplicado pelo maior: " + menor * maior);
        System.out.println("Maior valor dividido pelo menor: " + ((double) maior / menor));
    }

}
