using System;

namespace ChefManager
{
	public class Recipe
	{
		// Властивість для назви страви
		public string Name { get; set; }

		// Властивість для інструкцій рецепту
		public string Instructions { get; set; }

		// Властивість для кількості персон
		public int Persons { get; set; }

		// Конструктор за замовчуванням
		public Recipe() { }

		// Конструктор з параметрами
		public Recipe(string name, string instructions, int persons)
		{
			Name = name;
			Instructions = instructions;
			Persons = persons;
		}

		// Метод для представлення рецепту у вигляді рядка
		public override string ToString()
		{
			return $"{Name}|{Instructions}|{Persons}";
		}

		// Статичний метод для створення рецепту з рядка
		public static Recipe FromString(string data)
		{
			var parts = data.Split('|');
			if (parts.Length != 3)
				throw new FormatException("Некоректний формат даних рецепту.");

			return new Recipe(parts[0], parts[1], int.Parse(parts[2]));
		}

		// Метод для перевірки інгредієнтів
		public void CheckIngredients()
		{
			Console.WriteLine($"Перевірка інгредієнтів для рецепту: {Name}");
		}
	}
}
