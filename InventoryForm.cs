using ChefManager.ChefManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChefManager
{
	public partial class InventoryForm : Form
	{
		private Inventory inventory;
		private BindingSource bindingSource;  // Додаємо BindingSource

		public InventoryForm()
		{
			InitializeComponent();
			inventory = new IngredientInventory();  // Використовуємо конкретну реалізацію Inventory
			bindingSource = new BindingSource();    // Ініціалізуємо BindingSource
			LoadData();  // Завантажуємо дані
		}

		// Завантажуємо дані в DataGridView
		private void LoadData()
		{
			bindingSource.DataSource = inventory.Items;  // Прив'язуємо дані до BindingSource
			dataGridViewInventory.DataSource = bindingSource;  // Прив'язуємо BindingSource до DataGridView
		}

		// Обробник події для додавання продукту
		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddEditIngredientForm addEditForm = new AddEditIngredientForm();
			if (addEditForm.ShowDialog() == DialogResult.OK)
			{
				Ingredient newIngredient = addEditForm.NewIngredient;
				inventory.AddItem(newIngredient);
				LoadData(); // Оновлюємо дані в DataGridView
			}
			RefreshInventoryGrid();
		}

		// Оновлення складу
		private void RefreshInventoryGrid()
		{
			bindingSource.ResetBindings(false);  // Оновлюємо дані в DataGridView
		}

		// Обробник події для редагування продукту
		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewInventory.SelectedRows.Count == 1)
			{
				string name = dataGridViewInventory.SelectedRows[0].Cells["Name"].Value.ToString();
				Ingredient selectedIngredient = inventory.Items.FirstOrDefault(i => i.Name == name);
				if (selectedIngredient != null)
				{
					// Відкриваємо форму для редагування інгредієнта
					AddEditIngredientForm addEditForm = new AddEditIngredientForm(selectedIngredient); // Викликаємо конструктор з параметром
					if (addEditForm.ShowDialog() == DialogResult.OK)
					{
						Ingredient updatedIngredient = addEditForm.NewIngredient;  // Отримуємо новий інгредієнт
						inventory.EditItem(name, updatedIngredient);  // Оновлюємо інгредієнт
						LoadData(); // Оновлюємо дані в DataGridView
					}
				}
			}
		}

		// Обробник події для видалення продукту
		private void btnDeleteRecipe_Click(object sender, EventArgs e)
		{
			if (dataGridViewInventory.SelectedRows.Count == 1)
			{
				string name = dataGridViewInventory.SelectedRows[0].Cells["Name"].Value.ToString();
				inventory.DeleteItem(name);
				bindingSource.ResetBindings(false);  // Оновлюємо дані в DataGridView
			}
		}

		// Обробник події для очищення таблиці
		private void btnClearTable_Click(object sender, EventArgs e)
		{
			inventory.Items.Clear();
			bindingSource.ResetBindings(false);  // Оновлюємо дані в DataGridView
		}

		// Обробник події для фільтрації
		private void btnFilter_Click(object sender, EventArgs e)
		{
			string category = comboBox1.SelectedItem?.ToString();
			if (category != null)
			{
				var filteredItems = inventory.Items.Where(item => item.Category == category).ToList();
				bindingSource.DataSource = filteredItems;  // Оновлюємо дані в BindingSource
			}
		}

		// Обробник події для перевірки достатності запасів
		private void btnCheckSufficiency_Click(object sender, EventArgs e)
		{
			var requiredItems = new Dictionary<string, int>
			{
				{ "Морква", 5 },  // приклад вимог
                { "Картопля", 10 }
			};

			bool sufficiency = inventory.CheckSufficiency(requiredItems);
			MessageBox.Show(sufficiency ? "Запаси достатні" : "Недостатньо запасів");
		}

		// Обробник події для генерування звіту
		private void btnGenerateReport_Click(object sender, EventArgs e)
		{
			string path = "report.txt";  // Задаємо шлях до файлу
			inventory.GenerateReport(path);
			MessageBox.Show("Звіт збережено в файл " + path);
		}

		// Обробник події для відкриття файлу
		private void btnopenfile_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";  // Фільтрація для CSV файлів
				openFileDialog.Title = "Виберіть файл для відкриття";  // Назва вікна

				if (openFileDialog.ShowDialog() == DialogResult.OK)  // Перевіряємо, чи вибрано файл
				{
					string filePath = openFileDialog.FileName;  // Отримуємо шлях до вибраного файлу
					try
					{
						var lines = File.ReadAllLines(filePath);  // Зчитуємо всі рядки з файлу
						var dataTable = new DataTable();

						// Припустимо, що перший рядок містить заголовки
						var headers = lines[0].Split(',');  // Розділяємо на стовпці
						foreach (var header in headers)
						{
							dataTable.Columns.Add(header);  // Додаємо стовпці в DataTable
						}

						// Додаємо решту даних у DataTable
						for (int i = 1; i < lines.Length; i++)
						{
							var row = lines[i].Split(',');
							dataTable.Rows.Add(row);  // Додаємо рядки до DataTable
						}

						// Встановлюємо дані в DataGridView
						dataGridViewInventory.DataSource = dataTable;
					}
					catch (Exception ex)
					{
						MessageBox.Show("Помилка при завантаженні файлу: " + ex.Message);
					}
				}
			}
		}

		// Обробник події для виходу з форми
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();  // Закриваємо поточну форму
		}

		// Обробник події для показу всіх записів
		private void btnShowAll_Click(object sender, EventArgs e)
		{
			LoadData(); // Завантажуємо всі дані без фільтрації
		}

		// Метод для завантаження даних при завантаженні форми
		private void InventoryForm_Load(object sender, EventArgs e)
		{
			// ініціалізація, якщо необхідно

			// Додаємо категорії в ComboBox при завантаженні форми
			comboBox1.Items.Add("Фрукти");
			comboBox1.Items.Add("Овочі");
			comboBox1.Items.Add("М'ясо");
			comboBox1.Items.Add("Молочні продукти");
			comboBox1.SelectedIndex = 0;  // За замовчуванням вибрана перша категорія
		}

		// Обробник події для зміни вибору категорії в комбобоксі
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnFilter_Click(sender, e);  // Викликаємо метод фільтрації після вибору категорії
		}
	}
}
