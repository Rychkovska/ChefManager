namespace ChefManager
{
	partial class CreateMenuForm
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
			this.lblPersons = new System.Windows.Forms.Label();
			this.txtPersons = new System.Windows.Forms.TextBox();
			this.lblMenuType = new System.Windows.Forms.Label();
			this.cmbMenuType = new System.Windows.Forms.ComboBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPersons
			// 
			this.lblPersons.AutoSize = true;
			this.lblPersons.BackColor = System.Drawing.Color.Transparent;
			this.lblPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPersons.Location = new System.Drawing.Point(12, 45);
			this.lblPersons.Name = "lblPersons";
			this.lblPersons.Size = new System.Drawing.Size(105, 18);
			this.lblPersons.TabIndex = 0;
			this.lblPersons.Text = "Кількість осіб";
			// 
			// txtPersons
			// 
			this.txtPersons.Location = new System.Drawing.Point(140, 43);
			this.txtPersons.Name = "txtPersons";
			this.txtPersons.Size = new System.Drawing.Size(191, 20);
			this.txtPersons.TabIndex = 1;
			// 
			// lblMenuType
			// 
			this.lblMenuType.AutoSize = true;
			this.lblMenuType.BackColor = System.Drawing.Color.Transparent;
			this.lblMenuType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMenuType.Location = new System.Drawing.Point(12, 107);
			this.lblMenuType.Name = "lblMenuType";
			this.lblMenuType.Size = new System.Drawing.Size(75, 18);
			this.lblMenuType.TabIndex = 2;
			this.lblMenuType.Text = "Тип меню";
			// 
			// cmbMenuType
			// 
			this.cmbMenuType.FormattingEnabled = true;
			this.cmbMenuType.Location = new System.Drawing.Point(140, 104);
			this.cmbMenuType.Name = "cmbMenuType";
			this.cmbMenuType.Size = new System.Drawing.Size(191, 21);
			this.cmbMenuType.TabIndex = 3;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(15, 272);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(102, 23);
			this.btnCreate.TabIndex = 4;
			this.btnCreate.Text = "Створити";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(140, 272);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(102, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Скасувати";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// CreateMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ChefManager.Properties.Resources.burgundskoe_vino_shabli_1__2___1_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(371, 321);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.cmbMenuType);
			this.Controls.Add(this.lblMenuType);
			this.Controls.Add(this.txtPersons);
			this.Controls.Add(this.lblPersons);
			this.Name = "CreateMenuForm";
			this.Text = "CreateMenuForm";
			this.Load += new System.EventHandler(this.CreateMenuForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPersons;
		private System.Windows.Forms.TextBox txtPersons;
		private System.Windows.Forms.Label lblMenuType;
		private System.Windows.Forms.ComboBox cmbMenuType;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnCancel;
	}
}