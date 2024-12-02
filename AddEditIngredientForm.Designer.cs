namespace ChefManager
{
	partial class AddEditIngredientForm
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblQ = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblcategory = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.btnYes = new System.Windows.Forms.Button();
			this.btnNo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblName.Location = new System.Drawing.Point(12, 21);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(51, 18);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Назва";
			// 
			// lblQ
			// 
			this.lblQ.AutoSize = true;
			this.lblQ.BackColor = System.Drawing.Color.Transparent;
			this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblQ.Location = new System.Drawing.Point(12, 78);
			this.lblQ.Name = "lblQ";
			this.lblQ.Size = new System.Drawing.Size(72, 18);
			this.lblQ.TabIndex = 1;
			this.lblQ.Text = "Кількість";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.BackColor = System.Drawing.Color.Transparent;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPrice.Location = new System.Drawing.Point(12, 141);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(38, 18);
			this.lblPrice.TabIndex = 2;
			this.lblPrice.Text = "Ціна";
			// 
			// lblcategory
			// 
			this.lblcategory.AutoSize = true;
			this.lblcategory.BackColor = System.Drawing.Color.Transparent;
			this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblcategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblcategory.Location = new System.Drawing.Point(12, 198);
			this.lblcategory.Name = "lblcategory";
			this.lblcategory.Size = new System.Drawing.Size(75, 18);
			this.lblcategory.TabIndex = 4;
			this.lblcategory.Text = "Категорія";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(126, 19);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(213, 20);
			this.txtName.TabIndex = 5;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(126, 139);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(213, 20);
			this.txtPrice.TabIndex = 6;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(126, 76);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(213, 20);
			this.txtQuantity.TabIndex = 7;
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(126, 199);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(213, 21);
			this.cmbCategory.TabIndex = 8;
			this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
			// 
			// btnYes
			// 
			this.btnYes.Location = new System.Drawing.Point(15, 295);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(89, 23);
			this.btnYes.TabIndex = 9;
			this.btnYes.Text = "Підтвердити";
			this.btnYes.UseVisualStyleBackColor = true;
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// btnNo
			// 
			this.btnNo.Location = new System.Drawing.Point(126, 295);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(89, 23);
			this.btnNo.TabIndex = 10;
			this.btnNo.Text = "Скасувати";
			this.btnNo.UseVisualStyleBackColor = true;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// AddEditIngredientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ChefManager.Properties.Resources.burgundskoe_vino_shabli_1__2___1_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(364, 330);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.btnYes);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblcategory);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblQ);
			this.Controls.Add(this.lblName);
			this.Name = "AddEditIngredientForm";
			this.Text = "AddEditIngredientForm";
			this.Load += new System.EventHandler(this.AddEditIngredientForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblQ;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblcategory;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Button btnYes;
		private System.Windows.Forms.Button btnNo;
	}
}