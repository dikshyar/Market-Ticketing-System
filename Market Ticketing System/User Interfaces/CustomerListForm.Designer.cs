
namespace Market_Ticketing_System.User_Interfaces
{
    partial class CustomerListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.dataGridViewCustomerList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(13, 13);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(95, 12);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 23);
            this.buttonback.TabIndex = 1;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // dataGridViewCustomerList
            // 
            this.dataGridViewCustomerList.AllowUserToAddRows = false;
            this.dataGridViewCustomerList.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerList.AllowUserToResizeColumns = false;
            this.dataGridViewCustomerList.AllowUserToResizeRows = false;
            this.dataGridViewCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomerList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCustomerList.Location = new System.Drawing.Point(13, 42);
            this.dataGridViewCustomerList.MultiSelect = false;
            this.dataGridViewCustomerList.Name = "dataGridViewCustomerList";
            this.dataGridViewCustomerList.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomerList.RowHeadersWidth = 51;
            this.dataGridViewCustomerList.RowTemplate.Height = 24;
            this.dataGridViewCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomerList.Size = new System.Drawing.Size(775, 396);
            this.dataGridViewCustomerList.TabIndex = 2;
            this.dataGridViewCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerList_CellContentClick);
            this.dataGridViewCustomerList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCustomerList_RowHeaderMouseDoubleClick);
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCustomerList);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonadd);
            this.Name = "CustomerListForm";
            this.Text = "Customerlistform";
            this.Load += new System.EventHandler(this.customerlistform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.DataGridView dataGridViewCustomerList;
    }
}