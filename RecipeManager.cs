using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefManager
{
	public class RecipeManager
	{
		// Список рецептів
		public List<Recipe> Recipes { get; private set; }

		// Конструктор
		public RecipeManager()
		{
			Recipes = new List<Recipe>();
		}

		// Метод для додавання нового рецепту
		public void AddRecipe(Recipe recipe)
		{
			if (recipe == null) throw new ArgumentNullException(nameof(recipe));
			Recipes.Add(recipe);
		}

		// Метод для редагування рецепту за індексом
		public void EditRecipe(int index, Recipe updatedRecipe)
		{
			if (index < 0 || index >= Recipes.Count)
				throw new IndexOutOfRangeException("Некоректний індекс рецепту.");
			if (updatedRecipe == null)
				throw new ArgumentNullException(nameof(updatedRecipe));
			Recipes[index] = updatedRecipe;
		}

		// Метод для видалення рецепту за індексом
		public void DeleteRecipe(int index)
		{
			if (index < 0 || index >= Recipes.Count)
				throw new IndexOutOfRangeException("Некоректний індекс рецепту.");
			Recipes.RemoveAt(index);
		}

		// Метод для очищення списку рецептів
		public void ClearAllRecipes()
		{
			Recipes.Clear();
		}

		// Метод для збереження рецептів у файл
		public void SaveRecipesToFile(string path)
		{
			using (StreamWriter writer = new StreamWriter(path))
			{
				foreach (var recipe in Recipes)
				{
					writer.WriteLine(recipe.ToString());
				}
			}
		}

		// Метод для завантаження рецептів із файлу
		public void LoadRecipesFromFile(string path)
		{
			Recipes.Clear(); // Очищаємо існуючий список
			foreach (var line in File.ReadLines(path))
			{
				Recipes.Add(Recipe.FromString(line));
			}
		}
	}
}
