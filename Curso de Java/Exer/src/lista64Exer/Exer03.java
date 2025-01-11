package lista64Exer;
/*************************************************************************
 * 3) Faça um programa para pagamento de comissão de vendedores de peças,
 *		levando-se em consideração que sua comissão será de 5% do total da venda 
 *		e que você tem os seguintes dados:
 * 		- Identificação do vendedor
 * 		- Código da peça
 * 		- Preço unitário da peça
 * 		- Quantidade vendida
 *************************************************************************/

import java.util.Locale;
import java.util.Scanner;

public class Exer03 {

    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.print("ID: ");
        int id = sc.nextInt();

        System.out.print("Cod. Peça: ");
        int cod = sc.nextInt();

        System.out.print("Valor da peça: ");
        double value = sc.nextDouble();

        System.out.print("Quantidade vendida: ");
        int qty = sc.nextInt();

        double sales = value * qty;
        double commission = sales * 0.05;

        System.out.println("ID: " + id);
        System.out.println("Cod. Peça: " + cod);
        System.out.println("Preço: " + value);
        System.out.println("Quantidade: " + qty);
        System.out.println("Valor vendido: " + sales);
        System.out.println("Comissão: " + commission);

        sc.close();
    }

}
