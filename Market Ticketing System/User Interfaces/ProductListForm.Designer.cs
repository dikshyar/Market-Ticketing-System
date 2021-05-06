
namespace Market_Ticketing_System.User_Interfaces
{
	partial class ProductListForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
			this.Add = new System.Windows.Forms.Button();
			this.Back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewProductList
			// 
			this.dataGridViewProductList.AllowUserToAddRows = false;
			this.dataGridViewProductList.AllowUserToDeleteRows = false;
			this.dataGridViewProductList.AllowUserToResizeColumns = false;
			this.dataGridViewProductList.AllowUserToResizeRows = false;
			this.dataGridViewProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewProductList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductList.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridViewProductList.Location = new System.Drawing.Point(12, 36);
			this.dataGridViewProductList.MultiSelect = false;
			this.dataGridViewProductList.Name = "dataGridViewProductList";
			this.dataGridViewProductList.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewProductList.RowHeadersWidth = 51;
			this.dataGridViewProductList.RowTemplate.Height = 24;
			this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProductList.Size = new System.Drawing.Size(958, 405);
			this.dataGridViewProductList.TabIndex = 0;
			this.dataGridViewProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(12, 7);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 1;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Back
			// 
			this.Back.Location = new System.Drawing.Point(93, 7);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(75, 23);
			this.Back.TabIndex = 2;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// ProductListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 453);
			this.ControlBox = false;
			this.Controls.Add(this.Back);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.dataGridViewProductList);
			this.Name = "ProductListForm";
			this.Text = "ProductList";
			this.Load += new System.EventHandler(this.ProductListForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewProductList;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Back;
	}
}