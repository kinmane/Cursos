/*
14. Calcule a área de uma pizza que possui um raio R (pi=3.14).
 */

import java.util.Scanner;

public class Exer14 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o raio da pizza: ");
        double raio = sc.nextDouble();

        double area = 3.14 * (raio * raio);

        System.out.println("A área da pizza é de " + area + " cm²");

        sc.close();
    }
}
