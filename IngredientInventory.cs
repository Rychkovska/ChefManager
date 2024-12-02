using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using ChefManager.ChefManager;

namespace ChefManager
{
	public class IngredientInventory : Inventory
	{
		public IngredientInventory()
		{
			Items = new List<Ingredient>();
		}

		// Додавання нового продукту на склад
		public override void AddItem(Ingredient ingredient)
		{
			Items.Add(ingredient);
		}

		// Редагування продукту на складі
		public override void EditItem(string name, Ingredient newIngredient)
		{
			var item = Items.FirstOrDefault(i => i.Name == name);
			if (item != null)
			{
				item.Name = newIngredient.Name;
				item.Category = newIngredient.Category;
				item.Price = newIngredient.Price;
				item.Quantity = newIngredient.Quantity;
			}
		}

		// Видалення продукту зі складу
		public override void DeleteItem(string name)
		{
			var item = Items.FirstOrDefault(i => i.Name == name);
			if (item != null)
			{
				Items.Remove(item);
			}
		}

		// Перевірка достатності запасів
		public override bool CheckSufficiency(Dictionary<string, int> requiredItems)
		{
			foreach (var requiredItem in requiredItems)
			{
				var item = Items.FirstOrDefault(i => i.Name == requiredItem.Key);
				if (item == null || item.Quantity < requiredItem.Value)
				{
					return false; // Якщо одного елемента недостатньо, повертаємо false
				}
			}
			return true; // Якщо всі продукти є у достатній кількості
		}

		// Генерація звіту про склад
		public override void GenerateReport(string path)
		{
			using (StreamWriter writer = new StreamWriter(path))
			{
				foreach (var item in Items)
				{
					writer.WriteLine($"{item.Name} - {item.Quantity} одиниць на складі");
				}
			}
		}
	}
}
