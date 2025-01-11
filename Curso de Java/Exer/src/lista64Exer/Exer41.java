
/*******************************************************************************
 * 41) Faça um programa que dada a idade de um nadador, classifique-o em uma das
 * seguintes categorias:
 * 	- Infantil A = 5 a 7 anos
 * 	- Infantil B = 8 a 11 anos
 * 	- Juvenil A = 12 a 13 anos
 * 	- Juvenil B = 14 a 17 anos
 * 	- Adultos = Maiores de 18 anos
 *******************************************************************************/

import java.util.Scanner;

public class Exer41 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        System.out.print("Digite a idade do nadador: ");
        int age = sc.nextInt();
        String category;
        if (age >= 5 && age <= 7) {
            category = "Infantil A";
        } else if (age >= 8 && age <= 11) {
            category = "Infantil B";
        } else if (age >= 12 && age <= 13) {
            category = "Juvenil A";
        } else if (age >= 14 && age <= 17) {
            category = "Juvenil B";
        } else {
            category = "Adultos";
        }
        System.out.println("Categoria: " + category);

        sc.close();
    }

}
