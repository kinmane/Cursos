/*
 * 5) Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
 * 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
 * Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
 * Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
 * fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média,
 * tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.
 */

namespace Exer05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tempo gasto na viagem: ");
            double timeSpent = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média: ");
            double averageSpeed = double.Parse(Console.ReadLine());
            
            double distance = timeSpent * averageSpeed;
            double fuelUsed = distance / 12;
            
            Console.WriteLine("A velocidade média é: " + averageSpeed);
            Console.WriteLine("O tempo gasto é: " + timeSpent);
            Console.WriteLine("A distância percorrida é: " + distance);
            Console.WriteLine("A quantidade de litros utilizada na viagem é: " + fuelUsed);
        }
    }
}