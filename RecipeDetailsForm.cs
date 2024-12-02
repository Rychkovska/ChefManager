using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChefManager
{
	public partial class RecipeDetailsForm : Form
	{
		public Recipe Recipe { get; private set; } // Рецепт, який буде створено або редаговано
		private bool _isEditMode; // Вказує, чи це режим редагування
		public RecipeDetailsForm(Recipe recipe = null)
		{
			InitializeComponent();
			// Перевіряємо, чи відкриваємо форму для редагування
			_isEditMode = recipe != null;

			if (_isEditMode)
			{
				// Якщо редагування, заповнюємо поля
				Text = "Редагувати рецепт";
				Recipe = recipe;
				txtName.Text = Recipe.Name;
				txtInstructions.Text = Recipe.Instructions;
			}
			else
			{
				// Якщо додавання, встановлюємо стандартний стан
				Text = "Додати новий рецепт";
				Recipe = new Recipe(); // Створюємо новий об'єкт
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Перевіряємо, чи введено назву рецепту
			if (string.IsNullOrWhiteSpace(txtName.Text))
			{
				MessageBox.Show("Назва рецепту не може бути порожньою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Перевіряємо, чи введено інструкції
			if (string.IsNullOrWhiteSpace(txtInstructions.Text))
			{
				MessageBox.Show("Інструкція не може бути порожньою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Зберігаємо введені дані до об'єкта Recipe
			Recipe.Name = txtName.Text;
			Recipe.Instructions = txtInstructions.Text;

			// Встановлюємо результат роботи форми
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Закриваємо форму без змін
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void RecipeDetailsForm_Load(object sender, EventArgs e)
		{

		}
	}
}
