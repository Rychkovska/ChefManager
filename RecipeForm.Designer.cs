namespace ChefManager
{
	partial class RecipeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

            #region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridViewRecipes = new System.Windows.Forms.DataGridView();
			this.bntExit = new System.Windows.Forms.Button();
			this.btnAddRecipe = new System.Windows.Forms.Button();
			this.btnEditRecipe = new System.Windows.Forms.Button();
			this.btnDeleteRecipe = new System.Windows.Forms.Button();
			this.btnClearAllRecipes = new System.Windows.Forms.Button();
			this.btnSaveToFile = new System.Windows.Forms.Button();
			this.btnLoadFromFile = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewRecipes
			// 
			this.dataGridViewRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRecipes.Location = new System.Drawing.Point(12, 52);
			this.dataGridViewRecipes.Name = "dataGridViewRecipes";
			this.dataGridViewRecipes.Size = new System.Drawing.Size(605, 254);
			this.dataGridViewRecipes.TabIndex = 0;
			// 
			// bntExit
			// 
			this.bntExit.Location = new System.Drawing.Point(12, 12);
			this.bntExit.Name = "bntExit";
			this.bntExit.Size = new System.Drawing.Size(111, 23);
			this.bntExit.TabIndex = 1;
			this.bntExit.Text = "На головну";
			this.bntExit.UseVisualStyleBackColor = true;
			this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
			// 
			// btnAddRecipe
			// 
			this.btnAddRecipe.Location = new System.Drawing.Point(632, 52);
			this.btnAddRecipe.Name = "btnAddRecipe";
			this.btnAddRecipe.Size = new System.Drawing.Size(75, 23);
			this.btnAddRecipe.TabIndex = 2;
			this.btnAddRecipe.Text = "Додати";
			this.btnAddRecipe.UseVisualStyleBackColor = true;
			this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
			// 
			// btnEditRecipe
			// 
			this.btnEditRecipe.Location = new System.Drawing.Point(713, 52);
			this.btnEditRecipe.Name = "btnEditRecipe";
			this.btnEditRecipe.Size = new System.Drawing.Size(75, 23);
			this.btnEditRecipe.TabIndex = 3;
			this.btnEditRecipe.Text = "Редагувати";
			this.btnEditRecipe.UseVisualStyleBackColor = true;
			this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);
			// 
			// btnDeleteRecipe
			// 
			this.btnDeleteRecipe.Location = new System.Drawing.Point(632, 117);
			this.btnDeleteRecipe.Name = "btnDeleteRecipe";
			this.btnDeleteRecipe.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteRecipe.TabIndex = 4;
			this.btnDeleteRecipe.Text = "Видалити";
			this.btnDeleteRecipe.UseVisualStyleBackColor = true;
			this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
			// 
			// btnClearAllRecipes
			// 
			this.btnClearAllRecipes.Location = new System.Drawing.Point(713, 117);
			this.btnClearAllRecipes.Name = "btnClearAllRecipes";
			this.btnClearAllRecipes.Size = new System.Drawing.Size(75, 23);
			this.btnClearAllRecipes.TabIndex = 5;
			this.btnClearAllRecipes.Text = "Очистити";
			this.btnClearAllRecipes.UseVisualStyleBackColor = true;
			this.btnClearAllRecipes.Click += new System.EventHandler(this.btnClearAllRecipes_Click);
			// 
			// btnSaveToFile
			// 
			this.btnSaveToFile.Location = new System.Drawing.Point(129, 12);
			this.btnSaveToFile.Name = "btnSaveToFile";
			this.btnSaveToFile.Size = new System.Drawing.Size(75, 23);
			this.btnSaveToFile.TabIndex = 6;
			this.btnSaveToFile.Text = "Зберегти";
			this.btnSaveToFile.UseVisualStyleBackColor = true;
			this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
			// 
			// btnLoadFromFile
			// 
			this.btnLoadFromFile.Location = new System.Drawing.Point(210, 12);
			this.btnLoadFromFile.Name = "btnLoadFromFile";
			this.btnLoadFromFile.Size = new System.Drawing.Size(84, 23);
			this.btnLoadFromFile.TabIndex = 7;
			this.btnLoadFromFile.Text = "Завантажити";
			this.btnLoadFromFile.UseVisualStyleBackColor = true;
			this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
			// 
			// RecipeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ChefManager.Properties.Resources.burgundskoe_vino_shabli_1__2___1_;
			this.ClientSize = new System.Drawing.Size(800, 323);
			this.Controls.Add(this.btnLoadFromFile);
			this.Controls.Add(this.btnSaveToFile);
			this.Controls.Add(this.btnClearAllRecipes);
			this.Controls.Add(this.btnDeleteRecipe);
			this.Controls.Add(this.btnEditRecipe);
			this.Controls.Add(this.btnAddRecipe);
			this.Controls.Add(this.bntExit);
			this.Controls.Add(this.dataGridViewRecipes);
			this.Name = "RecipeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Рецепти";
			this.Load += new System.EventHandler(this.RecipeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewRecipes;
		private System.Windows.Forms.Button bntExit;
		private System.Windows.Forms.Button btnAddRecipe;
		private System.Windows.Forms.Button btnEditRecipe;
		private System.Windows.Forms.Button btnDeleteRecipe;
		private System.Windows.Forms.Button btnClearAllRecipes;
		private System.Windows.Forms.Button btnSaveToFile;
		private System.Windows.Forms.Button btnLoadFromFile;
	}
}