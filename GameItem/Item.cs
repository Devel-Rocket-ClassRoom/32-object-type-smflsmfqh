using System;
using System.Collections.Generic;
using System.Text;

class Item
{
    public string Name { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return $"Item {{ Name = {Name}, Price = {Price}}}";
    }
}
