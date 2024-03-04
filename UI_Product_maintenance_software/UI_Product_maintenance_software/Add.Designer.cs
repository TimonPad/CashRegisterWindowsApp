
namespace UI_Product_maintenance_software
{
    partial class Add
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
            this.Name_box = new System.Windows.Forms.TextBox();
            this.labelproductname = new System.Windows.Forms.Label();
            this.labelproductprice = new System.Windows.Forms.Label();
            this.Price_box = new System.Windows.Forms.TextBox();
            this.labelavailable = new System.Windows.Forms.Label();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.Addproduct_Save = new System.Windows.Forms.Button();
            this.Addproduct_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New product details:";
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(114, 80);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(237, 20);
            this.Name_box.TabIndex = 1;
            this.Name_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(32, 83);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(76, 13);
            this.labelproductname.TabIndex = 2;
            this.labelproductname.Text = "Product name:";
            // 
            // labelproductprice
            // 
            this.labelproductprice.AutoSize = true;
            this.labelproductprice.Location = new System.Drawing.Point(32, 145);
            this.labelproductprice.Name = "labelproductprice";
            this.labelproductprice.Size = new System.Drawing.Size(73, 13);
            this.labelproductprice.TabIndex = 3;
            this.labelproductprice.Text = "Product price:";
            // 
            // Price_box
            // 
            this.Price_box.Location = new System.Drawing.Point(114, 142);
            this.Price_box.Name = "Price_box";
            this.Price_box.Size = new System.Drawing.Size(237, 20);
            this.Price_box.TabIndex = 4;
            // 
            // labelavailable
            // 
            this.labelavailable.AutoSize = true;
            this.labelavailable.Location = new System.Drawing.Point(32, 190);
            this.labelavailable.Name = "labelavailable";
            this.labelavailable.Size = new System.Drawing.Size(53, 13);
            this.labelavailable.TabIndex = 5;
            this.labelavailable.Text = "Available:";
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(114, 186);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYes.TabIndex = 6;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(163, 186);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 7;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // Addproduct_Save
            // 
            this.Addproduct_Save.Location = new System.Drawing.Point(195, 219);
            this.Addproduct_Save.Name = "Addproduct_Save";
            this.Addproduct_Save.Size = new System.Drawing.Size(75, 23);
            this.Addproduct_Save.TabIndex = 8;
            this.Addproduct_Save.Text = "Save";
            this.Addproduct_Save.UseVisualStyleBackColor = true;
            this.Addproduct_Save.Click += new System.EventHandler(this.Addproduct_Save_Click);
            // 
            // Addproduct_Cancel
            // 
            this.Addproduct_Cancel.Location = new System.Drawing.Point(276, 219);
            this.Addproduct_Cancel.Name = "Addproduct_Cancel";
            this.Addproduct_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Addproduct_Cancel.TabIndex = 9;
            this.Addproduct_Cancel.Text = "Cancel";
            this.Addproduct_Cancel.UseVisualStyleBackColor = true;
            this.Addproduct_Cancel.Click += new System.EventHandler(this.Addproduct_Cancel_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 279);
            this.Controls.Add(this.Addproduct_Cancel);
            this.Controls.Add(this.Addproduct_Save);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.labelavailable);
            this.Controls.Add(this.Price_box);
            this.Controls.Add(this.labelproductprice);
            this.Controls.Add(this.labelproductname);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.Label labelproductprice;
        private System.Windows.Forms.TextBox Price_box;
        private System.Windows.Forms.Label labelavailable;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Button Addproduct_Save;
        private System.Windows.Forms.Button Addproduct_Cancel;
    }
}