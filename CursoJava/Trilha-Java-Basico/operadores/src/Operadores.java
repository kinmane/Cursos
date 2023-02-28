public class Operadores {
    public static void main(String[] args) throws Exception {
        // Operadores de Atribuição (=):
        String mensagem = "Deus é bom o tempo todo, e o tempo todo Deus é bom";
        System.out.println(mensagem);

        // Operadores aritmétcos (+), (-), (*), (/) e (%):
        int numero1 = 10;
        int numero2 = 2;

        int soma = numero1 + numero2;

        int subtracao = numero1 - numero2;

        int multiplicacao = numero1 * numero2;

        int divisao = numero1 / numero2;

        int modulo = numero1 % numero2;

        System.out.println(soma); // 12
        System.out.println(subtracao); // 8
        System.out.println(multiplicacao); // 20
        System.out.println(divisao); // 5
        System.out.println(modulo); // 0

        // OBS: O operador (+) também concatena com Strings:

        String nome = "Elielson";

        String sobrenome = "Nascimento";

        String nomeSobrenome = nome + " " + sobrenome;

        System.out.println(nomeSobrenome); // Elielson Nascimento

        // Veja o que pode acontecer se concatenarmos int com String:
        String concatenacao = "?";

        concatenacao = 1 + 1 + 1 + "1";
        System.out.println(concatenacao); // 31

        concatenacao = 1 + "1" + 1 + 1;
        System.out.println(concatenacao); // 1111

        concatenacao = 1 + "1" + 1 + "1";
        System.out.println(concatenacao); // 1111

        concatenacao = "1" + 1 + 1 + 1;
        System.out.println(concatenacao); // 1111

        concatenacao = "1" + (1 + 1 + 1);
        System.out.println(concatenacao); // 13

        // Operadores Unários (-), (+), (++), (--) e (!)
        int numero = 100;

        System.out.println(-numero); // -100
        System.out.println(+numero); // 100
        System.out.println(--numero); // 99
        System.out.println(++numero); // 100

        boolean verdadeiro = true;

        System.out.println("Normal: " + verdadeiro); // Normal: true
        System.out.println("Inverteu: " + !verdadeiro); // Inverteu: false

        // Operador Ternário:
        int a, b;

        a = 5;
        b = 6;

        // EXEMPLO DE CONDICIONAL UTILIZANDO UMA ESTRUTURA IF/ELSE
        /* 
        String resultado = "";
        if(a==b)
            resultado = "verdadeiro";
        else
            resultado = "falso";
        */

        // MESMA CONDICIONAL, MAS DESSA VEZ, UTILIZANDO O OPERADOR CONDICIONAL TERNÁRIO
        String resultado = (a == b) ? "verdadeiro" : "false";

        System.out.println(resultado);


        // Operadores Relacionais:
        int numeroUm = 1;
        int numeroDois = 2;

        if(numeroUm > numeroDois)
	        System.out.print("Numero 1 maior que numero 2");

        if(numeroUm < numeroDois)
	        System.out.print("Numero 1 menor que numero 2");

        if(numeroUm >= numeroDois)
	        System.out.print("Numero 1 maior ou igual que numero 2");

        if(numeroUm <= numeroDois)
	        System.out.print("Numero 1 menor ou igual que numero 2");

        if(numeroUm != numeroDois)
	        System.out.print("Numero 1 é diferente de numero 2");
    }
}
