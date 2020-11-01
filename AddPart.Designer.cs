namespace InventoryManagementSystem
{
    partial class AddPartScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.addPartInHouse = new System.Windows.Forms.RadioButton();
            this.addPartOutsourced = new System.Windows.Forms.RadioButton();
            this.addPartPrice = new System.Windows.Forms.TextBox();
            this.addPartInventory = new System.Windows.Forms.TextBox();
            this.addPartID = new System.Windows.Forms.TextBox();
            this.addPartMax = new System.Windows.Forms.TextBox();
            this.addPartName = new System.Windows.Forms.TextBox();
            this.addPartMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.machineIDLabel = new System.Windows.Forms.Label();
            this.addPartMachineID = new System.Windows.Forms.TextBox();
            this.addPartSave = new System.Windows.Forms.Button();
            this.addPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Part";
            // 
            // addPartInHouse
            // 
            this.addPartInHouse.AutoSize = true;
            this.addPartInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInHouse.Location = new System.Drawing.Point(143, 9);
            this.addPartInHouse.Name = "addPartInHouse";
            this.addPartInHouse.Size = new System.Drawing.Size(76, 17);
            this.addPartInHouse.TabIndex = 3;
            this.addPartInHouse.TabStop = true;
            this.addPartInHouse.Text = "In-House";
            this.addPartInHouse.UseVisualStyleBackColor = true;
            this.addPartInHouse.CheckedChanged += new System.EventHandler(this.addPartInHouse_CheckedChanged);
            // 
            // addPartOutsourced
            // 
            this.addPartOutsourced.AutoSize = true;
            this.addPartOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartOutsourced.Location = new System.Drawing.Point(226, 9);
            this.addPartOutsourced.Name = "addPartOutsourced";
            this.addPartOutsourced.Size = new System.Drawing.Size(90, 17);
            this.addPartOutsourced.TabIndex = 4;
            this.addPartOutsourced.TabStop = true;
            this.addPartOutsourced.Text = "Outsourced";
            this.addPartOutsourced.UseVisualStyleBackColor = true;
            this.addPartOutsourced.CheckedChanged += new System.EventHandler(this.addPartOutsourced_CheckedChanged);
            // 
            // addPartPrice
            // 
            this.addPartPrice.Location = new System.Drawing.Point(176, 175);
            this.addPartPrice.Name = "addPartPrice";
            this.addPartPrice.Size = new System.Drawing.Size(100, 20);
            this.addPartPrice.TabIndex = 5;
            // 
            // addPartInventory
            // 
            this.addPartInventory.Location = new System.Drawing.Point(176, 130);
            this.addPartInventory.Name = "addPartInventory";
            this.addPartInventory.Size = new System.Drawing.Size(100, 20);
            this.addPartInventory.TabIndex = 6;
            // 
            // addPartID
            // 
            this.addPartID.Location = new System.Drawing.Point(176, 49);
            this.addPartID.Name = "addPartID";
            this.addPartID.Size = new System.Drawing.Size(100, 20);
            this.addPartID.TabIndex = 7;
            // 
            // addPartMax
            // 
            this.addPartMax.Location = new System.Drawing.Point(176, 220);
            this.addPartMax.Name = "addPartMax";
            this.addPartMax.Size = new System.Drawing.Size(57, 20);
            this.addPartMax.TabIndex = 8;
            // 
            // addPartName
            // 
            this.addPartName.Location = new System.Drawing.Point(176, 88);
            this.addPartName.Name = "addPartName";
            this.addPartName.Size = new System.Drawing.Size(100, 20);
            this.addPartName.TabIndex = 10;
            // 
            // addPartMin
            // 
            this.addPartMin.Location = new System.Drawing.Point(292, 220);
            this.addPartMin.Name = "addPartMin";
            this.addPartMin.Size = new System.Drawing.Size(57, 20);
            this.addPartMin.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Min";
            // 
            // machineIDLabel
            // 
            this.machineIDLabel.AutoSize = true;
            this.machineIDLabel.Location = new System.Drawing.Point(96, 268);
            this.machineIDLabel.Name = "machineIDLabel";
            this.machineIDLabel.Size = new System.Drawing.Size(62, 13);
            this.machineIDLabel.TabIndex = 18;
            this.machineIDLabel.Text = "Machine ID";
            // 
            // addPartMachineID
            // 
            this.addPartMachineID.Location = new System.Drawing.Point(176, 265);
            this.addPartMachineID.Name = "addPartMachineID";
            this.addPartMachineID.Size = new System.Drawing.Size(100, 20);
            this.addPartMachineID.TabIndex = 19;
            // 
            // addPartSave
            // 
            this.addPartSave.Location = new System.Drawing.Point(274, 335);
            this.addPartSave.Name = "addPartSave";
            this.addPartSave.Size = new System.Drawing.Size(75, 23);
            this.addPartSave.TabIndex = 20;
            this.addPartSave.Text = "Save";
            this.addPartSave.UseVisualStyleBackColor = true;
            this.addPartSave.Click += new System.EventHandler(this.addPartSave_Click);
            // 
            // addPartCancel
            // 
            this.addPartCancel.Location = new System.Drawing.Point(355, 335);
            this.addPartCancel.Name = "addPartCancel";
            this.addPartCancel.Size = new System.Drawing.Size(75, 23);
            this.addPartCancel.TabIndex = 21;
            this.addPartCancel.Text = "Cancel";
            this.addPartCancel.UseVisualStyleBackColor = true;
            this.addPartCancel.Click += new System.EventHandler(this.addPartCancel_Click);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 370);
            this.Controls.Add(this.addPartCancel);
            this.Controls.Add(this.addPartSave);
            this.Controls.Add(this.addPartMachineID);
            this.Controls.Add(this.machineIDLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPartMin);
            this.Controls.Add(this.addPartName);
            this.Controls.Add(this.addPartMax);
            this.Controls.Add(this.addPartID);
            this.Controls.Add(this.addPartInventory);
            this.Controls.Add(this.addPartPrice);
            this.Controls.Add(this.addPartOutsourced);
            this.Controls.Add(this.addPartInHouse);
            this.Controls.Add(this.label1);
            this.Name = "AddPartScreen";
            this.Text = "IMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton addPartInHouse;
        private System.Windows.Forms.RadioButton addPartOutsourced;
        private System.Windows.Forms.TextBox addPartPrice;
        private System.Windows.Forms.TextBox addPartInventory;
        private System.Windows.Forms.TextBox addPartID;
        private System.Windows.Forms.TextBox addPartMax;
        private System.Windows.Forms.TextBox addPartName;
        private System.Windows.Forms.TextBox addPartMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label machineIDLabel;
        private System.Windows.Forms.TextBox addPartMachineID;
        private System.Windows.Forms.Button addPartSave;
        private System.Windows.Forms.Button addPartCancel;
    }
}