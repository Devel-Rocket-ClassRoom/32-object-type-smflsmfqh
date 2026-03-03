using System;
using System.Collections.Generic;
using System.Text;

class Potion : Item
{
    public int HealAmount { get; set; }

    public override string ToString()
    {
        return $"Potion {{ Name = {Name}, Price = {Price}, HealAmount = {HealAmount}}} [Potion]";
    }
}