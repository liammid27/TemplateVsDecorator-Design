using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesign
{
    public abstract class CharacterCreator
    {
        protected Characters character;
        public CharacterCreator(Characters character_)
        {
            this.character = character_;
        }

        public virtual string CreateCharacter()
        {
            return character.CreateCharacter();
        }

    }
}
