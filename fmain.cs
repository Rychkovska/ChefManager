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
	public partial class fmain : Form
	{
		public fmain()
		{
			InitializeComponent();
		}

		private void btnrecipe_Click(object sender, EventArgs e)
		{
			RecipeForm recipesForm = new RecipeForm();
			recipesForm.ShowDialog();
		}

		private void bntmenu_Click(object sender, EventArgs e)
		{
			MenuForm menuForm = new MenuForm();
			menuForm.ShowDialog();
		}

		private void btninventar_Click(object sender, EventArgs e)
		{
			InventoryForm inventoryForm = new InventoryForm();
			inventoryForm.ShowDialog();
		}

		private void btnexit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				Application.Exit();
		}

		private void fmain_Load(object sender, EventArgs e)
		{

		}
	}
}
