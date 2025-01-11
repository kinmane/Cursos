/*******************************************************************************
 * 26) Escreva um programa que exiba os números de 1 a 100 na tela em ordem
 * decrescente.
 *******************************************************************************/

public class Exer26 {

    public static void main(String[] args) {

        // Com For
        for (int i = 100; i >= 1; i--) {
            System.out.println(i);
        }

        // Com While
        int counter = 100;

        while (counter >= 1) {
            System.out.println(counter);
            counter--;
        }

    }

}
