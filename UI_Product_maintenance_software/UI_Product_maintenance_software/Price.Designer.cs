
namespace UI_Product_maintenance_software
{
    partial class Price
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
            this.Price_box = new System.Windows.Forms.TextBox();
            this.Addproduct_Save = new System.Windows.Forms.Button();
            this.Addproduct_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter new price:";
            // 
            // Price_box
            // 
            this.Price_box.Location = new System.Drawing.Point(118, 29);
            this.Price_box.Name = "Price_box";
            this.Price_box.Size = new System.Drawing.Size(146, 20);
            this.Price_box.TabIndex = 1;
            this.Price_box.TextChanged += new System.EventHandler(this.Price_box_TextChanged);
            // 
            // Addproduct_Save
            // 
            this.Addproduct_Save.Location = new System.Drawing.Point(108, 68);
            this.Addproduct_Save.Name = "Addproduct_Save";
            this.Addproduct_Save.Size = new System.Drawing.Size(75, 23);
            this.Addproduct_Save.TabIndex = 9;
            this.Addproduct_Save.Text = "Save";
            this.Addproduct_Save.UseVisualStyleBackColor = true;
            this.Addproduct_Save.Click += new System.EventHandler(this.Addproduct_Save_Click);
            // 
            // Addproduct_Cancel
            // 
            this.Addproduct_Cancel.Location = new System.Drawing.Point(189, 68);
            this.Addproduct_Cancel.Name = "Addproduct_Cancel";
            this.Addproduct_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Addproduct_Cancel.TabIndex = 10;
            this.Addproduct_Cancel.Text = "Cancel";
            this.Addproduct_Cancel.UseVisualStyleBackColor = true;
            this.Addproduct_Cancel.Click += new System.EventHandler(this.Addproduct_Cancel_Click);
            // 
            // Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 115);
            this.Controls.Add(this.Addproduct_Cancel);
            this.Controls.Add(this.Addproduct_Save);
            this.Controls.Add(this.Price_box);
            this.Controls.Add(this.label1);
            this.Name = "Price";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Price_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Price_box;
        private System.Windows.Forms.Button Addproduct_Save;
        private System.Windows.Forms.Button Addproduct_Cancel;
    }
}