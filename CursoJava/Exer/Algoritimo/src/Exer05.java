/*
5. Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para ler o preço do litro da gasolina e o valor do pagamento, e exibir quantos litros ele conseguiu colocar no tanque.
 */

import java.util.Scanner;

public class Exer05 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o preço do litro da gasolina: ");
        double preco = sc.nextDouble();

        System.out.println("Digite o valor do pagamento: ");
        double pagamento = sc.nextDouble();

        double litros = pagamento / preco;

        System.out.println("Você conseguiu colocar " + litros + " litros no tanque");

        sc.close();
    }
}
