namespace OOP301EF.PresentationLayer
{
    partial class FrmProducts
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
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(94, 598);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(142, 23);
            this.btnGetById.TabIndex = 25;
            this.btnGetById.Text = "Get by ID";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(94, 555);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 503);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(71, 418);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(80, 23);
            this.btnList.TabIndex = 21;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(165, 107);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(152, 22);
            this.txtProductName.TabIndex = 19;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(44, 113);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 18;
            this.lblProductName.Text = "Product Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 748);
            this.dataGridView1.TabIndex = 15;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(165, 56);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(152, 22);
            this.txtProductId.TabIndex = 14;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(68, 62);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(69, 16);
            this.lblProductId.TabIndex = 13;
            this.lblProductId.Text = "Product ID";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(38, 312);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(102, 16);
            this.lbl.TabIndex = 28;
            this.lbl.Text = "Category Name";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(165, 204);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(152, 22);
            this.txtProductPrice.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Prdouct Price";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(165, 248);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(152, 22);
            this.txtProductStock.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Product Stock";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(165, 155);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(152, 22);
            this.txtProductDescription.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Product Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(165, 304);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(152, 24);
            this.cmbCategoryName.TabIndex = 39;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 792);
            this.Controls.Add(this.cmbCategoryName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblProductId);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCategoryName;
    }
}