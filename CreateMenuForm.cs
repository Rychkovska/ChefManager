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
	public partial class CreateMenuForm : Form
	{
		public int Persons { get; private set; }
		public string MenuType { get; private set; }

		public CreateMenuForm()
		{
			InitializeComponent();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			// Перевірка введення кількості осіб
			if (int.TryParse(txtPersons.Text, out int persons) && persons > 0)
			{
				Persons = persons;
				MenuType = cmbMenuType.SelectedItem?.ToString() ?? "DefaultMenuType";
				// Вибір типу меню
				this.DialogResult = DialogResult.OK; // Повернення успішного результату
			}
			else
			{
				MessageBox.Show("Будь ласка, введіть коректну кількість осіб.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel; // Повернення результату скасування
		}

		private void CreateMenuForm_Load(object sender, EventArgs e)
		{
			InitializeMenuTypes(); // Ініціалізуємо ComboBox
		}

		private void InitializeMenuTypes()
		{
			// Статичний варіант ініціалізації ComboBox
			cmbMenuType.Items.Add("Щоденне меню");
			cmbMenuType.Items.Add("Меню для званої вечері");
			cmbMenuType.Items.Add("Особливе меню");

			// Встановлюємо перший елемент за замовчуванням
			cmbMenuType.SelectedIndex = 0;
		}
	}
}
