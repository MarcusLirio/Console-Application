using ConsoleMarcus.model;
using System;

Posto p = new Posto();



string combustivelTipo = p.Combustivel();

decimal valorSolicitado = p.SolicitarTratarValorDoCombustivel();

int distanciaSolicitada = p.Distancia();

decimal valorDaViagem = p.Calculo(distanciaSolicitada, valorSolicitado);

Console.WriteLine($"O valor do seu combustivel à viagem, será: R${valorDaViagem}");
