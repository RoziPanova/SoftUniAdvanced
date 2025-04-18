using PokemonTrainer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (trainers.Any(x => x.Name == tokens[0]))
                {
                    Pokemon pokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));
                    trainers.FirstOrDefault(x => x.Name == tokens[0]).Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer trainer = new Trainer(tokens[0], 0, new List<Pokemon>() { new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3])) });
                    trainers.Add(trainer);
                }
            }
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                foreach (var item in trainers)
                {
                    int contains = 0;
                    foreach (var pokemon in item.Pokemons)
                    {
                        if (pokemon.Element == line)
                        {
                            contains++;
                        }
                    }
                    if (contains > 0)
                    {
                        item.Badges++;
                    }
                    else
                    {
                        List<Pokemon> remove = new List<Pokemon>();
                        foreach (var pokemon in item.Pokemons)
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health <= 0)
                            {
                                remove.Add(pokemon);
                            }
                        }
                        for (int i = 0; i < remove.Count; i++)
                        {
                            item.Pokemons.Remove(remove[i]);
                        }
                    }
                }
            }
            var ordered = trainers.OrderByDescending(x => x.Badges);
            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Name} {item.Badges} {item.Pokemons.Count}");
            }
        }
    }
}
/*
Sam Blastoise Water 18
Narry Pikachu Electricity 22
John Kadabra Psychic 90
Tournament
Fire
Electricity
Fire
End
 */
