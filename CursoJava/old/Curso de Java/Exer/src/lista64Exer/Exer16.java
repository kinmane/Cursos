import java.util.Scanner;

public class Exer16 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Informe o primeiro número: ");
        int number1 = sc.nextInt();

        System.out.print("Informe o segundo número: ");
        int number2 = sc.nextInt();

        if (number1 > number2) {
            System.out.println(number1 + " é maior que " + number2);
        } else if (number1 < number2) {
            System.out.println(number2 + " é maior que " + number1);
        } else {
            System.out.println("Eles são iguais");
        }

        sc.close();
    }

}
