package com.br.softeli.exemplos.arrays;

import java.util.Scanner;
/* Faça um vetor (array) de 6 caracteres,
 * e diga quantas consoantes foram lidas.
 * Imprima as consoantes. */

public class Ex_Consoantes {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] consoantes = new String[6];
        // Esse 6 é o tamanho pré-definido do array.

        String letra = "";
        int count = 0;
        int quantidadeDeConsoantes = 0;

        do {
            System.out.println("Letra");
            letra = scan.next();

            // Observe o "!":a
            if(!(letra.equalsIgnoreCase("a") ||
                letra.equalsIgnoreCase("e") ||
                letra.equalsIgnoreCase("i") ||
                letra.equalsIgnoreCase("o") ||
                letra.equalsIgnoreCase("u"))) {
                    consoantes[count] = letra;
                    quantidadeDeConsoantes ++;
                }

            count ++;
        } while (count < consoantes.length);

        System.out.println("Total de consoantes digitadas: " + quantidadeDeConsoantes);

        for (String consoante : consoantes) {
            if(consoante != null) {
                System.out.print(consoante + " ");
            }
        }
        System.out.println("");
    }
}
