/*
3. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a
cada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber
quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de
poupança (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono. Com
base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular os dados solicitados.
 */

import java.util.Scanner;

public class Exer03 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de pães vendidos: ");
        int paes = sc.nextInt();

        System.out.println("Digite a quantidade de broas vendidas: ");
        int broas = sc.nextInt();

        double total = (paes * 0.12) + (broas * 1.50);
        double poupanca = total * 0.10;

        System.out.println("O total arrecadado foi: " + total);
        System.out.println("O valor a ser guardado na poupança é: " + poupanca);

        sc.close();
    }
}
