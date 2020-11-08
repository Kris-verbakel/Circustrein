namespace Circustrein
{
    partial class animalApp
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
            this.animalAdd = new System.Windows.Forms.Button();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAdd = new System.Windows.Forms.ListBox();
            this.lbxAnimals = new System.Windows.Forms.ListBox();
            this.lbxWagons = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // animalAdd
            // 
            this.animalAdd.Location = new System.Drawing.Point(133, 237);
            this.animalAdd.Name = "animalAdd";
            this.animalAdd.Size = new System.Drawing.Size(142, 39);
            this.animalAdd.TabIndex = 0;
            this.animalAdd.Text = "Add animal";
            this.animalAdd.UseVisualStyleBackColor = true;
            this.animalAdd.Click += new System.EventHandler(this.animalAdd_Click);
            // 
            // cmbFood
            // 
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(131, 134);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(144, 24);
            this.cmbFood.TabIndex = 1;
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(631, 134);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(157, 24);
            this.cmbSize.TabIndex = 2;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(36, 134);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(89, 17);
            this.lblFood.TabIndex = 3;
            this.lblFood.Text = "Animal eats: ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(505, 137);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(120, 17);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size of the animal";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 22);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name: ";
            // 
            // lbxAdd
            // 
            this.lbxAdd.FormattingEnabled = true;
            this.lbxAdd.ItemHeight = 16;
            this.lbxAdd.Location = new System.Drawing.Point(292, 101);
            this.lbxAdd.Name = "lbxAdd";
            this.lbxAdd.Size = new System.Drawing.Size(207, 276);
            this.lbxAdd.TabIndex = 8;
            // 
            // lbxAnimals
            // 
            this.lbxAnimals.FormattingEnabled = true;
            this.lbxAnimals.ItemHeight = 16;
            this.lbxAnimals.Location = new System.Drawing.Point(292, 511);
            this.lbxAnimals.Name = "lbxAnimals";
            this.lbxAnimals.Size = new System.Drawing.Size(207, 100);
            this.lbxAnimals.TabIndex = 10;
            // 
            // lbxWagons
            // 
            this.lbxWagons.FormattingEnabled = true;
            this.lbxWagons.ItemHeight = 16;
            this.lbxWagons.Location = new System.Drawing.Point(39, 511);
            this.lbxWagons.Name = "lbxWagons";
            this.lbxWagons.Size = new System.Drawing.Size(207, 100);
            this.lbxWagons.TabIndex = 11;
            // 
            // animalApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 708);
            this.Controls.Add(this.lbxWagons);
            this.Controls.Add(this.lbxAnimals);
            this.Controls.Add(this.lbxAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.animalAdd);
            this.Name = "animalApp";
            this.Text = "Train application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button animalAdd;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxAdd;
        private System.Windows.Forms.ListBox lbxAnimals;
        private System.Windows.Forms.ListBox lbxWagons;
    }
}

