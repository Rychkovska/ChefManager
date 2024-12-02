namespace ChefManager
{
	partial class fmain
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
			this.lblChefApp = new System.Windows.Forms.Label();
			this.btnrecipe = new System.Windows.Forms.Button();
			this.bntmenu = new System.Windows.Forms.Button();
			this.btninventar = new System.Windows.Forms.Button();
			this.btnexit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblChefApp
			// 
			this.lblChefApp.AutoSize = true;
			this.lblChefApp.BackColor = System.Drawing.Color.Transparent;
			this.lblChefApp.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChefApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblChefApp.Location = new System.Drawing.Point(242, 129);
			this.lblChefApp.Name = "lblChefApp";
			this.lblChefApp.Size = new System.Drawing.Size(109, 29);
			this.lblChefApp.TabIndex = 0;
			this.lblChefApp.Text = "ChefApp";
			// 
			// btnrecipe
			// 
			this.btnrecipe.BackColor = System.Drawing.Color.DarkKhaki;
			this.btnrecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnrecipe.Location = new System.Drawing.Point(211, 203);
			this.btnrecipe.Name = "btnrecipe";
			this.btnrecipe.Size = new System.Drawing.Size(165, 23);
			this.btnrecipe.TabIndex = 1;
			this.btnrecipe.Text = "Рецепти";
			this.btnrecipe.UseVisualStyleBackColor = false;
			this.btnrecipe.Click += new System.EventHandler(this.btnrecipe_Click);
			// 
			// bntmenu
			// 
			this.bntmenu.BackColor = System.Drawing.Color.DarkKhaki;
			this.bntmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bntmenu.Location = new System.Drawing.Point(211, 232);
			this.bntmenu.Name = "bntmenu";
			this.bntmenu.Size = new System.Drawing.Size(165, 23);
			this.bntmenu.TabIndex = 2;
			this.bntmenu.Text = "Меню";
			this.bntmenu.UseVisualStyleBackColor = false;
			this.bntmenu.Click += new System.EventHandler(this.bntmenu_Click);
			// 
			// btninventar
			// 
			this.btninventar.BackColor = System.Drawing.Color.DarkKhaki;
			this.btninventar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btninventar.Location = new System.Drawing.Point(211, 261);
			this.btninventar.Name = "btninventar";
			this.btninventar.Size = new System.Drawing.Size(165, 23);
			this.btninventar.TabIndex = 3;
			this.btninventar.Text = "Склад";
			this.btninventar.UseVisualStyleBackColor = false;
			this.btninventar.Click += new System.EventHandler(this.btninventar_Click);
			// 
			// btnexit
			// 
			this.btnexit.BackColor = System.Drawing.Color.DarkKhaki;
			this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnexit.Location = new System.Drawing.Point(211, 338);
			this.btnexit.Name = "btnexit";
			this.btnexit.Size = new System.Drawing.Size(165, 23);
			this.btnexit.TabIndex = 4;
			this.btnexit.Text = "Вийти";
			this.btnexit.UseVisualStyleBackColor = false;
			this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
			// 
			// fmain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ChefManager.Properties.Resources.burgundskoe_vino_shabli_1__2___1_;
			this.ClientSize = new System.Drawing.Size(576, 516);
			this.Controls.Add(this.btnexit);
			this.Controls.Add(this.btninventar);
			this.Controls.Add(this.bntmenu);
			this.Controls.Add(this.btnrecipe);
			this.Controls.Add(this.lblChefApp);
			this.Name = "fmain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.fmain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblChefApp;
		private System.Windows.Forms.Button btnrecipe;
		private System.Windows.Forms.Button bntmenu;
		private System.Windows.Forms.Button btninventar;
		private System.Windows.Forms.Button btnexit;
	}
}

