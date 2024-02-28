/*
13. Ler um número inteiro (assuma até três dígitos) e imprimir a saída da seguinte forma:
CENTENA = x
DEZENA = x
UNIDADE = x
 */

import java.util.Scanner;

public class Exer13 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite um número inteiro de até três dígitos: ");
        int numero = sc.nextInt();

        int centena = numero / 100;
        int dezena = (numero % 100) / 10;
        int unidade = (numero % 100) % 10;

        System.out.println("CENTENA = " + centena);
        System.out.println("DEZENA = " + dezena);
        System.out.println("UNIDADE = " + unidade);

        sc.close();
    }
}
