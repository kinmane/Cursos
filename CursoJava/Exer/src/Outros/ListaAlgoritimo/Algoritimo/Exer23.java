/*
23. Num dia de sol, você deseja medir a altura de um prédio,
porém, a trena não é suficientemente longa.
Assumindo que seja possível medir sua sombra e a do prédio no chão,
e que você lembre da sua altura,
faça um algoritmo para ler os dados necessários e calcular a altura do prédio.
 */

package Outros.ListaAlgoritimo.Algoritimo;

import java.util.Scanner;

public class Exer23 {
    public static void main(String[] args) {
        double shadow, height, buildingHeight, buildingShadow;
        Scanner sc = new Scanner(System.in);

        System.out.print("Qual a sua altura? ");
        height = sc.nextDouble();
        System.out.print("Qual a sombra que você faz? ");
        shadow = sc.nextDouble();
        System.out.print("Qual a sombra do prédio? ");
        buildingShadow = sc.nextDouble();

        buildingHeight = (height * buildingShadow) / shadow;

        System.out.println("O prédio tem " + buildingHeight + "m de altura.");

        sc.close();
    }
}
