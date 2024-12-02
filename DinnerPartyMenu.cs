using System;
using System.Collections.Generic;

namespace ChefManager
{
	public class DinnerPartyMenu : Menu
	{
		public List<Recipe> Recipes { get; private set; }

		public DinnerPartyMenu(int persons)
		{
			Recipes = new List<Recipe>();
			GenerateDinnerParty(persons);  // Викликаємо метод для генерації меню для званої вечері
		}

		public override void GenerateDinnerParty(int persons)
		{
			// Реалізація меню для званої вечері
			Recipes.Add(new Recipe("Салат Цезар", "Покроковий рецепт приготування салату Цезар", persons));
			Recipes.Add(new Recipe("Стейк із яловичини", "Покроковий рецепт приготування стейка", persons));
			Recipes.Add(new Recipe("Десерт Тірамісу", "Покроковий рецепт приготування тірамісу", persons));
			Recipes.Add(new Recipe("Червоне вино", "Рекомендована подача: на одну людину 150 мл", persons));

			// Перевірка наявності інгредієнтів
			foreach (var recipe in Recipes)
			{
				recipe.CheckIngredients(); // Метод для перевірки інгредієнтів
			}
		}

		public override void GenerateMenu(int persons)
		{
			// Залишимо цю реалізацію для "Щоденного меню" або інших типів меню, якщо вони потрібні
			Recipes.Add(new Recipe("Суп", "Покроковий рецепт приготування супу", persons));
			Recipes.Add(new Recipe("Основна страва", "Покроковий рецепт приготування основної страви", persons));
			Recipes.Add(new Recipe("Напій", "Покроковий рецепт приготування напою", persons));

			// Перевірка на достатність запасів
			foreach (var recipe in Recipes)
			{
				recipe.CheckIngredients();  // Метод для перевірки інгредієнтів
			}
		}
	}
}
