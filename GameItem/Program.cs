using System;

Inventory inven = new Inventory();
Weapon weapon1 = new Weapon { Name = "불꽃 검", Price = 500, Damage = 25 };
Weapon weapon2 = new Weapon { Name = "얼음 활", Price = 460, Damage = 20 };
Potion potion1 = new Potion { Name = "체력 물약", Price = 50, HealAmount = 100 };
Potion potion2 = new Potion { Name = "마나 물약", Price = 80, HealAmount = 50 };

inven.AddItem(weapon1);
inven.AddItem(weapon2);
inven.AddItem(potion1);
inven.AddItem(potion2);

Console.WriteLine("=== 인벤토리 시스템 테스트 ===");
Console.WriteLine();
Console.WriteLine("[인벤토리 내용]");
inven.ShowInventory();
Console.WriteLine();
Console.WriteLine("=== 타입 확인 테스트 ===");
Console.WriteLine($"sword의 타입: {weapon1.GetType().Name}");
Console.WriteLine($"sword.GetType() == typeof(Weapon): {weapon1.GetType() == typeof(Weapon)}");
Console.WriteLine($"sword.GetType() == typeof(Item): {weapon1.GetType() == typeof(Item)}");
Console.WriteLine($"sword is Item: {weapon1 is Item}");



