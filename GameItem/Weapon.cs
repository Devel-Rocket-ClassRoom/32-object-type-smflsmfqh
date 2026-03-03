using System;
using System.Collections.Generic;
using System.Text;

class Weapon : Item
{
    public int Damage { get; set; }

    public override string ToString()
    {
        return $"Weapon {{ Name = {Name}, Price = {Price}, Damage = {Damage}}} [Weapon]";
    }
}
