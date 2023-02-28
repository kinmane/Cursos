public class TiposVariaveis {
    public static void main(String [] args) throws Exception {
        char sexo = 'M'; // Suporta apenas um caractere.

        String nome = "Elielson"; // Suporta apenas mais de um caractere / palavra / frase.
        
        boolean brasileiro = true; // Definição de verdadeiro(true)/falso(false)
        
        byte idade=127; 
        // Suporta valores entre: -128 a 127

        short anoNascimento= 1990;
        // Suporta valores entre: -32.768 a 32.767

        int diametroSol = 1392700;
        // Suporta valores entre: -2.147.483.648 a 2.147.483.647
        
        long cpf = 81938650010L; 
        // Suporta valores entre: -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

        float altura = 1.80f;
        // Suporta valores entre: -3,4028E + 38 a 3,4028E + 38 precisão de 6 – 7 dígitos

        /* OBSERVAÇÃO: Os tipos float sempre irão possuir o caractere “f” no final do 
        valor para sua identificação, sendo a mesma coisa com o tipo long só que é 
        inserido o caractere “L”. */

        double distanciaSol = 149.600000; 
        // Suporta valores entre: -1,7976E + 308 a 1,7976E + 308 precisão de 15 dígitos
        
        /*Portanto, para representar números, na grande maioria das vezes,
        utilizaremos o tipo int , para representar números inteiros ou 
        double para representar números fracionados.*/

        /* CUIDADO: Ao converter números em float ou double lembre-se que o ponto é
        por conversão Americana que no nosso caso equivale a vírgula.*/

        // Definindo uma CONSTANTE:
        final String NACIONALIDADE = "Brasileiro";

        /* A Constante é utilizada quando não queremos que o valor definido
        não seja alterado nunca. */
    }
}
