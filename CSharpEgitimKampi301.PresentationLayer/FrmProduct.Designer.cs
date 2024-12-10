namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductName2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductId2 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductPrice2 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtProductStock2 = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtProductDescription2 = new System.Windows.Forms.Label();
            this.txtProductCategory2 = new System.Windows.Forms.Label();
            this.txtProductCategory = new System.Windows.Forms.ComboBox();
            this.btnList2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(111, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 45);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(111, 437);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(198, 45);
            this.btnGetById.TabIndex = 26;
            this.btnGetById.Text = "Get By Id";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(111, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 45);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(111, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 45);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(111, 62);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(201, 20);
            this.txtProductName.TabIndex = 20;
            // 
            // txtProductName2
            // 
            this.txtProductName2.AutoSize = true;
            this.txtProductName2.Location = new System.Drawing.Point(6, 65);
            this.txtProductName2.Name = "txtProductName2";
            this.txtProductName2.Size = new System.Drawing.Size(78, 13);
            this.txtProductName2.TabIndex = 19;
            this.txtProductName2.Text = "Product Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(319, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 470);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(110, 233);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(94, 45);
            this.btnList.TabIndex = 17;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(111, 36);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(201, 20);
            this.txtProductId.TabIndex = 16;
            // 
            // txtProductId2
            // 
            this.txtProductId2.AutoSize = true;
            this.txtProductId2.Location = new System.Drawing.Point(6, 39);
            this.txtProductId2.Name = "txtProductId2";
            this.txtProductId2.Size = new System.Drawing.Size(61, 13);
            this.txtProductId2.TabIndex = 15;
            this.txtProductId2.Text = "Product ID:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(111, 114);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(201, 20);
            this.txtProductPrice.TabIndex = 31;
            // 
            // txtProductPrice2
            // 
            this.txtProductPrice2.AutoSize = true;
            this.txtProductPrice2.Location = new System.Drawing.Point(6, 117);
            this.txtProductPrice2.Name = "txtProductPrice2";
            this.txtProductPrice2.Size = new System.Drawing.Size(74, 13);
            this.txtProductPrice2.TabIndex = 30;
            this.txtProductPrice2.Text = "Product Price:";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(111, 88);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(201, 20);
            this.txtProductStock.TabIndex = 29;
            // 
            // txtProductStock2
            // 
            this.txtProductStock2.AutoSize = true;
            this.txtProductStock2.Location = new System.Drawing.Point(6, 91);
            this.txtProductStock2.Name = "txtProductStock2";
            this.txtProductStock2.Size = new System.Drawing.Size(78, 13);
            this.txtProductStock2.TabIndex = 28;
            this.txtProductStock2.Text = "Product Stock:";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(110, 170);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(201, 57);
            this.txtProductDescription.TabIndex = 35;
            // 
            // txtProductDescription2
            // 
            this.txtProductDescription2.AutoSize = true;
            this.txtProductDescription2.Location = new System.Drawing.Point(6, 173);
            this.txtProductDescription2.Name = "txtProductDescription2";
            this.txtProductDescription2.Size = new System.Drawing.Size(103, 13);
            this.txtProductDescription2.TabIndex = 34;
            this.txtProductDescription2.Text = "Product Description:";
            // 
            // txtProductCategory2
            // 
            this.txtProductCategory2.AutoSize = true;
            this.txtProductCategory2.Location = new System.Drawing.Point(6, 143);
            this.txtProductCategory2.Name = "txtProductCategory2";
            this.txtProductCategory2.Size = new System.Drawing.Size(52, 13);
            this.txtProductCategory2.TabIndex = 32;
            this.txtProductCategory2.Text = "Category:";
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.FormattingEnabled = true;
            this.txtProductCategory.Location = new System.Drawing.Point(110, 140);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(203, 21);
            this.txtProductCategory.TabIndex = 36;
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(215, 233);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(94, 45);
            this.btnList2.TabIndex = 37;
            this.btnList2.Text = "List2";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(197)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(984, 495);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductDescription2);
            this.Controls.Add(this.txtProductCategory2);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductPrice2);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.txtProductStock2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductName2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtProductId2);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label txtProductName2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label txtProductId2;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label txtProductPrice2;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label txtProductStock2;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label txtProductDescription2;
        private System.Windows.Forms.Label txtProductCategory2;
        private System.Windows.Forms.ComboBox txtProductCategory;
        private System.Windows.Forms.Button btnList2;
    }
}