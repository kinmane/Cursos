/*
24. Um tonel de refresco é feito com 8 partes de água mineral e 2 partes de suco de maracujá.
Faça um algoritmo para calcular quantos litros de água e de suco são necessários para se fazer X
litros de refresco (informados pelo usuário).
 */

import java.util.Scanner;

public class Exer24 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a quantidade de litros de refresco que deseja fazer: ");
        double litrosRefresco = sc.nextDouble();

        double litrosAgua = (litrosRefresco * 8) / 10;
        double litrosSuco = (litrosRefresco * 2) / 10;

        System.out.println("Para fazer " + litrosRefresco + " litros de refresco, você precisará de:");
        System.out.println(litrosAgua + " litros de água mineral");
        System.out.println(litrosSuco + " litros de suco de maracujá");

        sc.close();
    }
}
