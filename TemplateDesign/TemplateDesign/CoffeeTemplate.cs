using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDesign
{
    public abstract class CoffeeTemplate
    {

        public void MakeCoffee()
        {
            BoilWater();
            AddMilk();
            AddSugar();
            AddCoffeePowder();
            Console.WriteLine(this.GetType().Name + " is Ready");
        }

        protected abstract void BoilWater();
        protected abstract void AddMilk();
        protected abstract void AddSugar();
        protected abstract void AddCoffeePowder();

    }
}
