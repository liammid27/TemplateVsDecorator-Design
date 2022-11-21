using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesign
{
    public class Brute : CharacterCreator
    {
        public Brute(Characters character) : base(character)
        {

        }

        public override string CreateCharacter()
        {
            return character.CreateCharacter() + AddStats();
        }

        public string AddStats()
        {
            return "THE BRUTE \n" +
                "STRENGTH: 85\n" +
                "AGILITY: 30\n" +
                "DAMAGE: 8\n" +
                "WEAPONS: Club or Knuckle Busters\n";
        }
    }
}
