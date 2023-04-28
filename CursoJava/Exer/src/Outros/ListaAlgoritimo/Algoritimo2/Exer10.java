/*
10) O IMC – Indice de Massa Corporal é um critério
da Organização Mundial de Saúde para dar umaindicação
sobre a condição de peso de uma pessoa adulta.
A fórmula é IMC = peso / ( altura )2
Elabore um algoritmo que leia o peso e a altura de um adulto
e mostre sua condição de acordo com a tabela abaixo.
IMC em adultos Condição
Abaixo de 18,5 Abaixo do peso
Entre 18,5 e 25 Peso normal
Entre 25 e 30 Acima do peso
Acima de 30 obeso
 */

package Outros.ListaAlgoritimo.Algoritimo2;

import java.util.Scanner;

public class Exer10 {
    public static void main(String[] args) {
        double imc, height, weight;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a altura (em metros): ");
        height = sc.nextDouble();
        System.out.println("Digite o peso (em kg): ");
        weight = sc.nextDouble();

        imc = weight / (height * height);

        if (imc < 18.5) {
            System.out.println("Abaixo do peso");
        } else if (imc >= 18.5 && imc < 25) {
            System.out.println("Peso normal");
        } else if (imc >= 25 && imc < 30) {
            System.out.println("Acima do peso");
        } else {
            System.out.println("Obeso");
        }

        sc.close();
    }
}
