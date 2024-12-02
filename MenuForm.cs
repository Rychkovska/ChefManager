using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChefManager
{
	public partial class MenuForm : Form
	{
		private List<Recipe> currentMenu;

		public MenuForm()
		{
			InitializeComponent();
			currentMenu = new List<Recipe>();
			// 1. Ініціалізація DataGridView
			InitializeDataGridView();
		}
		private void InitializeDataGridView()
		{
			// Створення стовпців DataGridView
			dataGridViewMenu.Columns.Clear();
			dataGridViewMenu.Columns.Add("RecipeName", "Назва страви");
			dataGridViewMenu.Columns.Add("Instructions", "Інструкції");

			// Налаштування автоматичного розміру стовпців
			dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}


		private void btnBackToMain_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void btnSaveToFile_Click(object sender, EventArgs e)
		{
			SaveMenuToFile();
		}
		private void SaveMenuToFile()
		{
			// Відкриваємо діалог для збереження файлу
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text File|*.txt";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
				{
					foreach (var recipe in currentMenu)
					{
						writer.WriteLine($"{recipe.Name} - {recipe.Instructions}");
					}
				}
				MessageBox.Show("Меню збережено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnCreateMenu_Click(object sender, EventArgs e)
		{
			var createMenuForm = new CreateMenuForm();

			if (createMenuForm.ShowDialog() == DialogResult.OK)
			{
				int persons = createMenuForm.Persons;
				string menuType = createMenuForm.MenuType;

				try
				{
					// Створюємо відповідне меню залежно від вибору
					if (menuType == "Щоденне меню")
					{
						var dailyMenu = new DailyMenu(persons);
						currentMenu = dailyMenu.Recipes;
					}
					else if (menuType == "Меню для званої вечері")
					{
						var dinnerPartyMenu = new DinnerPartyMenu(persons);

						// Перевіряємо, чи є рецепти в меню
						if (dinnerPartyMenu.Recipes.Count > 0)
						{
							currentMenu = dinnerPartyMenu.Recipes;
						}
						else
						{
							MessageBox.Show("Не вдалося створити меню для званої вечері. Будь ласка, перевірте дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}
					else if (menuType == "Особливе меню")
					{
						var specialMenu = new SpecialMenu(persons, "Вегетаріанське");
						currentMenu = specialMenu.Recipes;
					}
					else
					{
						MessageBox.Show("Невідомий тип меню.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					// Оновлюємо DataGridView після формування меню
					RefreshMenuGrid();
					MessageBox.Show($"Меню '{menuType}' створено успішно для {persons} осіб!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Сталася помилка при створенні меню: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		// Оновлює таблицю з меню
		private void RefreshMenuGrid()
		{
			dataGridViewMenu.Rows.Clear();
			foreach (var recipe in currentMenu)
			{
				dataGridViewMenu.Rows.Add(recipe.Name, recipe.Instructions);
			}
		}

		private void btnDeleteRecipe_Click(object sender, EventArgs e)
		{
			if (dataGridViewMenu.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow row in dataGridViewMenu.SelectedRows)
				{
					string recipeName = row.Cells["RecipeName"].Value.ToString();
					var recipeToDelete = currentMenu.FirstOrDefault(r => r.Name == recipeName);
					if (recipeToDelete != null)
					{
						currentMenu.Remove(recipeToDelete);
					}
				}
				RefreshMenuGrid();
			}
			else
			{
				MessageBox.Show("Будь ласка, виберіть запис для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClearTable_Click(object sender, EventArgs e)
		{
			currentMenu.Clear();
			RefreshMenuGrid();
		}

		private void MenuForm_Load(object sender, EventArgs e)
		{

		}
	}
	
}
