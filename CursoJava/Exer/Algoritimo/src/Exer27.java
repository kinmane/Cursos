/*
27. Faça um algoritmo que receba dois números, calcule e mostre a divisão do primeiro número
pelo segundo. Sabe-se que o segundo número não pode ser zero, portanto não é necessário se
preocupar com validações.
 */

import java.util.Scanner;

public class Exer27 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o primeiro número: ");
        double num1 = sc.nextDouble();

        System.out.println("Digite o segundo número: ");
        double num2 = sc.nextDouble();

        double divisao = num1 / num2;

        System.out.println("A divisão dos números é " + divisao);

        sc.close();
    }
}
