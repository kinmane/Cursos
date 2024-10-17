package condicional;

import java.util.Scanner;

public class SwitchCase {

    Scanner sc = new Scanner(System.in);

    int x = sc.nextInt();
    String dia = switch (x) {
        case 1 -> "Domingo";
        case 2 -> "Segunda";
        case 3 -> "Terça";
        case 4 -> "Quarta";
        case 5 -> "Quinta";
        case 6 -> "Sexta";
        case 7 -> "Sábado";
        default -> "Valor inválido";
    };

}
