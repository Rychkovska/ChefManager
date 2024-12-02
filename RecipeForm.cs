using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChefManager
{
	public partial class RecipeForm : Form
	{
		private List<Recipe> _recipes = new List<Recipe>(); // Список рецептів
		private RecipeManager _recipeManager = new RecipeManager(); // Менеджер для роботи з рецептами

		public RecipeForm()
		{
			InitializeComponent();
			SetupDataGridViewColumns(); // Налаштування колонок DataGridView
			RefreshRecipeGrid(); // Оновлення DataGrid при завантаженні форми
		}

		// Налаштування колонок для DataGridView
		private void SetupDataGridViewColumns()
		{
			dataGridViewRecipes.Columns.Clear();

			// Додавання колонок
			dataGridViewRecipes.Columns.Add("RecipeName", "Назва рецепту");
			dataGridViewRecipes.Columns.Add("RecipeInstructions", "Інструкції");

			// Налаштування автоматичного розміру колонок
			dataGridViewRecipes.Columns["RecipeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewRecipes.Columns["RecipeInstructions"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		// Оновлення DataGridView з рецептами
		private void RefreshRecipeGrid()
		{
			dataGridViewRecipes.Rows.Clear(); // Очищаємо таблицю перед оновленням

			foreach (var recipe in _recipeManager.Recipes)
			{
				dataGridViewRecipes.Rows.Add(recipe.Name, recipe.Instructions);
			}
		}

		private void bntExit_Click(object sender, EventArgs e)
		{
			this.Close(); // Закриваємо форму
		}

		private void btnSaveToFile_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Text Files|*.txt";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					_recipeManager.SaveRecipesToFile(saveFileDialog.FileName); // Зберігаємо рецепти у файл
					MessageBox.Show("Рецепти збережено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void btnAddRecipe_Click(object sender, EventArgs e)
		{
			using (var detailsForm = new RecipeDetailsForm())
			{
				if (detailsForm.ShowDialog() == DialogResult.OK)
				{
					_recipeManager.AddRecipe(detailsForm.Recipe); // Додаємо рецепт до менеджера
					RefreshRecipeGrid(); // Оновлюємо DataGridView
				}
			}
		}

		private void btnEditRecipe_Click(object sender, EventArgs e)
		{
			if (dataGridViewRecipes.SelectedRows.Count > 0)
			{
				var selectedRow = dataGridViewRecipes.SelectedRows[0];
				var selectedRecipe = _recipeManager.Recipes[selectedRow.Index];

				using (var detailsForm = new RecipeDetailsForm(selectedRecipe))
				{
					if (detailsForm.ShowDialog() == DialogResult.OK)
					{
						_recipeManager.EditRecipe(selectedRow.Index, detailsForm.Recipe); // Оновлюємо рецепт у менеджері
						RefreshRecipeGrid(); // Оновлюємо DataGridView
					}
				}
			}
			else
			{
				MessageBox.Show("Будь ласка, виберіть рецепт для редагування.");
			}
		}

		private void btnDeleteRecipe_Click(object sender, EventArgs e)
		{
			if (dataGridViewRecipes.SelectedRows.Count > 0)
			{
				var selectedRow = dataGridViewRecipes.SelectedRows[0];
				string recipeName = selectedRow.Cells[0].Value?.ToString();

				if (!string.IsNullOrEmpty(recipeName))
				{
					var result = MessageBox.Show($"Ви впевнені, що хочете видалити рецепт: {recipeName}?", "Підтвердження", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						_recipeManager.DeleteRecipe(selectedRow.Index); // Видаляємо рецепт
						RefreshRecipeGrid(); // Оновлюємо DataGridView
					}
				}
				else
				{
					MessageBox.Show("Обраний рецепт недійсний або не має імені.");
				}
			}
			else
			{
				MessageBox.Show("Будь ласка, виберіть рецепт для видалення.");
			}
		}

		private void btnClearAllRecipes_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Ви впевнені, що хочете очистити всі рецепти?", "Підтвердження", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				_recipeManager.ClearAllRecipes(); // Очищаємо всі рецепти з менеджера
				RefreshRecipeGrid(); // Оновлюємо DataGridView
			}
		}

		private void btnLoadFromFile_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Text Files|*.txt";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						_recipeManager.LoadRecipesFromFile(openFileDialog.FileName); // Завантажуємо рецепти з файлу
						RefreshRecipeGrid(); // Оновлюємо DataGridView
						MessageBox.Show("Рецепти завантажено успішно!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Помилка при завантаженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void RecipeForm_Load(object sender, EventArgs e)
		{

		}
	}
}
