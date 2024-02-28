/*
21. A fábrica de refrigerantes Meia-Cola vende seu produto em três formatos: lata de 350 ml,
garrafa de 600 ml e garrafa de 2 litros. Se um comerciante compra uma determinada quantidade
de cada formato, faça um algoritmo para calcular quantos litros de refrigerante ele comprou.
 */

import java.util.Scanner;

public class Exer21 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de latas de 350ml: ");
        int latas350 = sc.nextInt();

        System.out.println("Digite a quantidade de garrafas de 600ml: ");
        int garrafas600 = sc.nextInt();

        System.out.println("Digite a quantidade de garrafas de 2 litros: ");
        int garrafas2 = sc.nextInt();

        double litros = (latas350 * 0.35) + (garrafas600 * 0.6) + (garrafas2 * 2);

        System.out.println("O comerciante comprou " + litros + " litros de refrigerante");

        sc.close();
    }
}
