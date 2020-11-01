namespace InventoryManagementSystem
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.partsGrid = new System.Windows.Forms.DataGridView();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.partSearch = new System.Windows.Forms.Button();
            this.productSearch = new System.Windows.Forms.Button();
            this.AddPart = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Management System";
            // 
            // partsGrid
            // 
            this.partsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGrid.Location = new System.Drawing.Point(15, 132);
            this.partsGrid.Name = "partsGrid";
            this.partsGrid.Size = new System.Drawing.Size(445, 147);
            this.partsGrid.TabIndex = 2;
            this.partsGrid.Tag = "";
            // 
            // productsGrid
            // 
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Location = new System.Drawing.Point(489, 132);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.Size = new System.Drawing.Size(445, 147);
            this.productsGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Products";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(804, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 7;
            // 
            // partSearch
            // 
            this.partSearch.Location = new System.Drawing.Point(249, 104);
            this.partSearch.Name = "partSearch";
            this.partSearch.Size = new System.Drawing.Size(75, 23);
            this.partSearch.TabIndex = 8;
            this.partSearch.Text = "Search";
            this.partSearch.UseVisualStyleBackColor = true;
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(723, 103);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(75, 23);
            this.productSearch.TabIndex = 9;
            this.productSearch.Text = "Search";
            this.productSearch.UseVisualStyleBackColor = true;
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(223, 285);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(75, 23);
            this.AddPart.TabIndex = 10;
            this.AddPart.Text = "Add";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(304, 285);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(75, 23);
            this.modifyPart.TabIndex = 11;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(385, 285);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 23);
            this.deletePart.TabIndex = 12;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(859, 285);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteProduct.TabIndex = 15;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(778, 285);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(75, 23);
            this.modifyProduct.TabIndex = 14;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(697, 285);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 13;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(828, 385);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 16;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(InventoryManagementSystem.Inventory);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 430);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.partSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.partsGrid);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "IMS";
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView partsGrid;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button partSearch;
        private System.Windows.Forms.Button productSearch;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button exit;
        public System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
    }
}

