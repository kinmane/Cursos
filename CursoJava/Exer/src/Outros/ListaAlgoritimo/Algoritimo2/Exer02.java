/*
2) Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa.
Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos).
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer02 {
    public static void main(String[] args) {
        String name, sex, maritalStatus;
        int age;
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe seu nome ");
        name = sc.next();
        System.out.println("Informe seu sexo (M / F) ");
        sex = sc.next().toUpperCase();
        System.out.println("Informe seu estado civil ");
        maritalStatus = sc.next().toLowerCase();

        if (sex.equals("F") && maritalStatus.equals("casada")) {
            System.out.println("A quanto tempo é casada (anos) ");
            age = sc.nextInt();
        }

        sc.close();
    }
}
