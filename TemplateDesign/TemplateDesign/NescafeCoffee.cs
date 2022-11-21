﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDesign
{
    public class NescafeCoffee : CoffeeTemplate
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Boiled Water");
        }
        protected override void AddMilk()
        {
            Console.WriteLine("Milk Added");
        }
        protected override void AddSugar()
        {
            Console.WriteLine("Sugar Added");
        }
        protected override void AddCoffeePowder()
        {
            Console.WriteLine("Nescafe Coffee Added");
        }
    }
}
