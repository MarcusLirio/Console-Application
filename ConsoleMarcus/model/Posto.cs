using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarcus.model
{
    public class Posto
    {


        public decimal SolicitarTratarValorDoCombustivel()
        {
            Console.Write("Digite o valor do combustivel: ");

            var valorDigitado = Console.ReadLine();
            decimal valorCovert = 0;

            if (decimal.TryParse(valorDigitado, out valorCovert) && valorCovert > 0)
            {
                return valorCovert;
            }
            else
            {
                Console.WriteLine("Você digitou um valor não válido. ");
                return SolicitarTratarValorDoCombustivel();

            }

        }


        public int Distancia()
        {
            Console.Write("Digite a distância: ");
            var distanciaDigitada = Console.ReadLine();
            int distanciaConvert = 0;

            if (int.TryParse(distanciaDigitada, out distanciaConvert) && distanciaConvert >= 0)
            {
                return distanciaConvert;
            }
            else
            {
                Console.WriteLine("Você digitou um valor não válido. ");
                return Distancia();
            }
        }

        public string Combustivel()
        {
            Console.Write("Qual o tipo do combustivel ? ");
            string combustiivelSolicitado = Console.ReadLine();


            if (combustiivelSolicitado.ToUpper() == "GASOLINA")
            {
                Console.WriteLine("O brasil esta com o preço mais controlado, pós pandemia do mundo");
                return combustiivelSolicitado;
          
            }
            else if (combustiivelSolicitado.ToUpper() == "ETANOL" ||
                combustiivelSolicitado.ToUpper() == "ALCOOL")
            {
                Console.WriteLine("A economia não sera tão grande por conta do preço da gasolina");
                return combustiivelSolicitado;
            }
            else if (combustiivelSolicitado.ToUpper() == "DIESEL")
            {
                Console.WriteLine("Subiu por conta da guerra");
                return combustiivelSolicitado;
            }
            else
            {
                return Combustivel();
            }
        }

        public decimal Calculo(int distancia, decimal valor)
        {
           
            return distancia * valor;
        }


    }
}
