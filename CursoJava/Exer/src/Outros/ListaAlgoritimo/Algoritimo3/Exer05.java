/*
5) Faça um algoritmo estruturado que leia uma quantidade não determinada de números positivos.
Calcule a quantidade de números pares e ímpares, a média de valores pares e a média geral dos
números lidos. O número que encerrará a leitura será zero.
 */

package Outros.ListaAlgoritimo.Algoritimo3;

import java.util.Scanner;

public class Exer05 {
    public static void main(String[] args) {
        int numero, somaPares = 0, somaImpares = 0, quantidadePares = 0, quantidadeImpares = 0;
        double mediaPares, mediaGeral;

        Scanner entrada = new Scanner(System.in);

        System.out.print("Digite um número (ou 0 para sair): ");
        numero = entrada.nextInt();

        while (numero != 0) {
            if (numero % 2 == 0) {
                somaPares += numero;
                quantidadePares++;
            } else {
                somaImpares += numero;
                quantidadeImpares++;
            }

            System.out.print("Digite um número (ou 0 para sair): ");
            numero = entrada.nextInt();
        }

        if (quantidadePares > 0) {
            mediaPares = (double) somaPares / quantidadePares;
        } else {
            mediaPares = 0;
        }

        if (quantidadePares + quantidadeImpares > 0) {
            mediaGeral = (double) (somaPares + somaImpares) / (quantidadePares + quantidadeImpares);
        } else {
            mediaGeral = 0;
        }

        System.out.println("Quantidade de números pares: " + quantidadePares);
        System.out.println("Quantidade de números ímpares: " + quantidadeImpares);
        System.out.println("Média dos valores pares: " + mediaPares);
        System.out.println("Média geral dos números lidos: " + mediaGeral);
    }
}

