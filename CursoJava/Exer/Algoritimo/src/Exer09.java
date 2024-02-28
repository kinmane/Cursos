/*
9. Uma fábrica de camisetas produz os tamanhos pequeno, médio e grande, cada uma sendo
vendida respectivamente por 10, 12 e 15 reais. Construa um algoritmo em que o usuário forneça a
quantidade de camisetas pequenas, médias e grandes referentes a uma venda, e a máquina
informe quanto será o valor arrecadado.
 */

import java.util.Scanner;

public class Exer09 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de camisetas pequenas vendidas: ");
        int pequenas = sc.nextInt();

        System.out.println("Digite a quantidade de camisetas médias vendidas: ");
        int medias = sc.nextInt();

        System.out.println("Digite a quantidade de camisetas grandes vendidas: ");
        int grandes = sc.nextInt();

        double total = (pequenas * 10) + (medias * 12) + (grandes * 15);

        System.out.println("O total arrecadado foi: R$" + total);

        sc.close();
    }
}
