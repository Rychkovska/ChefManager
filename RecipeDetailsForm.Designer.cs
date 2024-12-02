namespace ChefManager
{
	partial class RecipeDetailsForm
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblInstructions = new System.Windows.Forms.Label();
			this.txtInstructions = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblName.Location = new System.Drawing.Point(27, 12);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(102, 18);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Назва страви";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(169, 10);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(290, 20);
			this.txtName.TabIndex = 1;
			// 
			// lblInstructions
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
			this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblInstructions.Location = new System.Drawing.Point(27, 82);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(57, 18);
			this.lblInstructions.TabIndex = 2;
			this.lblInstructions.Text = "Рецепт";
			// 
			// txtInstructions
			// 
			this.txtInstructions.Location = new System.Drawing.Point(169, 80);
			this.txtInstructions.Name = "txtInstructions";
			this.txtInstructions.Size = new System.Drawing.Size(290, 20);
			this.txtInstructions.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(12, 203);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(98, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Зберегти";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(132, 203);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(98, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Скасувати";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// RecipeDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ChefManager.Properties.Resources.burgundskoe_vino_shabli_1__2___1_;
			this.ClientSize = new System.Drawing.Size(509, 238);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtInstructions);
			this.Controls.Add(this.lblInstructions);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "RecipeDetailsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RecipeDetailsForm";
			this.Load += new System.EventHandler(this.RecipeDetailsForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblInstructions;
		private System.Windows.Forms.TextBox txtInstructions;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}