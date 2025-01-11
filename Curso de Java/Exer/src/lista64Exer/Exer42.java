
/*******************************************************************************
 * 42) Faça um programa que determine o maior e o menor entre N números lidos.
 * A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar
 * executando até que a entrada seja igual a 0 (ZERO).
 *******************************************************************************/

import java.util.Scanner;

public class Exer42 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int number, bigger = Integer.MIN_VALUE, smaller = Integer.MAX_VALUE;
        do {
            System.out.print("Digite um número (ou 0 para parar): ");
            number = sc.nextInt();
            if (number != 0) {
                if (number > bigger) {
                    bigger = number;
                }
                if (number < smaller) {
                    smaller = number;
                }
            }
        } while (number != 0);
        if (bigger == Integer.MIN_VALUE) {
            System.out.println("Nenhum número foi digitado.");
        } else {
            System.out.println("Maior número: " + bigger);
            System.out.println("Menor número: " + smaller);
        }

        sc.close();
    }

}
