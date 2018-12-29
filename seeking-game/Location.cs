using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seeking_game
{
    abstract class Location
    {
        public Location(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public Location[] Exits;

        public virtual string Description
        {
            get
            {
                string description = "You are in " + Name + ". You can see entries to following locations: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ", ";
                }
                description += ".";
                return description;
            }
        }
    }
}
