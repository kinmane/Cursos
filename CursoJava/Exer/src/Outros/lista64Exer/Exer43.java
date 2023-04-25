/*******************************************************************************
 * 43) Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria
 * qualquer preço. O monge, necessitando de alimentos, indagou à rainha sobre o
 * pagamento, se poderia ser feito com grãos de trigo dispostos em um tabuleiro
 * de xadrez, de tal forma que o primeiro quadro deveria conter apenas um grão e
 * os quadros subseqüentes, o dobro do quadro anterior. A rainha achou o
 * trabalho barato e pediu que o serviço fosse executado, sem se dar conta de
 * que seria impossível efetuar o pagamento. Faça um programa para calcular o
 * número de grãos que o monge esperava receber.
 *******************************************************************************/

public class Exer43 {

	public static void main(String[] args) {
		int numQuadros = 64;
		long graosNoTotal = 1;
		long graosNoQuadro = 1;
		for (int i = 2; i <= numQuadros; i++) {
			graosNoQuadro *= 2;
			graosNoTotal += graosNoQuadro;
		}
		System.out.println("O monge esperava receber " + graosNoTotal + " grãos de trigo.");
	}

}
