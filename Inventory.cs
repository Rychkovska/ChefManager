using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefManager
{
	using System;
	using System.Collections.Generic;

	namespace ChefManager
	{
		public abstract class Inventory
		{
			// Список всіх продуктів на складі
			public List<Ingredient> Items { get; set; }

			// Абстрактні методи для управління продуктами
			public abstract void AddItem(Ingredient ingredient);
			public abstract void EditItem(string name, Ingredient newIngredient);
			public abstract void DeleteItem(string name);

			// Перевірка достатності запасів для списку продуктів
			public abstract bool CheckSufficiency(Dictionary<string, int> requiredItems);

			// Генерація звіту
			public abstract void GenerateReport(string path);
		}
	}

}
