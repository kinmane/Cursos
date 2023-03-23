/*
*   5) Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
*   12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
*   Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
*   Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
*   fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média,
*   tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual foi o tempo da viagem? (em horas)");
            double time = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a velocidade média?");
            double speed = double.Parse(Console.ReadLine());

            double distance = time * speed;
            double usedLiters = distance / 12;

            Console.WriteLine("Velocidade média: " + speed + "Km/h");
            Console.WriteLine("Tempo gasto: " + time) + " horas";
            Console.WriteLine("Distância: " + distance + "Km");
            Console.WriteLine("Quantidade de litros usados: " + usedLiters);
        }
    }
}