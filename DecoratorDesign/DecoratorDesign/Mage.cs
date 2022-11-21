using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesign
{
    public class Mage : CharacterCreator
    {
        public Mage(Characters character) : base(character)
        {

        }

        public override string CreateCharacter()
        {
            return character.CreateCharacter() + AddStats();
        }

        public string AddStats()
        {
            return "THE MAGE \n" +
                "STRENGTH: 50\n" +
                "AGILITY: 60\n" +
                "DAMAGE: 4\n" +
                "WEAPONS: Staff or Rings of Depression\n";
        }
    }
}
