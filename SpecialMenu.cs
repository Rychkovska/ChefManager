using ChefManager;
using System.Collections.Generic;

public class SpecialMenu : Menu
{
	public List<Recipe> Recipes { get; private set; }

	public SpecialMenu(int persons, string menuType)
	{
		Recipes = new List<Recipe>();
		GenerateSpecialMenu(persons, menuType);  // Викликаємо метод для створення меню для особливих випадків
	}

	public override void GenerateMenu(int persons)
	{
		// Цей метод не потрібен для SpecialMenu, так як ми працюємо лише зі специфічними стравами.
	}

	public void GenerateSpecialMenu(int persons, string menuType)
	{
		// Перевірка фільтра
		if (menuType == "Вегетаріанське")
		{
			Recipes.Add(new Recipe("Вегетаріанський суп", "Покроковий рецепт приготування вегетаріанського супу", persons));
			Recipes.Add(new Recipe("Вегетаріанська основна страва", "Покроковий рецепт приготування вегетаріанської страви", persons));
		}
		else if (menuType == "Дієтичне")
		{
			Recipes.Add(new Recipe("Дієтичний суп", "Покроковий рецепт приготування дієтичного супу", persons));
			Recipes.Add(new Recipe("Дієтична основна страва", "Покроковий рецепт приготування дієтичної страви", persons));
		}
		// Додати інші типи меню, якщо потрібно

		// Перевірка на достатність запасів
		foreach (var recipe in Recipes)
		{
			recipe.CheckIngredients();
		}
	}

	// Порожня реалізація методу
	public override void GenerateDinnerParty(int persons)
	{
		// Якщо метод не використовується, залиште його порожнім.
	}
}
