using System;

namespace Classe_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesonagem objPersonagem = new Pesonagem();

            objPersonagem.nome = "Tsukamoto";
            objPersonagem.idade = 32;
            objPersonagem.armadura = "Voadora";

            Pesonagem objPersonagem2 = new Pesonagem();

            objPersonagem2.nome = "Joyce";
            objPersonagem2.idade = 18;
            objPersonagem2.armadura = "Flash";

            Console.WriteLine($"Personagem 1 = {objPersonagem.nome}");
            Console.WriteLine($"Personagem 2 = {objPersonagem2.nome}"); 
            Console.WriteLine($"Ataque = {objPersonagem.Atacar()}");
            Console.WriteLine($"Defesa = {objPersonagem2.Defender()}"); 
        }
    }
}