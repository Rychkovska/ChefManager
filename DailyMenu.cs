using ChefManager;
using System.Collections.Generic;

public class DailyMenu : Menu
{
	public List<Recipe> Recipes { get; private set; }

	public DailyMenu(int persons)
	{
		Recipes = new List<Recipe>();
		GenerateMenu(persons);  // Викликаємо метод для генерації меню на день
	}

	public override void GenerateMenu(int persons)
	{
		// Приклад стандартного меню на день
		Recipes.Add(new Recipe("Суп", "Покроковий рецепт приготування супу", persons));
		Recipes.Add(new Recipe("Основна страва", "Покроковий рецепт приготування основної страви", persons));
		Recipes.Add(new Recipe("Напій", "Покроковий рецепт приготування напою", persons));

		// Перевірка на достатність запасів
		foreach (var recipe in Recipes)
		{
			recipe.CheckIngredients();  // Метод для перевірки інгредієнтів
		}
	}

	public override void GenerateDinnerParty(int persons)
	{
		// Цей метод не потрібен для DailyMenu, але ми можемо залишити його за умовчанням.
		// Реалізація порожня або просто коментар.
	}
}
