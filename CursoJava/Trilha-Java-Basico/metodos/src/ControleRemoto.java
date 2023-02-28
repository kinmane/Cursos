public class ControleRemoto {
    public static void main(String[] args) {
        SmartTv minhaTv = new SmartTv();

        minhaTv.ligar();
        minhaTv.desligar();

        // Ligar novamente rsrsrs
        minhaTv.ligar();

        /*
        Se você fizer o teste para aumetar o volume várias vezes,
        ele não passa de 100, pois respeita a condição imposta no if.
         */
        minhaTv.aumentarVolume();
        minhaTv.aumentarVolume();
        minhaTv.aumentarVolume();

        /*
        Se você fizer o teste para diminuir o volume várias vezes,
        ele não passa de 0, pois respeita a condição imposta no if.
         */
        minhaTv.diminuirVolume();
        minhaTv.diminuirVolume();
        minhaTv.diminuirVolume();

        minhaTv.avancarCanal();
        minhaTv.avancarCanal();

        minhaTv.voltarCanal();
        minhaTv.voltarCanal();
        minhaTv.voltarCanal();

        minhaTv.selecionarCanal(100); // OK!
        minhaTv.selecionarCanal(101); // Não vai pra esse canal.

        minhaTv.selecionarCanal(1); // OK!
        minhaTv.selecionarCanal(0); // Não vai pra esse canal.


        // Qualquer método pode ser chamado infinitas vezes...
    };
};
