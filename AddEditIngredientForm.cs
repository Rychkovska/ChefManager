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
	public partial class AddEditIngredientForm : Form
	{
		private Ingredient selectedIngredient;

		public Ingredient NewIngredient { get; set; }

		// 1. Конструктор без параметрів (статичні категорії)
		public AddEditIngredientForm()
		{
			InitializeComponent();

			// Ініціалізуємо ComboBox статичними значеннями
			InitializeStaticCategories();
		}

		// 2. Конструктор для редагування існуючого інгредієнта
		public AddEditIngredientForm(Ingredient selectedIngredient)
		{
			InitializeComponent();

			this.selectedIngredient = selectedIngredient;

			// Ініціалізуємо ComboBox статичними значеннями
			InitializeStaticCategories();

			// Якщо передано інгредієнт, заповнюємо поля форми
			if (selectedIngredient != null)
			{
				txtName.Text = selectedIngredient.Name;
				txtPrice.Text = selectedIngredient.Price.ToString();
				txtQuantity.Text = selectedIngredient.Quantity.ToString();
				cmbCategory.SelectedItem = selectedIngredient.Category;
			}
		}

		// 3. Конструктор з динамічними категоріями (поєднання 1-го і 3-го варіантів)
		public AddEditIngredientForm(List<string> dynamicCategories) : this()
		{
			// Додаємо динамічні категорії
			AddDynamicCategories(dynamicCategories);
		}

		// 4. Конструктор з інгредієнтом та динамічними категоріями
		public AddEditIngredientForm(Ingredient selectedIngredient, List<string> dynamicCategories) : this(selectedIngredient)
		{
			// Додаємо динамічні категорії
			AddDynamicCategories(dynamicCategories);
		}

		// Метод для ініціалізації статичних значень
		private void InitializeStaticCategories()
		{
			cmbCategory.Items.Add("Овочі");
			cmbCategory.Items.Add("Фрукти");
			cmbCategory.Items.Add("М'ясо");
			cmbCategory.Items.Add("Молочні продукти");
		}

		// Метод для додавання динамічних категорій
		private void AddDynamicCategories(List<string> categories)
		{
			foreach (var category in categories)
			{
				if (!cmbCategory.Items.Contains(category)) // Уникнення дублювання
				{
					cmbCategory.Items.Add(category);
				}
			}
		}

		private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Ваш код для обробки зміни вибору в ComboBox
			MessageBox.Show("Вибір змінено");
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			try
			{
				// Отримуємо значення з полів форми
				string name = txtName.Text.Trim();
				if (string.IsNullOrEmpty(name))
				{
					MessageBox.Show("Будь ласка, введіть назву інгредієнта.");
					return;
				}

				if (!double.TryParse(txtPrice.Text.Trim(), out double price))
				{
					MessageBox.Show("Будь ласка, введіть коректну ціну.");
					return;
				}

				if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity))
				{
					MessageBox.Show("Будь ласка, введіть коректну кількість.");
					return;
				}

				string category = cmbCategory.SelectedItem?.ToString() ?? "DefaultCategory";

				// Створюємо новий інгредієнт
				NewIngredient = new Ingredient(name, category, price, quantity);

				// Повертаємо результат OK
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Помилка введення даних: {ex.Message}");
			}
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();  // Закрити форму без збереження
		}

		private void AddEditIngredientForm_Load(object sender, EventArgs e)
		{
			// Можна виконати будь-які додаткові дії при завантаженні форми
		}
	}
}
