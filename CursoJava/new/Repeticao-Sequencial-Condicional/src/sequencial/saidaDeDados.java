package sequencial;

import java.util.Locale;

public class saidaDeDados {

    public static void main(String[] args) {
        System.out.println("Hello, World!");

        double x = 10.35784;
        System.out.println(x);
        System.out.printf("%.2f%n", x);
        Locale.setDefault(Locale.US);
        System.out.printf("%.2f%n", x);
    }
}