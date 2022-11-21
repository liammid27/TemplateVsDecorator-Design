using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesign
{
    public class Hunter : CharacterCreator
    {
        public Hunter(Characters character) : base(character)
        {

        }

        public override string CreateCharacter()
        {
            return character.CreateCharacter() + AddStats();
        }

        public string AddStats()
        {
            return "THE HUNTER \n" +
                "STRENGTH: 60\n" +
                "AGILITY: 80\n" +
                "DAMAGE: 6\n" +
                "WEAPONS: Axe or Throwing Knives\n";
        }
    }
}
