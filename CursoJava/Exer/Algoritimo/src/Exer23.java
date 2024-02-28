/*
23. Num dia de sol, você deseja medir a altura de um prédio, porém, a trena não é suficientemente
longa. Assumindo que seja possível medir sua sombra e a do prédio no chão, e que você lembre
da sua altura, faça um algoritmo para ler os dados necessários e calcular a altura do prédio.
 */

import java.util.Scanner;

public class Exer23 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a sua altura: ");
        double alturaPessoa = sc.nextDouble();

        System.out.println("Digite o tamanho da sua sombra: ");
        double sombraPessoa = sc.nextDouble();

        System.out.println("Digite o tamanho da sombra do prédio: ");
        double sombraPredio = sc.nextDouble();

        double alturaPredio = (sombraPredio * alturaPessoa) / sombraPessoa;

        System.out.println("A altura do prédio é " + alturaPredio + " metros");

        sc.close();
    }
}
