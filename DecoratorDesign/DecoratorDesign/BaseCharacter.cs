using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesign
{
    public class BaseCharacter : Characters
    {
        public string CreateCharacter()
        {
            return "This class is : ";
        }
    }
}
