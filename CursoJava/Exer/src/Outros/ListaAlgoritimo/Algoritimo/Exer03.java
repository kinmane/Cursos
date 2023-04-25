/*
3. A padaria Hotpão vende uma certa quantidade de pães franceses
e uma quantidade de broas a cada dia.
Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50.
Ao final do dia, o dono quer saber quanto arrecadou com a venda
dos pães e broas (juntos), e quanto deve guardar numa conta de
poupança (10% do total arrecadado).
Você foi contratado para fazer os cálculos para o dono.
Com base nestes fatos, faça um algoritmo para ler
as quantidades de pães e de broas,
e depois calcular os dados solicitados.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer03 {
    public static void main(String[] args) {
        int bread, cornbread;
        double totalPrice, savings;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de pães vendidos: ");
        bread = sc.nextInt();
        System.out.println("Digite a quantidade de broas vendidos: ");
        cornbread = sc.nextInt();

        totalPrice = bread * 0.12 + cornbread * 1.5;
        savings = totalPrice * 0.1;

        System.out.println("Você vendeu um total de: R$" + totalPrice);
        System.out.println("O valor a ser reservado é: R$" + savings);

        sc.close();
    }
}
