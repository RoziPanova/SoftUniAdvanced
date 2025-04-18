using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    internal class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemon;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return pokemon; }
            set { pokemon = value; }
        }
        public Trainer(string name, int badges, List<Pokemon> pokemon)
        {
            this.name = name;
            this.badges = badges;
            this.pokemon = pokemon;
        }
    }
}
