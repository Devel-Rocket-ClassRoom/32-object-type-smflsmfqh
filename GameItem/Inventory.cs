using System;
using System.Collections.Generic;
using System.Text;

class Inventory
{
    object[] items = new object[10];
    private int _index = 0;

    public void AddItem(object item)
    {
        items[_index++] = item;
    }

    public void ShowInventory()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != null)
            {
                Console.WriteLine($"슬롯 {i + 1}: {items[i]}");
            }
        }
    }
}