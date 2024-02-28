/*
Calcular o total de uma compra, considerando o código do produto e a quantidade
 */

import java.util.Scanner;

public class Exer05 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int codigo, quantidade;
        double total;

        System.out.print("Informe o código do produto: ");
        codigo = sc.nextInt();

        System.out.print("Informe a quantidade: ");
        quantidade = sc.nextInt();

        if (codigo == 1) {
            total = quantidade * 4.0;
        } else if (codigo == 2) {
            total = quantidade * 4.5;
        } else if (codigo == 3) {
            total = quantidade * 5.0;
        } else if (codigo == 4) {
            total = quantidade * 2.0;
        } else {
            total = quantidade * 1.5;
        }

        System.out.println("Total: R$ " + String.format("%.2f", total));

        sc.close();
    }

}
