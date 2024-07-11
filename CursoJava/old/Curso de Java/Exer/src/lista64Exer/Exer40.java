
/*******************************************************************************
 * 40) A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03
 * grupos de indústrias que são altamente poluentes do meio ambiente. O índice
 * de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as
 * indústrias do 1o grupo são intimadas a suspenderem suas atividades, se o
 * índice crescer para 0,4 as industrias do 1o e 2o grupo são intimadas a
 * suspenderem suas atividades, se o índice atingir 0,5 todos os grupos devem ser
 * notificados a paralisarem suas atividades. Faça um programa que leia o índice
 * de poluição medido e emita a notificação adequada aos diferentes grupos de
 * empresas. O algoritmo só deve parar de rodar quando o usuário responder "S" na
 * seguinte pergunta, "Deseja encerrar o programa?".
 *******************************************************************************/

import java.util.Scanner;

public class Exer40 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        double indicePoluicao;
        String continuar = "S";

        while (continuar.equals("S")) {
            System.out.print("Digite o índice de poluição medido: ");
            indicePoluicao = sc.nextDouble();

            if (indicePoluicao >= 0.05 && indicePoluicao <= 0.25) {
                System.out.println("Índice de poluição aceitável.");
            } else if (indicePoluicao > 0.25 && indicePoluicao < 0.3) {
                System.out.println("Atenção: Grupo 1 deve suspender suas atividades.");
            } else if (indicePoluicao >= 0.3 && indicePoluicao < 0.4) {
                System.out.println("Atenção: Grupos 1 e 2 devem suspender suas atividades.");
            } else if (indicePoluicao >= 0.4 && indicePoluicao < 0.5) {
                System.out.println("Atenção: Grupos 1, 2 e 3 devem suspender suas atividades.");
            } else if (indicePoluicao >= 0.5) {
                System.out.println("Atenção: Todos os grupos devem suspender suas atividades.");
            }

            System.out.print("Deseja encerrar o programa? (S/N): ");
            continuar = sc.next().toUpperCase();
        }

        sc.close();
    }

}
