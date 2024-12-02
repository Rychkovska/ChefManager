namespace ChefManager
{
	partial class InventoryForm
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
			this.btnGenerateReport = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
			this.btnopenfile = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnFilter = new System.Windows.Forms.Button();
			this.btnShowAll = new System.Windows.Forms.Button();
			this.btnCheckSufficiency = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGenerateReport
			// 
			this.btnGenerateReport.Location = new System.Drawing.Point(584, 47);
			this.btnGenerateReport.Name = "btnGenerateReport";
			this.btnGenerateReport.Size = new System.Drawing.Size(75, 23);
			this.btnGenerateReport.TabIndex = 19;
			this.btnGenerateReport.Text = "Звіт";
			this.btnGenerateReport.UseVisualStyleBackColor = true;
			this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(665, 207);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 18;
			this.btnClear.Text = "Очистити";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClearTable_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(584, 207);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Видалити";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(584, 89);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "Додати";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(12, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(111, 23);
			this.btnExit.TabIndex = 15;
			this.btnExit.Text = "На головну";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// dataGridViewInventory
			// 
			this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewInventory.Location = new System.Drawing.Point(12, 47);
			this.dataGridViewInventory.Name = "dataGridViewInventory";
			this.dataGridViewInventory.Size = new System.Drawing.Size(566, 186);
			this.dataGridViewInventory.TabIndex = 14;
			// 
			// btnopenfile
			// 
			this.btnopenfile.Location = new System.Drawing.Point(665, 47);
			this.btnopenfile.Name = "btnopenfile";
			this.btnopenfile.Size = new System.Drawing.Size(75, 23);
			this.btnopenfile.TabIndex = 20;
			this.btnopenfile.Text = "Відкрити";
			this.btnopenfile.UseVisualStyleBackColor = true;
			this.btnopenfile.Click += new System.EventHandler(this.btnopenfile_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(665, 89);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 21;
			this.btnEdit.Text = "Редагувати";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(584, 131);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(156, 21);
			this.comboBox1.TabIndex = 22;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// btnFilter
			// 
			this.btnFilter.Location = new System.Drawing.Point(584, 158);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(75, 23);
			this.btnFilter.TabIndex = 23;
			this.btnFilter.Text = "Фільрувати";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// btnShowAll
			// 
			this.btnShowAll.Location = new System.Drawing.Point(665, 158);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(75, 23);
			this.btnShowAll.TabIndex = 24;
			this.btnShowAll.Text = "Скинути";
			this.btnShowAll.UseVisualStyleBackColor = true;
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// btnCheckSufficiency
			// 
			this.btnCheckSufficiency.Location = new System.Drawing.Point(602, 18);
			this.btnCheckSufficiency.Name = "btnCheckSufficiency";
			this.btnCheckSufficiency.Size = new System.Drawing.Size(129, 23);
			this.btnCheckSufficiency.TabIndex = 25;
			this.btnCheckSufficiency.Text = "Перевірити запаси";
			this.btnCheckSufficiency.UseVisualStyleBackColor = true;
			this.btnCheckSufficiency.Click += new System.EventHandler(this.btnCheckSufficiency_Click);
			// 
			// InventoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ChefManager.Properties.Resources.burgundskoe_vino_shabli_1__2___1_;
			this.ClientSize = new System.Drawing.Size(743, 242);
			this.Controls.Add(this.btnCheckSufficiency);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnopenfile);
			this.Controls.Add(this.btnGenerateReport);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.dataGridViewInventory);
			this.Name = "InventoryForm";
			this.Text = "Склад";
			this.Load += new System.EventHandler(this.InventoryForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGenerateReport;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DataGridView dataGridViewInventory;
		private System.Windows.Forms.Button btnopenfile;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Button btnShowAll;
		private System.Windows.Forms.Button btnCheckSufficiency;
	}
}