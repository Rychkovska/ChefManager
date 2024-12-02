namespace ChefManager
{
	partial class MenuForm
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
			this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
			this.btnSaveToFile = new System.Windows.Forms.Button();
			this.btnClearTable = new System.Windows.Forms.Button();
			this.btnDeleteRecipe = new System.Windows.Forms.Button();
			this.btnCreateMenu = new System.Windows.Forms.Button();
			this.btnBackToMain = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewMenu
			// 
			this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMenu.Location = new System.Drawing.Point(12, 47);
			this.dataGridViewMenu.Name = "dataGridViewMenu";
			this.dataGridViewMenu.Size = new System.Drawing.Size(776, 391);
			this.dataGridViewMenu.TabIndex = 0;
			// 
			// btnSaveToFile
			// 
			this.btnSaveToFile.Location = new System.Drawing.Point(129, 12);
			this.btnSaveToFile.Name = "btnSaveToFile";
			this.btnSaveToFile.Size = new System.Drawing.Size(75, 23);
			this.btnSaveToFile.TabIndex = 13;
			this.btnSaveToFile.Text = "Зберегти";
			this.btnSaveToFile.UseVisualStyleBackColor = true;
			this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
			// 
			// btnClearTable
			// 
			this.btnClearTable.Location = new System.Drawing.Point(372, 12);
			this.btnClearTable.Name = "btnClearTable";
			this.btnClearTable.Size = new System.Drawing.Size(75, 23);
			this.btnClearTable.TabIndex = 12;
			this.btnClearTable.Text = "Очистити";
			this.btnClearTable.UseVisualStyleBackColor = true;
			this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
			// 
			// btnDeleteRecipe
			// 
			this.btnDeleteRecipe.Location = new System.Drawing.Point(291, 12);
			this.btnDeleteRecipe.Name = "btnDeleteRecipe";
			this.btnDeleteRecipe.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteRecipe.TabIndex = 11;
			this.btnDeleteRecipe.Text = "Видалити";
			this.btnDeleteRecipe.UseVisualStyleBackColor = true;
			this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
			// 
			// btnCreateMenu
			// 
			this.btnCreateMenu.Location = new System.Drawing.Point(210, 12);
			this.btnCreateMenu.Name = "btnCreateMenu";
			this.btnCreateMenu.Size = new System.Drawing.Size(75, 23);
			this.btnCreateMenu.TabIndex = 9;
			this.btnCreateMenu.Text = "Додати";
			this.btnCreateMenu.UseVisualStyleBackColor = true;
			this.btnCreateMenu.Click += new System.EventHandler(this.btnCreateMenu_Click);
			// 
			// btnBackToMain
			// 
			this.btnBackToMain.Location = new System.Drawing.Point(12, 12);
			this.btnBackToMain.Name = "btnBackToMain";
			this.btnBackToMain.Size = new System.Drawing.Size(111, 23);
			this.btnBackToMain.TabIndex = 8;
			this.btnBackToMain.Text = "На головну";
			this.btnBackToMain.UseVisualStyleBackColor = true;
			this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ChefManager.Properties.Resources.burgundskoe_vino_shabli_1__2___1_;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSaveToFile);
			this.Controls.Add(this.btnClearTable);
			this.Controls.Add(this.btnDeleteRecipe);
			this.Controls.Add(this.btnCreateMenu);
			this.Controls.Add(this.btnBackToMain);
			this.Controls.Add(this.dataGridViewMenu);
			this.Name = "MenuForm";
			this.Text = "Меню";
			this.Load += new System.EventHandler(this.MenuForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewMenu;
		private System.Windows.Forms.Button btnSaveToFile;
		private System.Windows.Forms.Button btnClearTable;
		private System.Windows.Forms.Button btnDeleteRecipe;
		private System.Windows.Forms.Button btnCreateMenu;
		private System.Windows.Forms.Button btnBackToMain;
	}
}