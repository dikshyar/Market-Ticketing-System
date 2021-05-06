
namespace Market_Ticketing_System.User_Interfaces
{
	partial class ProductForm
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
			this.components = new System.ComponentModel.Container();
			this.ProductFormDescription = new System.Windows.Forms.Label();
			this.ProductFormProductName = new System.Windows.Forms.Label();
			this.textBoxProductName = new System.Windows.Forms.TextBox();
			this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
			this.ProductListSaveButton = new System.Windows.Forms.Button();
			this.ProductListCancelButton = new System.Windows.Forms.Button();
			this.ProductFormActivity = new System.Windows.Forms.Label();
			this.ProductListActivity = new System.Windows.Forms.ComboBox();
			this.dropDownProductListActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productListFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.helperBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dropDownProductListActivityBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productListFormBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.helperBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// ProductFormDescription
			// 
			this.ProductFormDescription.AutoSize = true;
			this.ProductFormDescription.Location = new System.Drawing.Point(12, 89);
			this.ProductFormDescription.Name = "ProductFormDescription";
			this.ProductFormDescription.Size = new System.Drawing.Size(79, 17);
			this.ProductFormDescription.TabIndex = 0;
			this.ProductFormDescription.Text = "Description";
			// 
			// ProductFormProductName
			// 
			this.ProductFormProductName.AutoSize = true;
			this.ProductFormProductName.Location = new System.Drawing.Point(12, 50);
			this.ProductFormProductName.Name = "ProductFormProductName";
			this.ProductFormProductName.Size = new System.Drawing.Size(98, 17);
			this.ProductFormProductName.TabIndex = 0;
			this.ProductFormProductName.Text = "Product Name";
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.Location = new System.Drawing.Point(117, 50);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.Size = new System.Drawing.Size(578, 22);
			this.textBoxProductName.TabIndex = 1;
			//this.textBoxProductName.TextChanged += new System.EventHandler(this.textBoxProductName_TextChanged);
			// 
			// richTextBoxDescription
			// 
			this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBoxDescription.Location = new System.Drawing.Point(117, 89);
			this.richTextBoxDescription.Name = "richTextBoxDescription";
			this.richTextBoxDescription.Size = new System.Drawing.Size(578, 184);
			this.richTextBoxDescription.TabIndex = 2;
			this.richTextBoxDescription.Text = "";
			// 
			// ProductListSaveButton
			// 
			this.ProductListSaveButton.Location = new System.Drawing.Point(620, 279);
			this.ProductListSaveButton.Name = "ProductListSaveButton";
			this.ProductListSaveButton.Size = new System.Drawing.Size(75, 29);
			this.ProductListSaveButton.TabIndex = 3;
			this.ProductListSaveButton.Text = "Save";
			this.ProductListSaveButton.UseVisualStyleBackColor = true;
			this.ProductListSaveButton.Click += new System.EventHandler(this.ProductListSaveButton_Click);
			// 
			// ProductListCancelButton
			// 
			this.ProductListCancelButton.Location = new System.Drawing.Point(539, 279);
			this.ProductListCancelButton.Name = "ProductListCancelButton";
			this.ProductListCancelButton.Size = new System.Drawing.Size(75, 29);
			this.ProductListCancelButton.TabIndex = 3;
			this.ProductListCancelButton.Text = "Cancel";
			this.ProductListCancelButton.UseVisualStyleBackColor = true;
			this.ProductListCancelButton.Click += new System.EventHandler(this.ProductListCancelButton_Click);
			// 
			// ProductFormActivity
			// 
			this.ProductFormActivity.AutoSize = true;
			this.ProductFormActivity.Location = new System.Drawing.Point(15, 13);
			this.ProductFormActivity.Name = "ProductFormActivity";
			this.ProductFormActivity.Size = new System.Drawing.Size(52, 17);
			this.ProductFormActivity.TabIndex = 4;
			this.ProductFormActivity.Text = "Activity";
			// 
			// ProductListActivity
			// 
			this.ProductListActivity.AllowDrop = true;
			this.ProductListActivity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dropDownProductListActivityBindingSource, "Value", true));
			this.ProductListActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProductListActivity.FormattingEnabled = true;
			this.ProductListActivity.Location = new System.Drawing.Point(118, 13);
			this.ProductListActivity.Name = "ProductListActivity";
			this.ProductListActivity.Size = new System.Drawing.Size(578, 24);
			this.ProductListActivity.TabIndex = 5;
			this.ProductListActivity.SelectedIndexChanged += new System.EventHandler(this.ProductFormActivityList_SelectedIndexChanged);
			// 
			// dropDownProductListActivityBindingSource
			// 
			this.dropDownProductListActivityBindingSource.DataSource = typeof(Market_Ticketing_System.Helper.DropDownActivity);
			// 
			// productListFormBindingSource
			// 
			this.productListFormBindingSource.DataSource = typeof(Market_Ticketing_System.User_Interfaces.ProductListForm);
			// 
			// helperBindingSource
			// 
			this.helperBindingSource.DataSource = typeof(Market_Ticketing_System.Helper.Helper);
			// 
			// ProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 320);
			this.ControlBox = false;
			this.Controls.Add(this.ProductListActivity);
			this.Controls.Add(this.ProductFormActivity);
			this.Controls.Add(this.ProductListCancelButton);
			this.Controls.Add(this.ProductListSaveButton);
			this.Controls.Add(this.richTextBoxDescription);
			this.Controls.Add(this.textBoxProductName);
			this.Controls.Add(this.ProductFormProductName);
			this.Controls.Add(this.ProductFormDescription);
			this.Name = "ProductForm";
			this.Text = "ProductForm";
			this.Load += new System.EventHandler(this.ProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dropDownProductListActivityBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productListFormBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.helperBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ProductFormDescription;
		private System.Windows.Forms.Label ProductFormProductName;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.RichTextBox richTextBoxDescription;
		private System.Windows.Forms.Button ProductListSaveButton;
		private System.Windows.Forms.Button ProductListCancelButton;
		private System.Windows.Forms.Label ProductFormActivity;
		private System.Windows.Forms.BindingSource productListFormBindingSource;
		private System.Windows.Forms.BindingSource helperBindingSource;
		private System.Windows.Forms.BindingSource dropDownProductListActivityBindingSource;
		private System.Windows.Forms.ComboBox ProductListActivity;
	}
}