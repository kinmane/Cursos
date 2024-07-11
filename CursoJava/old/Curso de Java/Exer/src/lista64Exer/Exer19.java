
/*******************************************************************************
 * 19) Escreva um programa que leia três valores para os lados de um triângulo
 * (variáveis A, B e C). Verificar se cada lado é menor que a soma dos outros dois lados. Se sim,
 * saber de A==B e se B==C, sendo verdade o triângulo é eqüilátero; Se não, verificar de A==B
 * ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso contrário, o triângulo
 * será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.
 *******************************************************************************/

import java.util.Scanner;

public class Exer19 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite o valor de A: ");
        int a = sc.nextInt();
        System.out.print("Digite o valor de B: ");
        int b = sc.nextInt();
        System.out.print("Digite o valor de C: ");
        int c = sc.nextInt();

        if (a < b + c && b < a + c && c < a + b) {
            if (a == b && b == c) {
                System.out.println("O triângulo é equilátero.");
            } else if (a == b || a == c || b == c) {
                System.out.println("O triângulo é isósceles.");
            } else {
                System.out.println("O triângulo é escaleno.");
            }
        } else {
            System.out.println("Os lados fornecidos não caracterizam um triângulo.");
        }

        sc.close();
    }

}
